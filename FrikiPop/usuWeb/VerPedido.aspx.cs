using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb {
    public partial class VerPedido : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["nick"] == null) { //Hablaré con el encargado para añadir invitado, está en proceso
                Response.Redirect("Usuario.aspx");
            }

            DataSet auxiliar = new DataSet();
            auxiliar = ENPedido.listPedidos(Session["nick"].ToString());
            GridView2.DataSource = auxiliar;
            GridView2.DataBind(); 
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e) {
            GridViewRow row = GridView2.SelectedRow;
            string pedidos = row.Cells[1].Text;
            Response.Redirect("~/Pedido.aspx?pedido=" + pedidos);
        }

        protected void volverClick(object sender, EventArgs e) {
            Response.Redirect("paginaPrincipal.aspx");
        }

    }
}