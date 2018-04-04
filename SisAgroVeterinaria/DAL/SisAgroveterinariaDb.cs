using SisAgroVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAgroVeterinaria.DAL
{
  public   class SisAgroveterinariaDb : DbContext
    {

        
        public DbSet<Ciudades> ciudades { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Configuraciones> configuraciones { get; set; }
        public DbSet<Inventario> inventario { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<TipoProductos> tipoProductos { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<VentaDetalles> ventaDetalles { get; set; }
        public DbSet<Ventas> ventas { get; set; }


      public SisAgroveterinariaDb() : base("ConStr")
        {

        }
    }
}
