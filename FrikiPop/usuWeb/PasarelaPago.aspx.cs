using library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb {
    public partial class PasarelaPago : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if ((string)Session["nick"] == "invitado") {
                Response.Redirect("~/SingUp.aspx");
            }
            else {
                DataSet data = new DataSet();
                data = ENTarjeta.listarTarjetas((string)Session["nick"]);
                GridView.DataSource = data;
                GridView.DataBind();
            }
        }

        protected bool DataValidation(ENTarjeta tarjeta) {

            if (int.TryParse(num.Text, out int num_tarj) && num.Text.Length == 16) {
                tarjeta.num = num.Text;
            }
            else {
                Message.Text = "Formato del nº de tarjeta INCORRECTO!";
                return false;
            }

            if (int.TryParse(fechaMes.Text, out int mes_tarj) && (fechaMes.Text.Length == 2 || fechaMes.Text.Length == 1) && mes_tarj > 0 && mes_tarj < 13) {
                tarjeta.mesFecha = mes_tarj;
            }
            else {
                Message.Text = "Formato del mes INCORRECTO!";
                return false;
            }

            if (int.TryParse(fechaAnyo.Text, out int anyo_tarj) && fechaAnyo.Text.Length == 4 && anyo_tarj > 2023 && anyo_tarj < 2030) {
                tarjeta.anyoFecha = anyo_tarj;
            }
            else {
                Message.Text = "Formato del año INCORRECTO!";
                return false;
            }

            if (int.TryParse(cvvTarj.Text, out int cvv) && cvvTarj.Text.Length == 3) {
                tarjeta.cvv = cvvTarj.Text;
            }
            else {
                Message.Text = "Formato del cvv INCORRECTO!";
                return false;
            }

            tarjeta.usuario = Session["nick"].ToString();
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

            string id_articulo = Request.QueryString["codigo"];
            string id_carrito = Request.QueryString["carrito"];

            ENPedido pedido = new ENPedido();

            string connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            SqlConnection conex = new SqlConnection(connection);
            conex.Open();

            string query = "SELECT MAX(num_pedido) AS max_numPedido FROM Pedido";
            SqlCommand command = new SqlCommand(query, conex);
            int maxNumPedido = Convert.ToInt32(command.ExecuteScalar());
            pedido.idPedido = maxNumPedido + 1;
            pedido.user = (string)Session["nick"];
            DateTime now = DateTime.Now;
            pedido.date = now.ToString();
            pedido.state = "listo";

            if (id_articulo != null) {

                SqlCommand sql = new SqlCommand("SELECT precio from Articulo where codigo='" + id_articulo + "'", conex);
                float precio = float.Parse(sql.ExecuteScalar().ToString());
                conex.Close();

                pedido.total = precio;
            }
            
            if(id_carrito != null) {
                ENCarrito carroCompra = new ENCarrito();
                carroCompra.numeroCarrito = int.Parse(id_carrito);
                DataTable unirCarrito;

                unirCarrito = carroCompra.unirCarrito();
                string importeS = "importe";
                double importeTotal;
                double importe;
                importeTotal = 0;

                foreach (DataRow lineaCarri in unirCarrito.Rows) {
                    importe = double.Parse(lineaCarri[importeS].ToString());
                    importeTotal = importeTotal + importe;
                }

                pedido.total = ((float)(importeTotal + 5.49));

                carroCompra.vaciarCarrito();
            }
            ENLinPedido linped = new ENLinPedido(1, pedido.idPedido, id_articulo, pedido.total);
            pedido.createPedido();
            Response.Redirect("~/paginaPrincipal.aspx");
        }
    }
}