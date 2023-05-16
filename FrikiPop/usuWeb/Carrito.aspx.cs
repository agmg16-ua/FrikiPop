using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using library;

namespace usuWeb {
    public partial class Carrito : System.Web.UI.Page {

        private DataTable unirCarrito;

        private ENCarrito carroCompra;
        protected void Page_Load(object sender, EventArgs e) {
            carroCompra = new ENCarrito();

            carroCompra.usuario = Session["nick"].ToString();
            if(!carroCompra.readCarrito() || carroCompra.usuario == "invitado") {
                Response.Redirect("PaginaPrincipal.aspx");
            }
            else {
                LoadCarroCompra();
            }
        }

        protected void eliminarCarritoCompra(object sender, EventArgs e) {

            carroCompra.vaciarCarrito();
            LoadCarroCompra();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e) {

        }

        protected void LoadCarroCompra() {
            unirCarrito = carroCompra.unirCarrito();
        }

        protected void deleteArticulo(object sender, EventArgs e) {
            string id_Articulo;
            id_Articulo = ((LinkButton)sender).CommandArgument.ToString();
            int id;
            id = int.Parse(id_Articulo);

            carroCompra.deleteArticulo(id);

            LoadCarroCompra();
        }

        protected void tramitarPedido(object sender, EventArgs e) {

            carroCompra.makePedido();
            Response.Redirect("PaginaPrincipal.aspx");

        }
    }
}