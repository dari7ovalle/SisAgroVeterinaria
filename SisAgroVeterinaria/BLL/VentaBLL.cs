﻿using SisAgroVeterinaria.DAL;
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
    public class VentaBLL
    {

        public static bool Guardar(Ventas venta)
            {
                bool estado = false;
                try
                {
                    SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                    context.ventas.Add(venta);
                    context.SaveChanges();
                    estado = true;

                }
                catch (Exception)
                {

                    throw;
                }
                return estado;

            }
        public static bool Editar(Ventas ventas)
        {
            bool estado = false;

            try
            {
                SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                context.Entry(ventas).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static Ventas Buscar(int Id)
            {
            Ventas venta = new Ventas();
                try
                {
                    SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                venta = context.ventas.Find(Id);
                }
                catch (Exception)
                {
                    throw;
                }

                return venta;

            }

            public static bool Eliminar(int ventaId)
            {
            Ventas venta = null;
                bool estado = false;
                try
                {
                    SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                venta = context.ventas.Find(venta);
                    context.ventas.Remove(venta);
                    context.SaveChanges();

                    estado = true;

                }
                catch (Exception)
                {
                    throw;

                }
                return estado;
            }

            public static List<Ventas> GetList(Expression<Func<Ventas, bool>> criterioBusqueda)
            {
                List<Ventas> venta = new List<Ventas>();
                try
                {
                    SisAgroveterinariaDb context = new SisAgroveterinariaDb();
                venta = context.ventas.Where(criterioBusqueda).ToList();
                }

                catch (Exception)
                {
                    throw;
                }

                return venta;
            }





        }



    }

