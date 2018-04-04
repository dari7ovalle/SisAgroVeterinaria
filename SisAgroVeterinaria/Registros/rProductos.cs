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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        public void LimpiarTextBox()
        {
            NombretextBox.Clear();
            CostotextBox.Clear();
            PreciotextBox.Clear();
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
