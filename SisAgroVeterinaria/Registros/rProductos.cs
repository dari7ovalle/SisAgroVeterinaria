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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
            cargarCombobox();
        }
        void cargarCombobox()
        {
            TipoProductocomboBox.DataSource = BLL.TipoProductoBLL.GetList();
            TipoProductocomboBox.ValueMember = "TipoProductoId";
            TipoProductocomboBox.DisplayMember = "Nombres";
        }
        Productos llenarClase()
        {

            Productos producto = new Productos();
            producto.Nombre = NombretextBox.Text;
            producto.Precio = int.Parse(PreciotextBox.Text);
            producto.Costo = int.Parse(CostotextBox.Text);
            producto.Activo = 0;
            producto.TipoProductoId = int.Parse(TipoProductocomboBox.SelectedValue.ToString());
            int id = 0;
            int.TryParse(IdtextBox.Text, out id);
            producto.ProductoId = id;
            

            

            return producto;
        }

        public void LimpiarTextBox()
        {
            NombretextBox.Clear();
            CostotextBox.Clear();
            PreciotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            int id = 0;
            int.TryParse(IdtextBox.Text, out id);
            if (id <= 0)
            {

                if (ProductosBLL.Guardar(llenarClase()))
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

                if (ProductosBLL.Editar(llenarClase()))
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

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            Productos producto = ProductosBLL.Buscar(int.Parse(IdtextBox.Text));
            if (producto != null)
            {
                NombretextBox.Text = producto.Nombre;
                TipoProductocomboBox.SelectedValue = producto.TipoProductoId;
                CostotextBox.Text = producto.Costo.ToString();
                PreciotextBox.Text= producto.Precio.ToString();
               
            }
            else
            {
                MessageBox.Show(" Cliente  no existe ");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ProductosBLL.Eliminar(int.Parse(IdtextBox.Text)))
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
   

