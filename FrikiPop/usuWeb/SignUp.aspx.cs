﻿using System;
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
               // FileUpload1.FileName = 
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
                    //Un redirect a la pagina donde esten las cosas
                }
            }
            else
            {
                LabelError.Text = "El nick_name ya existe, por favor elija otro";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}