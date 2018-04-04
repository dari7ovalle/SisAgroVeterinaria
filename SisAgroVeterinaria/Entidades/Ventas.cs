﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAgroVeterinaria.Entidades
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public string Fecha { get; set; }
        public int ConfiguracionId { get; set; }
        public int TipoVenta { get; set; }
        public double TotalVenta { get; set; }
        public int UsuarioId { get; set; }


        public Ventas()
        {
            this.VentaId = 0;
            this.ClienteId = 0;
            this.Fecha = string.Empty;
            this.ConfiguracionId = 0;
            this.TipoVenta = 0;
            this.TotalVenta = 0;
            this.UsuarioId = 0;
        }



        public Ventas(int VentaId, int ClienteId, string Fecha, int ConfiguracionId, int TipoVenta, double TotalVenta, int UsuarioId)
        {
            this.VentaId = VentaId;
            this.ClienteId = ClienteId;
            this.Fecha = string.Empty;
            this.ConfiguracionId = ConfiguracionId;
            this.TipoVenta = TipoVenta;
            this.TotalVenta = TotalVenta;
            this.UsuarioId = UsuarioId;

        }
    }
}
