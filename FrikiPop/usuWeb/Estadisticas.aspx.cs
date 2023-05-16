using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Configuration;
using System.Web.UI.WebControls;
using library;

namespace usuWeb
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int pos;
            pos = int.Parse(Session["admin"].ToString());
            if (pos == 1)
            {
                string s = ConfigurationManager.ConnectionStrings["Database"].ToString();
                DataSet bdvirtual = new DataSet();
                SqlConnection c = new SqlConnection(s);
                SqlDataAdapter da = new SqlDataAdapter("SELECT [nick_name], [nombre], [apellidos],[numVentas] FROM [Usuario] ORDER BY [numVentas] desc", c);

                da.Fill(bdvirtual, 0, 10, "Usuario");

                Grafica1.DataSource = bdvirtual;
                Grafica1.DataBind();

                topUsuarios.DataSource = bdvirtual;
                topUsuarios.DataBind();

                string s2 = ConfigurationManager.ConnectionStrings["Database"].ToString();
                DataSet bdvirtual2 = new DataSet();
                SqlConnection c2 = new SqlConnection(s2);
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT [tipo][numVentas] FROM [TipoArticulo] order by [numVentas] DESC ", c2);

                da2.Fill(bdvirtual2, 0, 10, "TipoArticulo");

                Grafica2.DataSource = bdvirtual;
                Grafica2.DataBind();

                topTipoArticulos.DataSource = bdvirtual2;
                topTipoArticulos.DataBind();

            }
            else
                Response.Redirect("paginaPrincipal.aspx");
        }
    }
}