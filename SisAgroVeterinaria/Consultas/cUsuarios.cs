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
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }
        void Buscar()
        {
            if (buscarcomboBox.SelectedIndex == 0)
            {
                UsuariodataGridView1.DataSource = UsuariosBLL.ListarTodo();
            }
            else if (buscarcomboBox.SelectedIndex == 1)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(BuscartextBox.Text, out id);

                UsuariodataGridView1.DataSource = UsuariosBLL.GetList(p => p.UsuarioId == id);
            }
            else if (buscarcomboBox.SelectedIndex == 2)
            {
                UsuariodataGridView1.DataSource = UsuariosBLL.GetUsuariosNombre(BuscartextBox.Text);
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

        private void cUsuarios_Load(object sender, EventArgs e)
        {
            buscarcomboBox.SelectedIndex = 0;
            UsuariodataGridView1.DataSource = UsuariosBLL.ListarTodo();
        }
    }
}
