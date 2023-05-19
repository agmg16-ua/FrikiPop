using library;
using System;
using System.Collections.Generic;
using System.Data;
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
            else {
                DataSet data = new DataSet();
                data = ENTarjeta.listarTarjetas(Session["nick"].ToString());
                GridView.DataSource = data;
                GridView.DataBind();
            }

        }

        protected void pagar_Click(object sender, EventArgs e) {

        }

        protected bool DataValidation(ENTarjeta tarjeta) {

            if(num.Text.Length != 16 || fechaMes.Text.Length != 2 || fechaAnyo.Text.Length != 4 || cvvTarj.Text.Length != 3) {
                Message.Text = "Los formatos no son correctos!";
                return false;
            }
            else {

                if(int.TryParse(num.Text, out int num_tarj) && num.Text.Length == 16) {
                    tarjeta.num = num_tarj;
                }
                else {
                    Message.Text = "Formato del nº de tarjeta INCORRECTO!";
                    return false;
                }

                if(int.TryParse(fechaMes.Text, out int mes_tarj) && (fechaMes.Text.Length == 2 || fechaMes.Text.Length == 1) && mes_tarj > 0 && mes_tarj <13) {
                    tarjeta.mesFecha = mes_tarj;
                }
                else {
                    Message.Text = "Formato del mes INCORRECTO!";
                    return false;
                }

                if(int.TryParse(fechaAnyo.Text, out int anyo_tarj) && fechaAnyo.Text.Length == 4 && anyo_tarj > 2023 && anyo_tarj < 2030) {
                    tarjeta.anyoFecha = anyo_tarj;
                }
                else {
                    Message.Text = "Formato del año INCORRECTO!";
                    return false;
                }

                if(int.TryParse(cvvTarj.Text, out int cvv) && cvvTarj.Text.Length == 3) {
                    tarjeta.cvv = cvv;
                }
                else {
                    Message.Text = "Formato del cvv INCORRECTO!";
                    return false;
                }
            }
            return true;
        }

        protected void anyadir_Click(object sender, EventArgs e) {

            ENTarjeta tarjeta = new ENTarjeta();

            if (DataValidation(tarjeta)) {
                tarjeta.createTarjeta();
            }
            Response.Redirect("~/PasarelaPago.aspx");
        }

        protected void borrar_Click(object sender, EventArgs e) {
            ENTarjeta tarjeta = new ENTarjeta();

            if (DataValidation(tarjeta)) {
                tarjeta.deleteTarjeta();
            }

            Response.Redirect("~/PasarelaPago.aspx");
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}