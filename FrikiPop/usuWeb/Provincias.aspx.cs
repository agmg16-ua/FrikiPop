using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb {
    public partial class Provincias : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string pais = Request.QueryString["pais"];
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e) {
            int index = GridView.SelectedIndex;
            string provincia = ((Label)GridView.Rows[index].Cells[0].FindControl("Provincia")).Text;
            Response.Redirect("~/Localidades.aspx" + HttpUtility.UrlEncode(provincia));
        }

        protected void añadir_Click(object sender, EventArgs e) {

        }

        protected void borrar_Click(object sender, EventArgs e) {

        }

        protected void Volver_Click(object sender, EventArgs e) {
            Response.Redirect("~/Paises.aspx");
        }
    }
}