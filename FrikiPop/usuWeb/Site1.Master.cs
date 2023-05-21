using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb {
    public partial class Site1 : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["nick"] != null)
            {
                nickName.Text = (string)Session["nick"];
                imagenUsuario.ImageUrl = "~/App_Images/Usuarios/" + Session["imagen"];


                string salir = "cerrar";
                MenuItem item = new MenuItem();
                item.Text = "Cerrar Sesion";
                item.NavigateUrl = "~/paginaPrincipal.aspx?sesion=" + salir;
                Menu.Items.Add(item);

                MenuItem item2 = new MenuItem();
                item2.Text = "Menu Usuario";
                item2.NavigateUrl = "~/MenuUsuario.aspx";
                Menu.Items.Add(item2);

                if(Menu.FindItem("Iniciar Sesión") != null) {
                    Menu.Items.Remove(Menu.FindItem("Iniciar Sesión"));
                }
                
                
                
            } 
            else 
            {
                imagenUsuario.ImageUrl = "~/App_Images/Usuarios/DefaultUser.png";
            }

            if(Session["admin"] != null)
            {
                if((int)Session["admin"] == 1)
                {
                    MenuItem item = new MenuItem();
                    item.Text = "Administrador";
                    item.NavigateUrl = "~/Admin.aspx";
                    Menu.Items.Add(item);
                }
            }
        }
    }
}