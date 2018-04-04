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
using SisAgroVeterinaria.Entidades;

namespace SisAgroVeterinaria.Registros
{
    public partial class rTipoProducto : Form
    {
        public rTipoProducto()
        {
            InitializeComponent();
        }

        public void LimpiarTextBox()
        {
            NombretextBox.Clear();
            IdtextBox.Clear();
        }

        TipoProductos llenarClase()
        {

            TipoProductos tipos = new TipoProductos();
            tipos.Nombres = NombretextBox.Text;
            return tipos;


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text.Length == 0)
            {
                if (TipoProductoBLL.Guardar(llenarClase()))
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

                if (TipoProductoBLL.Editar(llenarClase()))
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
            TipoProductos tipos = TipoProductoBLL.Buscar(int.Parse(IdtextBox.Text));
            if (tipos != null)
            {
                NombretextBox.Text = tipos.Nombres;
            }
            else
            {
                MessageBox.Show(" Tipo de Producto no existe ");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (TipoProductoBLL.Eliminar(int.Parse(IdtextBox.Text)))
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
