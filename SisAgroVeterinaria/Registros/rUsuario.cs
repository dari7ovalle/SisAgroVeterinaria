using SisAgroVeterinaria.BLL;
using SisAgroVeterinaria.Entidades;
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
    public partial class rUsuario : Form
    {
        public rUsuario()
        {
            InitializeComponent();
        }

        public void LimpiarTextBox()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            contraseñatextBox.Clear();
        }

        Usuarios llenarClase()
        {

            Usuarios usuario = new Usuarios();
            usuario.Nombres = NombretextBox.Text;
            usuario.Contracena = contraseñatextBox.Text;
            usuario.TipoUsuario = 0;
            return usuario;


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Length == 0)
            {
                if (UsuariosBLL.Guardar(llenarClase()))
                {
                    MessageBox.Show("Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (UsuariosBLL.Editar(llenarClase()))
                {
                    MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = UsuariosBLL.Buscar(int.Parse(IdtextBox.Text));
            if (usuarios != null)
            {
                NombretextBox.Text = usuarios.Nombres;
                contraseñatextBox.Text = usuarios.Contracena;
            }
            else
            {
                MessageBox.Show(" El Usuario no existe ");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.Eliminar(int.Parse(IdtextBox.Text)))
            {
                MessageBox.Show(" fue eliminado");

            }

            else
            {
                MessageBox.Show(" no se pudo eliminar");
            }
        }
    }
}
