using Entidades;

namespace FrmView
{
    public partial class FrmView : Form
    {
        Task tareaReloj;
        CancellationTokenSource cancelation;
        Negocio negocio;
        public FrmView()
        {
            InitializeComponent();
            this.negocio = new Negocio();

        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            this.negocio.AbrirNegocio(this.AgregarALaLista);
        }


        private void AgregarALaLista(Persona persona)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(()=>this.AgregarALaLista(persona));
            }
            else
            {
                this.lstUsuarios.Items.Add(persona);

            }
        }


        private void IniciarReloj()
        {
            while (!this.cancelation.IsCancellationRequested)
            {
                this.ActualizarLabelReloj(DateTime.Now, 10);
                Thread.Sleep(1000);
            }
        }
        public delegate void Callback(DateTime dateTime, int valor);
        private void ActualizarLabelReloj(DateTime dateTime, int valor)
        {
            if (this.InvokeRequired)
            {
                //Callback cb = new Callback(this.ActualizarLabelReloj);
                //object[] param = new object[] { dateTime, valor };
                //this.BeginInvoke(cb, param);

                this.BeginInvoke(() => this.ActualizarLabelReloj(dateTime, valor));
            }
            else
            {
                this.lblReloj.Text = $"Reloj: {DateTime.Now.ToString("HH:mm:ss")}";
            }

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.negocio.CerrarNegocio();
            OtroForm otroForm = new OtroForm();
            otroForm.Lista = this.lstUsuarios.Items;
            otroForm.Show();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            this.cancelation = new CancellationTokenSource();
            this.tareaReloj = Task.Run(this.IniciarReloj, this.cancelation.Token);
        }

        private void FrmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cancelation.Cancel();
        }
    }
}