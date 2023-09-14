using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05
{
    public partial class FrmPersona : Form
    {
        private Persona persona;
        public FrmPersona()
        {
            InitializeComponent();
        }
        public FrmPersona(Persona persona)
            :this()
        {
            this.persona = persona;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.txtEdad.Text, out int edadNumero))
            {
                MessageBox.Show("Edad erronea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.persona = new Persona(this.txtNombre.Text, this.txtApellido.Text, edadNumero);
                MessageBox.Show("Persona creada", "Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public Persona GetPersona()
        {
            return this.persona;
        }
    }
}
