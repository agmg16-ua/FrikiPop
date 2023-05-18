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
                imagenUsuario.ImageUrl = "~/App_Images/" + Session["imagen"];
            }
        }
    }
}