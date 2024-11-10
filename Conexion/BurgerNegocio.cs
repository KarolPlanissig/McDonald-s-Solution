using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Clases; 

namespace Conexion
{
    public class BurgerNegocio
    {
        public List<Hamburguesa> listar()
        {
            List<Hamburguesa> listado = new List<Hamburguesa>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("SELECT Nombre, Peso, Precio, Id, Imagen FROM Hamburguesas");
            datos.ejecutarLectura();

            try
            {
            
                while (datos.Lector.Read())
                {
                
                Hamburguesa burger = new Hamburguesa();

                burger.Nombre = (string)datos.Lector["Nombre"];
                burger.Precio = (double)datos.Lector["Precio"];
                burger.Peso = (double)datos.Lector["Peso"];
                burger.Id = (int)datos.Lector["Id"];
                burger.Imagen = (string)datos.Lector["Imagen"];

                listado.Add(burger); 

                }
                 
                return listado; 

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }

        }
        public List<Papa> listarPapas()
        {
            List<Papa> listado = new List<Papa>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("SELECT Tamaño, Precio, IdPapa, Imagen FROM Papas");
            datos.ejecutarLectura();

            try
            {
                while (datos.Lector.Read())
                {
                    Papa papita = new Papa();

                    papita.Tamaño = (string)datos.Lector["Tamaño"];
                    papita.Precio = (double)datos.Lector["Precio"];
                    papita.Id = (int)datos.Lector["IdPapa"];
                    papita.Imagen = (string)datos.Lector["Imagen"];

                    listado.Add(papita);
                }
                
                return listado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }

        }
        public List<Bebida> listarBebidas()
        {
            List<Bebida> listado = new List<Bebida>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("SELECT Nombre, Imagen, IdBebida, Precio FROM Bebidas");
            datos.ejecutarLectura();

            try
            {
                while (datos.Lector.Read())
                {
                    Bebida bebida = new Bebida();

                    bebida.Nombre = (string)datos.Lector["Nombre"];
                    bebida.Imagen = (string)datos.Lector["Imagen"];
                    bebida.Id = (int)datos.Lector["IdBebida"];
                    bebida.Precio = (double)datos.Lector["Precio"];

                    listado.Add(bebida);
                }
                return listado;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }

        }
        public bool validarLogin(Empleado empleado)
        {
          
            AccesoDatos datos = new AccesoDatos();
            
            try
            {

                datos.setearConsulta("Select DNI, Nombre, EstadoBreak from Empleado where DNI = @DNI ");
                datos.setearParametro("@DNI", empleado.DNI);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    empleado.estadoBreak = (int)datos.Lector["EstadoBreak"];
                    empleado.Nombre = (string)datos.Lector["Nombre"];


                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
            
          
        }

        public void setearCrew(Empleado empleado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update Empleado set EstadoBreak = 1 where DNI = @DNI");
                datos.setearParametro("@DNI", empleado.DNI);
                datos.ejecutarAccion(); 

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }
        } 
    }
}
