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

namespace SisAgroVeterinaria.Registros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            NombretextBox.Text = "dary";
            ContraseñatextBox.Text = "1234";
        }

        public void LimpiarTextBox()
        {
            NombretextBox.Clear();
            ContraseñatextBox.Clear();
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.Login(NombretextBox.Text,ContraseñatextBox.Text))
            {
                AgroVeterinariaForm agro = new AgroVeterinariaForm();
                agro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
