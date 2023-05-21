using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb
{
    public partial class verArticulo : System.Web.UI.Page
    {

        ENArticulo articulo;
        protected void Page_Load(object sender, EventArgs e)
        {
            articulo = new ENArticulo();

            articulo.codigo = Request.QueryString["codigo"];
                
            if(articulo.codigo == null) {
                Response.Redirect("~/paginaPrincipal.aspx");
            }

            articulo.readArticulo();

            precio.Text = articulo.precio.ToString();
            nombre.Text = articulo.nombre;
            descripcion.Text = articulo.descripcion;
            url_imagen.ImageUrl = articulo.urlImagen;
        }

        protected void añadirCestaClick(object sender, EventArgs e) {

        }

        protected void comprarAhoraClick(object sender, EventArgs e) {

        }
    }
}