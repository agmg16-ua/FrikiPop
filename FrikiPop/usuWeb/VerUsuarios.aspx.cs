using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            string nick = row.Cells[0].Text;
            string nombre = row.Cells[1].Text;
            string apellidos = row.Cells[2].Text;
            string edad = row.Cells[3].Text;
            string contrasenya = row.Cells[4].Text;
            string imagen = row.Cells[5].Text;
            string admin = row.Cells[6].Text;
            string localidad = row.Cells[7].Text;
            string provincia = row.Cells[8].Text;
            string pais = row.Cells[9].Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            GridView1.DataSource = usuario.listarUsuarios();
            GridView1.DataBind();
        }
    }
}