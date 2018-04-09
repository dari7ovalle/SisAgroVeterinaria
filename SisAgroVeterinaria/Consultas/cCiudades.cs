using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisAgroVeterinaria.BLL;

namespace SisAgroVeterinaria.Consultas
{
    public partial class cCiudades : Form
    {
        public cCiudades()
        {
            InitializeComponent();
        }
        void Buscar()
        {
            if (BuscarcomboBox.SelectedIndex == 0)
            {
                CiudaddataGridView.DataSource = CiudadesBLL.ListarTodo();
            }
            else  if (BuscarcomboBox.SelectedIndex == 1)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(BuscartextBox.Text, out id);

                CiudaddataGridView.DataSource = CiudadesBLL.GetList(p => p.CiudadId == id);
            }
            else if (BuscarcomboBox.SelectedIndex == 2)
            {
                CiudaddataGridView.DataSource = CiudadesBLL.GetCiudadNombre(BuscartextBox.Text);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cCiudades_Load(object sender, EventArgs e)
        {
            BuscarcomboBox.SelectedIndex = 0;
            CiudaddataGridView.DataSource = CiudadesBLL.ListarTodo();
        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
