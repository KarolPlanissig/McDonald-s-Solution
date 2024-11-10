using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conexion; 

namespace ProyectoSistemas
{
    public partial class ConfirmarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PedidoSesion"] == null)
            {
                Response.Redirect("PedidoNull.aspx", false); 
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleado e1 = new Empleado(); 
            BurgerNegocio negocio = new BurgerNegocio();
            string usuario = "karol"; 
            int password = 123;
            Session.Add("Usuario", usuario);
            Session.Add("Contraseña", password);

            try
            {
                if(txtUsuario.Text == usuario && txtClave.Text == password.ToString())
                {
                   int dniEmpleado = int.Parse(txtCrew.Text);
                   e1.DNI = dniEmpleado;

                    if(negocio.validarLogin(e1))
                    {
                        Session.Add("Empleado", e1); //Guardamos el objeto en session para poder usarlo
                                                     // en diferentes pantallas.
                    }

                    if (Session["Empleado"] != null)
                    {
                        Empleado empleado = (Empleado)Session["Empleado"];
                        
                        if(empleado.estadoBreak == 0)
                        {
                            negocio.setearCrew(empleado);
                            Response.Redirect("BreakExitoso.aspx", false);


                        }
                        else
                        {
                            Response.Redirect("BreakRechazado.aspx", false); 
                        }

                    }

                }
                else
                {
                    Response.Redirect("BreakRechazado.aspx", false);
                }

            }
            catch (Exception ex)
            {

                Session.Add("Error", ex.ToString());
            }
        }
    }
}