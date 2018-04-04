using SisAgroVeterinaria.DAL;
using SisAgroVeterinaria.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SisAgroVeterinaria.BLL
{
    public class CiudadesBLL
    {

        public static bool Guardar(Ciudades ciudade)
        {
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.ciudades.Add(ciudade);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;

        }

        public static Ciudades Buscar(int Id)
        {
            Ciudades ciudad = new Ciudades();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                ciudad = context.ciudades.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }

            return ciudad;

        }

        public static bool Eliminar(int CiudadId)
        {
            Ciudades ciudad = null;
            bool estado = false;
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                ciudad = context.ciudades.Find(CiudadId);
                context.ciudades.Remove(ciudad);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static bool Editar(Ciudades ciudades)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(ciudades).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static List<Ciudades> GetList(Expression<Func<Ciudades, bool>> criterioBusqueda)
        {
            List<Ciudades> ciudades = new List<Ciudades>();
            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                ciudades = context.ciudades.Where(criterioBusqueda).ToList();
            }

            catch (Exception)
            {
                throw;
            }

            return ciudades;
        }





    }
}


