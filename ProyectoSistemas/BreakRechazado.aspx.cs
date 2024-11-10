using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ProyectoSistemas
{
    public partial class BreakRechazado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Empleado"] != null)
            {
                string nombre = ((Empleado)Session["Empleado"]).Nombre; 
                lblRechazado.Text = "El empleado " + nombre + " ya comió!";
            }
            else
            {
                Response.Redirect("Inicio.aspx", false); 
            }
        }

        protected void btnIntentar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfirmarPedido.aspx", false);
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx", false); 
        }

        protected void btnAutorizar_Click(object sender, EventArgs e)
        {
            ((Empleado)Session["Empleado"]).estadoBreak = 0;

            Response.Redirect("Autorizar2Break.aspx", false); 
            //CONFIGURAR MÉTODO PARA QUE NO VAYA A LA BASE DE DATOS Y AUTORICE EL BREAK 

        }
    }
}