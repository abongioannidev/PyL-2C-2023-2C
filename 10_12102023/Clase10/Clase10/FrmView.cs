using Entidades;
using Entidades.excepciones;
using Entidades.modelos;

namespace Clase10
{
    public partial class FrmView : Form
    {
        private int algo;

        public FrmView()
        {
            InitializeComponent();
        }

        public int Algo { get => this.Algo; set => this.Algo = value; }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                Alumno alumno = new Alumno(this.txtDni.Text);
                MessageBox.Show("Esto no se ejecuta si hay error", "No se ejecuta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /// acaaaa para abajo
            }
            catch (AlumnoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Exception innerException = ex.InnerException;
                while (innerException != null)
                {
                    MessageBox.Show(innerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    innerException = innerException.InnerException;
                }
            }


            // sigue ejecutando el codigo de aca

        }
    }
}