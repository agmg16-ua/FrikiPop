using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using library;

namespace usuWeb {
    public partial class Localidades : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["admin"] == null || (int)Session["admin"] != 1) {
                Response.Redirect("~/paginaPrincipal.aspx");
            }
            string provincia = Request.QueryString["provincia"];
            string pais = Request.QueryString["pais"];
            if(pais == null || provincia == null) {
                ENLocalidad localidad = new ENLocalidad();
                GridView.DataSource = localidad.listarLocalidad("", "");
                GridView.DataBind();
            } else {
                ENLocalidad localidad = new ENLocalidad();
                GridView.DataSource = localidad.listarLocalidad(provincia, pais);
                GridView.DataBind();
            }
        }

        protected void añadir_Click(object sender, EventArgs e) {
            ENLocalidad localidad = new ENLocalidad();
            localidad.localidad = localidad_text.Text;
            localidad.provincia = provincia_text.Text;
            localidad.pais = pais_text.Text;
            localidad.createLocalidad();
            Response.Redirect("~/Localidades.aspx");
        }

        protected void borrar_Click(object sender, EventArgs e) {
            ENLocalidad localidad = new ENLocalidad();
            localidad.localidad = localidad_text.Text;
            localidad.provincia = provincia_text.Text;
            localidad.pais = pais_text.Text;
            localidad.deleteLocalidad();
            Response.Redirect("~/Localidades.aspx");
        }

        protected void Provincias_Click(object sender, EventArgs e) {
            Response.Redirect("~/Provincias.aspx");
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}