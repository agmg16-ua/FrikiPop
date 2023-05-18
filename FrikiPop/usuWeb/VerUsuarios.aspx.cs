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