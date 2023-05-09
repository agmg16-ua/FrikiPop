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
        }

        protected void eliminarCarritoCompra(object sender, EventArgs e) {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e) {

        }

        protected void deleteArticulo(object sender, EventArgs e) {

        }

        protected void tramitarPedido(object sender, EventArgs e) {

        }
    }
}