using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb {
    public partial class PasarelaPago : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(Session["nick"].ToString() == "invitado") {
                Response.Redirect("~/SingUp.aspx");
            }

        }

        protected void pagar_Click(object sender, EventArgs e) {

        }
    }
}