﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void LogIn(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nick = Nick.Text;
            if (en.readUsuario() == true && en.contrasenya == Contrasenya.Text)
            {
                Session.Add("imagen", en.imagen);
                Session.Add("nick", en.nick);
                if (en.esAdmin() == true)
                {
                    Response.Redirect("~/paginaPrincipal.aspx");
                }
                else
                {
                    Response.Redirect("~/paginaPrincipal.aspx");
                }
            }
            else
            {
                LabelError.Text = "No apareces en nuestra base de datos";
            }
        }
    }
}