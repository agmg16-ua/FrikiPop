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
        protected void createUsuario(object sender, EventArgs e)
        {
            ENUsuario usur;

            if (FileUpload1.FileName == "")
            {
                usur = new ENUsuario(Nick1.Text, Nombre1.Text, Apellidos1.Text, Contrasenya1.Text, Localidades.SelectedValue, Provincias.SelectedValue, Paises.SelectedValue, "DefaultUser.png", int.Parse(Edad1.Text), 0); 
            }
            else
            {
                usur = new ENUsuario(Nick1.Text, Nombre1.Text, Apellidos1.Text, Contrasenya1.Text, Localidades.SelectedValue, Provincias.SelectedValue, Paises.SelectedValue, FileUpload1.FileName, int.Parse(Edad1.Text), 0);
            }

            
            if (usur.readUsuario() == false)
            {
                if (usur.createUsuario() == false)
                {
                    LabelError.Text = "No se ha podido crear el usuario, comprueba bien los datos";
                }
                else
                {
                    if (Request.QueryString["desde"] == "admin")
                    {
                        Response.Redirect("~/VerUsuarios.aspx");
                    }
                    else
                    {
                        Response.Redirect("~/paginaPrincipal.aspx");
                    }
                }
            }
            else
            {
                LabelError.Text = "El Nick Name ya existe, por favor elija otro";
            }
        }

        protected void Provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ENProvincia provincia = new ENProvincia();
            provincia.provincia = Provincias.SelectedValue;
            provincia.pais = Paises.SelectedValue;

            if (provincia.readProvincia() == false)
            {
                LabelErrorProvincia.Text = "La provincia seleccionada es incorrecta";
            }
            else
            {
                LabelErrorProvincia.Text = "";
            }
        }

        protected void Localidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ENLocalidad localidad = new ENLocalidad();
            localidad.localidad = Localidades.SelectedValue;
            localidad.provincia = Provincias.SelectedValue;
            localidad.pais = Paises.SelectedValue;

            if (localidad.readLocalidad() == false)
            {
                LabelErrorLocalidad.Text = "La localidad seleccionada es incorrecta";
            }
            else
            {
                LabelErrorLocalidad.Text = "";
            }
        }
    }
}