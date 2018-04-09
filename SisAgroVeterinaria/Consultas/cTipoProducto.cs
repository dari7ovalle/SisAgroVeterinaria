using SisAgroVeterinaria.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAgroVeterinaria.Consultas
{
    public partial class cTipoProducto : Form
    {
        public cTipoProducto()
        {
            InitializeComponent();
        }
        void Buscar()
        {
            if (BuscarcomboBox.SelectedIndex == 0)
            {
                TipoProductodataGridView1.DataSource = TipoProductoBLL.ListarTodo();
            }
            else if (BuscarcomboBox.SelectedIndex == 1)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(BuscartextBox.Text, out id);

                TipoProductodataGridView1.DataSource = TipoProductoBLL.GetList(p => p.TipoProductoId == id);
            }
            else if (BuscarcomboBox.SelectedIndex == 2)
            {
                TipoProductodataGridView1.DataSource = TipoProductoBLL.GetTipoProductosNombre(BuscartextBox.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cTipoProducto_Load(object sender, EventArgs e)
        {
            BuscarcomboBox.SelectedIndex = 0;
            TipoProductodataGridView1.DataSource = TipoProductoBLL.ListarTodo();
        }
    }
}
