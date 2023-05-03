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
            ENPais pais = new ENPais();
            DataTable data = new DataTable();
            ENPais paisaux = new ENPais();
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ToString());
            SqlDataAdapter sqldata = new SqlDataAdapter("Select * from Pais", conexion);
            sqldata.Fill(data);
            //GridView.DataSource = pais.listarPaises();
            GridView.DataSource = data;
            GridView.DataBind();
        }

        

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e) {
            GridViewRow row = GridView.SelectedRow;
            string paisName = row.Cells[1].Text;
            Response.Redirect("~/Provincias.aspx?pais=" + paisName);
        }

        protected void añadir_Click(object sender, EventArgs e) {

        }

        protected void borrar_Click(object sender, EventArgs e) {

        }

        protected void Volver_Click(object sender, EventArgs e) {

        }

    }
}