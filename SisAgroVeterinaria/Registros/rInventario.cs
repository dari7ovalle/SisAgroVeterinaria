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
    public partial class rInventario : Form
    {
        Inventario inventario ;
        Productos producto =new  Productos();
        public static string Nombre;
        public static int ProductoId;

        public rInventario()
        {
            InitializeComponent();
            FechatextBox.Text = DateTime.Today.ToString("d");
        }



        Inventario llenarClase()
        {
            
            Inventario inventario = new Inventario();
            inventario.ProductoId = ProductoId;

            inventario.Nombre = ProductotextBox.Text;
            inventario.Cantidad = int.Parse(CantidadtextBox.Text);
            inventario.Fecha = FechatextBox.Text;
            int id = 0;
            int.TryParse(IdtextBox.Text, out id);
            inventario.InventarioId = id;
            //inventario.InventarioId = int.Parse(IdtextBox.Text);

            return inventario;
        }

        public void LimpiarTextBox()
        {
            ProductotextBox.Clear();
            CantidadtextBox.Clear();
            FechatextBox.Text = DateTime.Today.ToString("d");
            ProductotextBox.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

           
            //int id = 0;
            //int.TryParse(IdtextBox.Text, out id);
            //if (id <= 0)
            //{

                if (InventarioBLL.Guardar(llenarClase()))
                {
                    MessageBox.Show("Guardado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            //}

            //else
            //{

            //    if (InventarioBLL.Editar(llenarClase()))
            //    {
            //        MessageBox.Show("Modificado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Consultas.cProductos producto = new Consultas.cProductos();
            producto.ShowDialog();
            seleccionar();
        }

        void seleccionar()
        {
            try
            {
                inventario = InventarioBLL.Buscar(ProductoId);


                if (inventario !=null){

                    ProductotextBox.Text = Nombre;
                    IdtextBox.Text = ProductoId.ToString();
                    FechatextBox.Text = inventario.Fecha;
                    CantidadtextBox.Text = inventario.Cantidad.ToString();

                }
                else
                {
                    BuscarProducto();
                }

            }
            catch (Exception)
            {

                throw;
            }

            
        }
        void BuscarProducto()
        {
            if (ProductosBLL.Buscar(ProductoId) != null)
            {
                ProductotextBox.Text = Nombre;

            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (InventarioBLL.Eliminar(int.Parse(IdtextBox.Text)))
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
