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
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            if (BuscarcomboBox.SelectedIndex == 0)
            {
                ClientedataGridView.DataSource = ClienteBLL.ListarTodo();
            }
            else if (BuscarcomboBox.SelectedIndex == 1)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(BuscartextBox.Text, out id);

                ClientedataGridView.DataSource = ClienteBLL.GetList(p => p.ClienteId == id);
            }
            else if (BuscarcomboBox.SelectedIndex == 2)
            {
                ClientedataGridView.DataSource = ClienteBLL.GetClientesNombre(BuscartextBox.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ClientedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Registros.rVenta.clienteId = int.Parse(ClientedataGridView.Rows[ClientedataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            Registros.rVenta.Nombre = ClientedataGridView.Rows[ClientedataGridView.CurrentRow.Index].Cells[1].Value.ToString();
            this.Close();
        }

        private void cClientes_Load(object sender, EventArgs e)
        {
            BuscarcomboBox.SelectedIndex = 0;
            ClientedataGridView.DataSource = ClienteBLL.ListarTodo();
        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}