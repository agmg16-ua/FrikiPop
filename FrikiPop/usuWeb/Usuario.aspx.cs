using System;
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
            if(en.readUsuario() == true && en.contrasenya == Contraseña.Text)
            {
                if(en.esAdmin() == true)
                {
                    //Se mete en la pagina de admins.
                }
                else
                {
                    //Se mete normalmente
                }
            }
            else
            {
                LabelError.Text = "No apareces en nuestra base de datos";
            }
        }
    }
}