﻿using SisAgroVeterinaria.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAgroVeterinaria.Consultas
{
    public partial class cInventario : Form
    {
        public cInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BuscarcomboBox.SelectedIndex == 0)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(BuscartextBox.Text, out id);

                InventariodataGridView.DataSource = InventarioBLL.GetList(p => p.InventarioId == id);
            }
            else if (BuscarcomboBox.SelectedIndex == 1)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(BuscartextBox.Text, out id);

                InventariodataGridView.DataSource = InventarioBLL.GetList(p => p.InventarioId == id);
            }
        }
    }
}
