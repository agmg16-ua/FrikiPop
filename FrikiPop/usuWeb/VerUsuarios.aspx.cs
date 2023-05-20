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
        protected void CrearUsuario(object sender, EventArgs e)
        {
            Response.Redirect("~/SignUp.aspx?desde=admin");
        }

        protected void EliminarUsuario(object sender, EventArgs e)
        {
            ENUsuario usur = new ENUsuario();
            usur.nick = eliminar.Text;
            if(usur.deleteUsuario() == true)
            {
                LabelError.Text = "Se ha eliminado correctamente el usuario: " + eliminar.Text;
            }
            else
            {
                LabelError.Text = "No se ha podido eliminar el usuario: " + eliminar.Text;
            }

        }

        protected void Filtrar_Valores(object sender, EventArgs e)
        {
            if (filtros.SelectedItem == nick)
            {
                ENUsuario usuario = new ENUsuario();
                GridView1.DataSource = usuario.filtrarPorNick(valorParaFiltrar.Text);
                GridView1.DataBind();

                if (faltaLista.Text != "")
                {
                    faltaLista.Text = "";
                }

                if (faltaValorParaFiltrar.Text != "")
                {
                    faltaValorParaFiltrar.Text = "";
                }

            }
            else if (filtros.SelectedItem == nombre)
            {
                ENUsuario usuario = new ENUsuario();
                GridView1.DataSource = usuario.filtrarPorNombre(valorParaFiltrar.Text);
                GridView1.DataBind();

                if (faltaLista.Text != "")
                {
                    faltaLista.Text = "";
                }

                if (faltaValorParaFiltrar.Text != "")
                {
                    faltaValorParaFiltrar.Text = "";
                }

            }
            else if (filtros.SelectedItem == apellidos)
            {
                ENUsuario usuario = new ENUsuario();
                GridView1.DataSource = usuario.filtrarPorApellidos(valorParaFiltrar.Text);
                GridView1.DataBind();

                if (faltaLista.Text != "")
                {
                    faltaLista.Text = "";
                }

                if (faltaValorParaFiltrar.Text != "")
                {
                    faltaValorParaFiltrar.Text = "";
                }

            }
            else if (filtros.SelectedItem == edad)
            {
                ENUsuario usuario = new ENUsuario();
                GridView1.DataSource = usuario.filtrarPorEdad(int.Parse(valorParaFiltrar.Text));
                GridView1.DataBind();

                if (faltaLista.Text != "")
                {
                    faltaLista.Text = "";
                }

                if (faltaValorParaFiltrar.Text != "")
                {
                    faltaValorParaFiltrar.Text = "";
                }

            }
            else if (filtros.SelectedItem == localidad)
            {
                ENUsuario usuario = new ENUsuario();
                GridView1.DataSource = usuario.filtrarPorLocalidad(valorParaFiltrar.Text);
                GridView1.DataBind();

                if (faltaLista.Text != "")
                {
                    faltaLista.Text = "";
                }

                if (faltaValorParaFiltrar.Text != "")
                {
                    faltaValorParaFiltrar.Text = "";
                }

            }
            else if (filtros.SelectedItem == provincia)
            {
                ENUsuario usuario = new ENUsuario();
                GridView1.DataSource = usuario.filtrarPorProvincia(valorParaFiltrar.Text);
                GridView1.DataBind();

                if (faltaLista.Text != "")
                {
                    faltaLista.Text = "";
                }

                if (faltaValorParaFiltrar.Text != "")
                {
                    faltaValorParaFiltrar.Text = "";
                }

            }
            else if (filtros.SelectedItem == pais)
            {
                ENUsuario usuario = new ENUsuario();
                GridView1.DataSource = usuario.filtrarPorPais(valorParaFiltrar.Text);
                GridView1.DataBind();

                if (faltaLista.Text != "")
                {
                    faltaLista.Text = "";
                }

                if (faltaValorParaFiltrar.Text != "")
                {
                    faltaValorParaFiltrar.Text = "";
                }

            }
            else if (filtros.SelectedItem == administrador)
            {
                ENUsuario usuario = new ENUsuario();
                GridView1.DataSource = usuario.filtrarPorAdministrador(int.Parse(valorParaFiltrar.Text));
                GridView1.DataBind();
                
                if(faltaLista.Text != "")
                {
                    faltaLista.Text = "";
                }

                if(faltaValorParaFiltrar.Text != "")
                {
                    faltaValorParaFiltrar.Text = "";
                }

            }
            else if(filtros.SelectedItem == valorInicial)
            {
                faltaLista.Text = "Tiene que seleccionar antes un valor de la lista";
            }
            else if(valorParaFiltrar.Text == "")
            {
                faltaValorParaFiltrar.Text = "Tiene que escribir una valor que quiera filtrar";
            }
        }
    }
}