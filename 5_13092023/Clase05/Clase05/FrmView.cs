using Entidades;

namespace Clase05
{
    public partial class FrmView : Form
    {
        public enum ECondimientos {Savora,Mayo, Chimichurri };
        FrmPersona frmPersona;
        public FrmView()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.frmPersona = new FrmPersona();
            frmPersona.ShowDialog();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {

            TextBox txt = new TextBox();
            txt.Name = "txtCodigo";
            txt.Text = "HOLAAAAA";
            txt.Location = new Point(78, 90);
            this.Controls.Add(txt);

            this.grpCheck.Text = "Animales";
            this.checkBox1.Text = "Perro";
            this.checkBox2.Text = "Gato";
            this.checkBox3.Text = "Conejo";

            this.comboBox1.DataSource = Enum.GetValues(typeof(ECondimientos));
            

        }

        private void FrmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resutlado = MessageBox.Show(
                "Queres cerrar?",
                "Cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (resutlado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "Lo cambie en el for each";
                }
            }
            foreach (Control item in this.grpCheck.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox ch = (CheckBox)item;
                    if (ch.Checked)
                    {
                        MessageBox.Show(ch.Text);
                    }
                }
            }
            this.Close();
        }

        private void btnVerPersona_Click(object sender, EventArgs e)
        {
            Persona p = this.frmPersona.GetPersona();
            string cadena = p.MostrarDatos();

            this.lstName.Items.Add(cadena);
            MessageBox.Show(
                cadena,
                "Datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

        }
    }
}