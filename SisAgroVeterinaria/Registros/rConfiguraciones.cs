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
    public partial class rConfiguraciones : Form
    {
        Configuraciones confi;
        public rConfiguraciones()
        {
            InitializeComponent();
            CargarConfiguracion();
            confi = new Configuraciones();
        }



        public void LimpiarTextBox()
        {
            NCFtextBox.Clear();
        }

        private void CargarConfiguracion()
        {
            Configuraciones conf = ConfiguracionesBLL.Buscar(1);
            if (conf != null)
            {
                NCFtextBox.Text = conf.NCF;
            }
        }

        Configuraciones llenarClase()
        {

          
            confi.ConfiguracionId = 1;
            confi.NCF = NCFtextBox.Text;
            
            return confi;
            


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {  

            if (ConfiguracionesBLL.Buscar(1) ==null)
            {
                if (ConfiguracionesBLL.Guardar(llenarClase()))
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

                if (ConfiguracionesBLL.Editar(llenarClase()))
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
