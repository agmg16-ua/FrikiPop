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
            /*if(!IsPostBack) {
                string pais = Session["PaisSeleccionado"].ToString();
                ENProvincia provincia = new ENProvincia();
                GridView.DataSource = provincia.listarProvincias(pais);
                GridView.DataBind();
            } else {
                Response.Redirect("~/Paises.aspx");
            }*/
            
            //string pais = Request.QueryString["pais"];
            ENProvincia provincia = new ENProvincia();
            GridView.DataSource = provincia.listarProvincias("");
            GridView.DataBind();
        }

        protected void verLocalidadesButton_Click(object sender, EventArgs e) {
            /*Button button = (Button)sender;
            GridViewRow row = (GridViewRow)button.NamingContainer;
            string provincia = row.Cells[0].Text;
            string pais = row.Cells[1].Text;

            // redirect to the provincias.aspx page with the province name as a query string parameter
            Response.Redirect("localidades.aspx?provincia=" + provincia + "?pais=" + pais);*/
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

        }
    }
}