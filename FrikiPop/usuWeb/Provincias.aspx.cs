using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb {
    public partial class Provincias : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["admin"] == null || (int)Session["admin"] != 1) {
                Response.Redirect("~/paginaPrincipal.aspx");
            }
            string pais = Request.QueryString["pais"];
            if (pais == null) {
                ENProvincia provincia = new ENProvincia();
                GridView.DataSource = provincia.listarProvincias("");
                GridView.DataBind();
            } else {
                ENProvincia provincia = new ENProvincia();
                GridView.DataSource = provincia.listarProvincias(pais);
                GridView.DataBind();
            }
        }

        protected void añadir_Click(object sender, EventArgs e) {
            ENProvincia provincia = new ENProvincia();
            provincia.provincia = provincia_text.Text;
            provincia.pais = pais_text.Text;
            provincia.createProvincia();
            Response.Redirect("~/Provincias.aspx");
        }

        protected void borrar_Click(object sender, EventArgs e) {
            ENProvincia provincia = new ENProvincia();
            provincia.provincia = provincia_text.Text;
            provincia.pais = pais_text.Text;
            provincia.deleteProvincia();
            Response.Redirect("~/Provincias.aspx");
        }

        protected void Paises_Click(object sender, EventArgs e) {
            Response.Redirect("~/Paises.aspx");
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e) {
            GridViewRow row = GridView.SelectedRow;
            string paisName = row.Cells[2].Text;
            string provinciaName = row.Cells[1].Text;
            Response.Redirect("~/Localidades.aspx?provincia=" + provinciaName + "&pais=" + paisName);
        }
    }
}