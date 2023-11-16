using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmView
{
    public partial class OtroForm : Form
    {
        public OtroForm()
        {
            InitializeComponent();
        }
        public ListBox.ObjectCollection Lista
        {
            set
            {
                this.listBox1.DataSource = value;
            }
        }
    }


}
