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
    public partial class cInventario : Form
    {
        public cInventario()
        {
            InitializeComponent();
        }
        void Buscar()
        {
            if (BuscarcomboBox.SelectedIndex == 0)
            {
                InventariodataGridView.DataSource = InventarioBLL.ListarTodo();
            }
            else if (BuscarcomboBox.SelectedIndex == 1)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(BuscartextBox.Text, out id);

                InventariodataGridView.DataSource = InventarioBLL.GetList(p => p.InventarioId == id);
            }
            else if (BuscarcomboBox.SelectedIndex == 2)
            {
                InventariodataGridView.DataSource = InventarioBLL.GetInventarioNombre(BuscartextBox.Text);
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

        private void cInventario_Load(object sender, EventArgs e)
        {
            BuscarcomboBox.SelectedIndex = 0;
            InventariodataGridView.DataSource = InventarioBLL.ListarTodo();
        }
    }
}
