using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace usuWeb {
    public partial class Paises : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["admin"] == null || (int)Session["admin"] != 1) {
                Response.Redirect("~/paginaPrincipal.aspx");
            }
            ENPais pais = new ENPais();
            GridView.DataSource = pais.listarPaises();
            GridView.DataBind();
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e) {
            GridViewRow row = GridView.SelectedRow;
            string paisName = row.Cells[1].Text;
            Response.Redirect("~/Provincias.aspx?pais=" + paisName);
        }

        protected void añadir_Click(object sender, EventArgs e) {
            ENPais pais = new ENPais();
            pais.pais = pais_text.Text;
            pais.createPais();
            Response.Redirect("~/Paises.aspx");
        }

        protected void borrar_Click(object sender, EventArgs e) {
            ENPais pais = new ENPais();
            pais.pais = pais_text.Text;
            pais.deletePais();
            Response.Redirect("~/Paises.aspx");
        }
    }
}