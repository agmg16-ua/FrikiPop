using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb {
    public partial class Paises : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e) {
            int index = GridView.SelectedIndex;
            string pais = ((Label)GridView.Rows[index].Cells[0].FindControl("Pais")).Text;
            Response.Redirect("~/Provincias.aspx" + HttpUtility.UrlEncode(pais));
        }

        protected void añadir_Click(object sender, EventArgs e) {

        }

        protected void borrar_Click(object sender, EventArgs e) {

        }

        protected void Volver_Click(object sender, EventArgs e) {

        }
    }
}