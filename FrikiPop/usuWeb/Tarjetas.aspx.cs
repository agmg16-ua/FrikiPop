using library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb {
    public partial class Tarjeta : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
            DataSet data = new DataSet();
            data = ENTarjeta.listarTarjetas();
            GridView.DataSource = data;
            GridView.DataBind();
        }

        protected void anyadir_Click(object sender, EventArgs e) {
            ENTarjeta tarjeta = new ENTarjeta();
            tarjeta.num = int.Parse(num.Text);
            tarjeta.usuario = usuario.Text;
            tarjeta.mesFecha = int.Parse(fechaMes.Text);
            tarjeta.anyoFecha = int.Parse(fechaAnyo.Text);
            tarjeta.cvv = int.Parse(cvvTarj.Text);
            tarjeta.createTarjeta();
            Response.Redirect("~/Tarjetas.aspx");

        }
        protected void borrar_Click(object sender, EventArgs e) {
            ENTarjeta tarjeta = new ENTarjeta();
            tarjeta.num = int.Parse(num.Text);
            tarjeta.usuario = usuario.Text;
            tarjeta.mesFecha = int.Parse(fechaMes.Text);
            tarjeta.anyoFecha = int.Parse(fechaAnyo.Text);
            tarjeta.cvv = int.Parse(cvvTarj.Text);
            tarjeta.deleteTarjeta();
            Response.Redirect("~/Tarjetas.aspx");
        }

        protected void actualizar_Click(object sender, EventArgs e) {
            ENTarjeta tarjeta = new ENTarjeta();
            tarjeta.num = int.Parse(num.Text);
            tarjeta.usuario = usuario.Text;
            tarjeta.mesFecha = int.Parse(fechaMes.Text);
            tarjeta.anyoFecha = int.Parse(fechaAnyo.Text);
            tarjeta.cvv = int.Parse(cvvTarj.Text);
            tarjeta.updateTarjeta();
            Response.Redirect("~/Tarjetas.aspx");
        }
    }
}