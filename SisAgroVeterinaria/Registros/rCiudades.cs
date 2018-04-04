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
    public partial class rCiudades : Form
    {
        public rCiudades()
        {
            InitializeComponent();
        }

       void  LimpiarTextBox()
        {
            NombrestextBox.Clear();
        }


        Ciudades llenarClase()
        {

            Ciudades ciudades = new Ciudades();
            ciudades.Nombres = NombrestextBox.Text;
            ciudades.CiudadId = int.Parse(IdtextBox.Text);
            return ciudades;
          
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (IdtextBox.Text.Length == 0)
            {
                if (CiudadesBLL.Guardar(llenarClase()))
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
                

                if (CiudadesBLL.Editar(llenarClase()))
                {
                    MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Ciudades ciudades = CiudadesBLL.Buscar(int.Parse(IdtextBox.Text));
            if (ciudades != null)
            {
               NombrestextBox.Text = ciudades.Nombres;
            }
            else
            {
                MessageBox.Show(" ciudad no existe ");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (CiudadesBLL.Eliminar(int.Parse(IdtextBox.Text)))
            {
                MessageBox.Show(" fue eliminado");

            }

            else
            {
                MessageBox.Show(" no se pudo eliminar");
            }

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();

        }
    }
    }

