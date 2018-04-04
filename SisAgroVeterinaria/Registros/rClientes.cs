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
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

       Clientes llenarClase()
        {
            Clientes cliente = new Clientes();
            cliente.Nombres = NombretextBox.Text;
            cliente.Apellidos = ApellidostextBox.Text;
            cliente.Cedula = CedulatextBox.Text;
            cliente.Cedula = CedulatextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Telefono = TelefonotextBox.Text;
            int id = 0;
            int.TryParse(IdtextBox.Text, out id);
           
            return cliente;
        }


        //metodo limpiar textBox

        public void LimpiarTextBox()
        {
            NombretextBox.Clear();
            ApellidostextBox.Clear();
            CedulatextBox.Clear();
            CelulartextBox6.Clear();
            TelefonotextBox.Clear();
            //CiudadIdcomboBox.Clear();
            DirecciontextBox.Clear();
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (ClienteBLL.Buscar(1) == null)
            {
                if (ClienteBLL.Guardar(llenarClase()))
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

                if (ClienteBLL.Editar(llenarClase()))
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
    }
}
