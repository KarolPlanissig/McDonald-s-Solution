using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Conexion;
using Clases; 

namespace ProyectoSistemas
{
    public partial class Inicio : System.Web.UI.Page
    {
        public List<Hamburguesa> lista = new List<Hamburguesa>();
        public List<Papa> listaP = new List<Papa>();
        public List<Bebida> listaB = new List<Bebida>(); 
        public List<String> listaNombre = new List<String>();
        protected void Page_Load(object sender, EventArgs e)
        {
            BurgerNegocio traerdatos = new BurgerNegocio();

                lista = traerdatos.listar();

                listaP = traerdatos.listarPapas();

                listaB = traerdatos.listarBebidas();

                lblNombre.Text = "Orden vacia";

            if (!IsPostBack) //Configuración de las listas de SQL. 
            {
                repeatBebidas.DataSource = listaB;
                repeatBebidas.DataBind();
                repeatPapas.DataSource = listaP;
                repeatPapas.DataBind();
                repeatBurgas.DataSource = lista;
                repeatBurgas.DataBind(); 
            }

        }

        public void cargarNombres()
        {
            if (Session["PedidoSesion"] != null)
            {
                List<string> nombres = (List<string>)Session["PedidoSesion"];

               
                var nombresData = nombres.Select(nombre => new { Nombre = nombre }).ToList();
                
                dgvNombres.DataSource = nombresData;
                dgvNombres.DataBind();
                lblNombre.Text = "Pedido en curso";
            }
            else
            {
                dgvNombres.DataSource = null;
                dgvNombres.DataBind();
                lblNombre.Text = "Orden vacía";
            }
            
        }

        protected void btnAgregarBebida_Click1(object sender, EventArgs e)
        {
            string [] argumentos = ((Button)sender).CommandArgument.Split(',');

            string valor = argumentos[0];

            double price = Convert.ToDouble(argumentos[1]); 

            if (Session["PedidoSesion"] == null || Session["PrecioSesion"] == null)
            {
                List<string> pedido = new List<string>();
                List<double> precio = new List<double>(); 

                Session["PedidoSesion"] = pedido;
                Session["PrecioSesion"] = precio; 
            }

            ((List<string>)Session["PedidoSesion"]).Add(valor);

            ((List<double>)Session["PrecioSesion"]).Add(price);

            cargarNombres();
        }

        protected void btnAgregarPapa_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;

            if (Session["PedidoSesion"] == null)
            {
                List<string> pedido = new List<string>();

                Session["PedidoSesion"] = pedido;
            }

            ((List<string>)Session["PedidoSesion"]).Add(valor);

            cargarNombres();
        }


        protected void btnAgregarB_Click1(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;

            if (Session["PedidoSesion"] == null)
            {
                List<string> pedido = new List<string>();

                Session["PedidoSesion"] = pedido;
            }

            ((List<string>)Session["PedidoSesion"]).Add(valor);

            cargarNombres();
        }

        protected void btnGridView_Click(object sender, EventArgs e)
        { 

            Response.Redirect("ConfirmarPedido.aspx");
        }

        protected void btnGridViewCPedido_Click(object sender, EventArgs e)
        {
            Session["PedidoSesion"] = null;
            
            cargarNombres();
        }
    }
}