using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAgroVeterinaria.Registros
{
    public partial class rInventario : Form
    {
        public rInventario()
        {
            InitializeComponent();
        }


        public void LimpiarTextBox()
        {
            ProductotextBox.Clear();
            CantidadtextBox.Clear();
            FechatextBox.Clear();
            NombretextBox.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();

        }
    }
}
