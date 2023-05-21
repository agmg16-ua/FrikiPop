﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb {
    public partial class Formulario_web1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(Request.QueryString["sesion"] == "cerrar")
            {
                Session.Remove("nick");
                Session.Remove("imagen");
                Session.Remove("admin");
                Response.Redirect("~/paginaPrincipal.aspx");
            }
        }
    }
}