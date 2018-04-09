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
    public partial class rVenta : Form
    {
        Clientes cliente;
        Productos producto;
        Ventas venta;
        Configuraciones configuraciones;
        public static int clienteId;
        public static int productoId;
        public static string Nombre;
        int Cantidades;
        public rVenta()
        {
            InitializeComponent();
            CargarConfiguracion();
        }

        
        public void LimpiarTextBox()
        {
            VentatextBox.Clear();
            ClientetextBox.Clear();
            ProductotextBox.Clear();
            NCFtextBox.Clear();
            FechatextBox.Clear();
            ProductotextBox4.Clear();
            CantidadtextBox.Clear();
            dataGridView.DataSource = null;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(VentatextBox.Text, out id);
            if (id <= 0)
            {

                if (VentaBLL.Guardar(LLenaClase()))
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

                if (VentaBLL.Editar(LLenaClase()))
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

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {
            Consultas.cClientes cliente = new Consultas.cClientes();
            cliente.ShowDialog();
            seleccionar();
        }
        void seleccionar()
        {
            try
            {
                cliente = ClienteBLL.Buscar(clienteId);


                if (cliente != null)
                {

                    ClientetextBox.Text = clienteId.ToString();
                   

                }
                

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            Consultas.cProductos producto = new Consultas.cProductos();
            producto.ShowDialog();
            seleccionarProducto();
           


        }
        void seleccionarProducto()
        {
            try
            {
                producto = ProductosBLL.Buscar(productoId);


                if (producto != null)
                {

                    ProductotextBox.Text = productoId.ToString();
                    Buscarproducto();

                }


            }
            catch (Exception)
            {

                throw;
            }

        


        }
        void Buscarproducto()
        {
            producto = ProductosBLL.Buscar(productoId);
            ProductotextBox4.Text = producto.Nombre ;
        }
        void CargarConfiguracion()
        {
            configuraciones = ConfiguracionesBLL.Buscar(1);
            NCFtextBox.Text = configuraciones.NCF;
            FechatextBox.Text = DateTime.Today.ToString("d");



        }

        public void CalcularMonto()
        {
            TotaltextBox.Text = "";
            double monto = 0;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {

                monto += (double)dataGridView.Rows[i].Cells[4].Value;
            }
            TotaltextBox.Text = monto.ToString();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Cantidades = int.Parse(CantidadtextBox.Text);
            dataGridView.Rows.Add(productoId, producto.Nombre, producto.Precio, Cantidades, Cantidades * producto.Precio);
            CalcularMonto();
            //dataGridView.Rows.Add(1, "Nombre", 200, Cantidades, Cantidades * 200);
        }

        private void BuscarVentabutton_Click(object sender, EventArgs e)
        {

        }

       Ventas LLenaClase()
        {
            venta = new Ventas();                
            venta.ClienteId = clienteId;
            venta.ConfiguracionId = 1;
            venta.Fecha = FechatextBox.Text;
            if (ContadoradioButton.Checked)
            {
                venta.TipoVenta = 0;
            }
            else
            {
                venta.TipoVenta = 1;
            }
            venta.UsuarioId = 1;
            venta.TotalVenta = double.Parse(TotaltextBox.Text);
            
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                venta.AgregarProductos(int.Parse(dataGridView.Rows[i].Cells[0].Value.ToString()), int.Parse(dataGridView.Rows[i].Cells[3].Value.ToString()), int.Parse(dataGridView.Rows[i].Cells[2].Value.ToString()), double.Parse(dataGridView.Rows[i].Cells[4].Value.ToString()));
            }
            return venta;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (VentaBLL.Eliminar(int.Parse(VentatextBox.Text)))
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
