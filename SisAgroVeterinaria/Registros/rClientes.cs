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
            cargarCombobox();
        }
        void cargarCombobox()
        {
            CiudadIdcomboBox.DataSource = BLL.CiudadesBLL.GetList();
            CiudadIdcomboBox.ValueMember = "CiudadId";
            CiudadIdcomboBox.DisplayMember = "Nombres";
        }

       Clientes llenarClase()
        {
            Clientes cliente = new Clientes();
            cliente.Nombres = NombretextBox.Text;
            cliente.Apellidos = ApellidostextBox.Text;
            cliente.Cedula = CedulatextBox.Text;
            cliente.Celular = CelulartextBox6.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Telefono = TelefonotextBox.Text;
            int id = 0;
            int.TryParse(IdtextBox.Text, out id);
            cliente.ClienteId = id;
            cliente.CiudadId = int.Parse(CiudadIdcomboBox.SelectedValue.ToString());

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
            CiudadIdcomboBox.SelectedIndex = 0;
            DirecciontextBox.Clear();
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(IdtextBox.Text, out id);
            if (id <=0){
             
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

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Clientes clientes  = ClienteBLL.Buscar(int.Parse(IdtextBox.Text));
            if (clientes != null)
            {
                NombretextBox.Text = clientes.Nombres;
                ApellidostextBox.Text = clientes.Apellidos;
                CedulatextBox.Text = clientes.Cedula;
                TelefonotextBox.Text = clientes.Telefono;
                CelulartextBox6.Text = clientes.Celular;
                DirecciontextBox.Text = clientes.Direccion;
                CiudadIdcomboBox.SelectedValue = clientes.CiudadId;
            }
            else
            {
                MessageBox.Show(" Cliente  no existe ");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ClienteBLL.Eliminar(int.Parse(IdtextBox.Text)))
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
