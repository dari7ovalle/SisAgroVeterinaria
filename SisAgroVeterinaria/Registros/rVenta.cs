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
    public partial class rVenta : Form
    {
        public rVenta()
        {
            InitializeComponent();
        }
        public void LimpiarTextBox()
        {
            VentatextBox.Clear();
            ClientetextBox.Clear();
            ProductotextBox.Clear();
            NCFtextBox.Clear();
            FechatextBox.Clear();
            ProductotextBox4.Clear();
            CantidadtextBox.Clear();
             
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
