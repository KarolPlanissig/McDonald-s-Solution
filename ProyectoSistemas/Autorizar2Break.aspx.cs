using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoSistemas
{
    public partial class Autorizar2Break : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btnConfirmarAutorizacion_Click(object sender, EventArgs e)
        {
            string nombre = (string)Session["Usuario"];
            int password = (int)Session["Contraseña"]; 

            if(txtUsuario.Text == nombre && txtClave.Text == password.ToString())
            {
                Response.Redirect("BreakExitoso.aspx", false); 
            }
        }
    }
}