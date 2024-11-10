using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ProyectoSistemas
{
    public partial class BreakExitoso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Empleado empleado1 = (Empleado)Session["Empleado"];

            if (Session["Empleado"] != null)
            {
                lblMensaje.Text = empleado1.Nombre + ", ¡tu break fue autorizado!";
                Session["PedidoSesion"] = null; 
                
            }
            else
            {
                Response.Redirect("BreakRechazado.aspx", false); 
            }
        }
       

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx", false); 
        }
    }
}