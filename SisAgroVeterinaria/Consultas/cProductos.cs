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
    public partial class cProductos : Form
    {
        public cProductos()
        {
            InitializeComponent();
        }
        void Buscar()
        {

            if (BuscarcomboBox.SelectedIndex == 0)
            {
                ProductodataGridView1.DataSource = ProductosBLL.ListarTodo();
            }
            else if (BuscarcomboBox.SelectedIndex == 1)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(BuscartextBox.Text, out id);

                ProductodataGridView1.DataSource = ProductosBLL.GetList(p => p.ProductoId == id);
            }
            else if (BuscarcomboBox.SelectedIndex == 2)
            {
                ProductodataGridView1.DataSource = ProductosBLL.GetProductoNombre(BuscartextBox.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();


        }

        private void ProductodataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Registros.rInventario.ProductoId=int.Parse(ProductodataGridView1.Rows[ProductodataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            Registros.rInventario.Nombre = ProductodataGridView1.Rows[ProductodataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            Registros.rVenta.productoId = int.Parse(ProductodataGridView1.Rows[ProductodataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

            this.Close();
        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cProductos_Load(object sender, EventArgs e)
        {
            BuscarcomboBox.SelectedIndex = 0;
            ProductodataGridView1.DataSource = ProductosBLL.ListarTodo();
        }
    }
}
