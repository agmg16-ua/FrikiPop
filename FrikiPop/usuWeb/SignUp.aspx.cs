using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Net;
using System.Drawing;
using library;

namespace usuWeb
{
    public partial class Formulario_web2 : System.Web.UI.Page
    {
        protected void createUsuario(object sender,EventArgs e)
        {
            if (FileUpload1.FileName == "")
            {
               //FileUpload1.FileName = 
            }

            ENUsuario usur = new ENUsuario(Nick1.Text, Nombre1.Text, Apellidos1.Text, Contrasenya1.Text, Localidad1.Text, Provincia1.Text, Pais1.Text, FileUpload1.FileName, int.Parse(Edad1.Text),0);
            if (usur.readUsuario() == false)
            {
                if (usur.createUsuario() == false)
                {
                    LabelError.Text = "No se ha podido crear el usuario, comprueba bien los datos";
                }
                else
                {
                    Response.Redirect("~/paginaPrincipal.aspx");
                }
            }
            else
            {
                LabelError.Text = "El Nick Name ya existe, por favor elija otro";
            }
        }

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