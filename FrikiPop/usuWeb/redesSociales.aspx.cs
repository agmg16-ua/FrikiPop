using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb
{
    public partial class redesSociales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ENredesSociales redesSociales = new ENredesSociales();
            GridView.DataSource = redesSociales.listarRedesSociales();
            GridView.DataBind();
        }

        protected void Volver_Click(object sender, EventArgs e)
        {

        }

        protected void añadir_Click(object sender, EventArgs e)
        {
            ENredesSociales redesSociales = new ENredesSociales();
            redesSociales.red = red.Text;
            redesSociales.urlLogo = url_logo.Text;
            redesSociales.linkRed = link_red.Text;
            redesSociales.createRedesSociales();
            Response.Redirect("~/redesSociales.aspx");
        }

        protected void borrar_Click(object sender, EventArgs e)
        {
            ENredesSociales redesSociales = new ENredesSociales();
            redesSociales.red = red.Text;
            redesSociales.urlLogo = url_logo.Text;
            redesSociales.linkRed = link_red.Text;
            redesSociales.deleteRedesSociales();
            Response.Redirect("~/redesSociales.aspx");
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}