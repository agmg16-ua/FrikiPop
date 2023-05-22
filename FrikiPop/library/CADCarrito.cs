using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace library
{
	public class CADCarrito{
		private string constring;
		public CADCarrito(){
			constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
		}
		public bool readCarrito(ENCarrito carrito){
			bool leido;
			SqlConnection conex;
			conex = new SqlConnection(constring);
			leido = false;

			try {
				SqlCommand comandoSQL;
				string consultaSQL;

				conex.Open();

				consultaSQL= "Select * from Carrito where usuario = '" + carrito.usuario + "'";
				
				comandoSQL = new SqlCommand(consultaSQL, conex);

				SqlDataReader readerSQL;
				readerSQL = comandoSQL.ExecuteReader();

				readerSQL.Read();
				if(readerSQL.HasRows) {
					Console.WriteLine("ENTRA");
                } else {
					Console.WriteLine("No entra");
                }

				bool condicion;
				condicion = (readerSQL[1].ToString() == carrito.usuario);
                if (condicion==true) {
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
				consultaSQL = "Insert into Carrito (num_carrito, usuario, estado_carrito) values ("+carrito.numeroCarrito+", '"+carrito.usuario+"', '"+carrito.estadoCarrito+"')";

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

			DataTable datatable = new DataTable();	
			SqlConnection conex;
			conex = null;

            try {
				string consultaSQL;
				consultaSQL = "Select * from LinCarrito l, Articulo a where l.articulo = a.codigo  and l.id_carrito = '"+carrito.numeroCarrito+ "'";

				conex = new SqlConnection(constring);

				SqlDataAdapter dataAdapter;
				dataAdapter = new SqlDataAdapter(consultaSQL, conex);
				dataAdapter.Fill(datatable);

			}

			catch (SqlException exception) {
				Console.WriteLine("The operation has failed.Error: {0}", exception.Message);
			}

			catch (Exception exception) {
				Console.WriteLine("The operation has failed.Error: {0}", exception.Message);
			}

			finally {

				if (conex.State == ConnectionState.Open) {
					conex.Close();
				}
			}

			return datatable;
			
		}

		public bool deleteArticulo(ENCarrito carrito, int linea){
			bool borradoArticulo;
			borradoArticulo = false;
			SqlConnection conex;
			conex = null;

			try {
				string consultaSQL;
				consultaSQL = "Delete from LinCarrito where id_carrito = " + carrito.numeroCarrito + " and linea = " + linea;
				SqlCommand comandoSQL;

				conex = new SqlConnection(constring);

				conex.Open();

				comandoSQL = new SqlCommand(consultaSQL, conex);
				comandoSQL.ExecuteNonQuery();

				borradoArticulo = true;
            }

			catch (SqlException exception) {
				Console.WriteLine("The operation has failed.Error: {0}", exception.Message);
			}

			catch (Exception exception) {
				Console.WriteLine("The operation has failed.Error: {0}", exception.Message);
			}

			finally {

				if (conex.State == ConnectionState.Open) {
					conex.Close();
				}
			}

			return borradoArticulo;
		}
		public bool makePedido(ENCarrito carrito){
			bool realizado;
			realizado = false;
			SqlConnection conex;
			conex = null;
			try {
				DataSet dataset;
				SqlDataAdapter dataAdapter;
				string consultaSQL;

				consultaSQL = "Select * from linCarrito l where l.id_carrito= '" + carrito.numeroCarrito + "'";
				dataset = new DataSet();

				conex = new SqlConnection(constring);

				dataAdapter = new SqlDataAdapter(consultaSQL, conex);

				dataAdapter.Fill(dataset,"LinCarrito");
				ENUsuario usu;
				usu = new ENUsuario();
				usu.nick = carrito.usuario;
				usu.readUsuario();
				ENPedido ped;
				ped = new ENPedido();

				ped.idPedido = 1;
				ped.user = carrito.usuario;
				ped.date= DateTime.Now.ToString("d", DateTimeFormatInfo.InvariantInfo);
				// me falta el del estado carrito y el total, para cuando lo haga aurelio lo añado aqui tmb

				ped.createPedido();

				int iter;
				iter = 1;
				string lincarrito = "LinCarrito";
				string importe = "importe";
				string articulo = "articulo";
				foreach(DataRow dataRow in dataset.Tables[lincarrito].Rows) {
					ENLinPedido linped;
					float importeF;
					importeF = float.Parse(dataRow[importe].ToString());
					string articuloI = dataRow[articulo].ToString();

					linped = new ENLinPedido(iter, ped.idPedido,articuloI,importeF);

					linped.createLinPedido();

					++iter;

                }
				vaciarCarrito(carrito);
				realizado = true;
			}

			catch (SqlException exception) {
				Console.WriteLine("The operation has failed.Error: {0}", exception.Message);
			}

			catch (Exception exception) {
				Console.WriteLine("The operation has failed.Error: {0}", exception.Message);
			}

			finally {

				if (conex.State == ConnectionState.Open) {
					conex.Close();
				}
			}

			return realizado;
		}
		public bool vaciarCarrito(ENCarrito carrito){
			bool borrado;
			borrado = false;
			SqlConnection conex;
			conex = null;

            try {
				string consultaSQL;
				consultaSQL = "Delete from LinCarrito where id_carrito = "+carrito.numeroCarrito;
				SqlCommand comandoSQL;

				conex = new SqlConnection(constring);

				conex.Open();

				comandoSQL = new SqlCommand(consultaSQL, conex);

				comandoSQL.ExecuteNonQuery();

				borrado = true;
			}

			catch (SqlException exception) {
				Console.WriteLine("The operation has failed.Error: {0}", exception.Message);
			}

			catch (Exception exception) {
				Console.WriteLine("The operation has failed.Error: {0}", exception.Message);
			}

			finally {

				if (conex.State == ConnectionState.Open) {
					conex.Close();
				}
			}

			return borrado;
		}

	}
}
