using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAgroVeterinaria
{
    public partial class AgroVeterinariaForm : Form
    {
        public AgroVeterinariaForm()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rConfiguraciones confi = new Registros.rConfiguraciones();
            confi.Show();
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registros.Login log = new Registros.Login();
            log.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rProductos  producto = new Registros.rProductos();
            producto.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.cProductos prod = new Consultas.cProductos();
            prod.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.rTipoProducto tipop = new Registros.rTipoProducto();
            tipop.Show();
        }

        private void registrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.rCiudades ciudad = new Registros.rCiudades();
            ciudad.Show();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cCiudades ciudad = new Consultas.cCiudades();
            ciudad.Show();
        }

        private void registrosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Registros.rClientes cliente = new Registros.rClientes();
            cliente.Show();

        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.cTipoProducto tipop = new Consultas.cTipoProducto();
            tipop.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.rVenta venta = new Registros.rVenta();
            venta.Show();

        }

        private void consultasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.cVentas venta = new Consultas.cVentas();
            venta.Show();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.rInventario inventa = new Registros.rInventario();
            inventa.Show();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Consultas.cInventario inventa = new Consultas.cInventario();
            inventa.Show();
        }
    }
}
