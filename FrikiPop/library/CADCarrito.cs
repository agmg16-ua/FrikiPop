using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace library
{
	public class CADCarrito{
		private string constring;
		public CADCarrito(){
			constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
		}
		public bool readCarrito(ENCarrito carrito){
			bool leido;
			leido = false;
			SqlConnection conex;
			conex = new SqlConnection(constring);

            try {
				conex.Open();
				SqlCommand comandoSQL;
				string consultaSQL;
				consultaSQL= "Select * from Carrito where usuario = '" + carrito.usuario + "'";
				comandoSQL = new SqlCommand(consultaSQL, conex);
				SqlDataReader readerSQL;
				readerSQL = comandoSQL.ExecuteReader();
				readerSQL.Read();

                if (readerSQL["usuario"].ToString() == "Vacio") {
                    if (readerSQL["estado_carrito"].ToString() == "Comprando") {
						carrito.estadoCarrito = "Comprando";
                    }
                    else {
						carrito.estadoCarrito = "Vacio";
                    }
					leido = true;
					carrito.numeroCarrito = int.Parse(readerSQL["num_carrito"].ToString());
				}

				readerSQL.Close();
			}

			catch (SqlException exception) {
				Console.WriteLine("User operation has failed. Error: {0}", exception.Message);
			}

			catch (Exception exception) {
				Console.WriteLine("User operation has failed. Error: {0}", exception.Message);
			}

			finally {

				if (conex.State == ConnectionState.Open) {
					conex.Close();
				}
			}

			return leido;

		}
		public bool createCarrito(ENCarrito carrito){
			bool creado;
			creado = false;
			SqlConnection conex;
			conex = new SqlConnection(constring);

            try {
				string consultaSQL;

				conex.Open();
				consultaSQL = "Insert into Carrito (num_carrito, usuario, estado_carrito) values ("+carrito.numeroCarrito+", "+carrito.usuario+", '"+carrito.estadoCarrito+"')";

				SqlCommand comandoSQL;
				comandoSQL = new SqlCommand(consultaSQL, conex);

				comandoSQL.ExecuteNonQuery();

				creado = true;
			}

			catch (SqlException exception) {
				Console.WriteLine("User operation has failed. Error: {0}", exception.Message);
			}

			catch (Exception exception) {
				Console.WriteLine("User operation has failed. Error: {0}", exception.Message);
			}

			finally {

				if (conex.State == ConnectionState.Open) {
					conex.Close();
				}
			}

			return creado;
		}

		public bool updateCarrito(ENCarrito carrito) {
			return true; //?????
        }
		public DataTable unirCarrito(ENCarrito carrito){
			string consultaSQL;
			consultaSQL = "Select * from LinCarrito l, Articulo a where l.articulo = a.codigo  and l.id_carrito = '"+carrito.numeroCarrito+"'";
			SqlConnection conex;
			DataSet dataset;
			dataset = new DataSet();
			conex = new SqlConnection(constring);
			SqlDataAdapter dataAdapter;
			dataAdapter = new SqlDataAdapter(consultaSQL, conex);
			dataAdapter.Fill(dataset);
			return new DataTable();
		}

		public bool borrarArticulo(ENCarrito carrito, int linea){
			return false;
		}
		public bool makePedido(ENCarrito carrito)
		{
			return false;
		}
		public bool vaciarCarrito(ENCarrito carrito){
			return false;
		}

	}
}
