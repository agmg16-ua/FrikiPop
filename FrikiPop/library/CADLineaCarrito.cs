using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADLineaCarrito{
        private string constring;

        public CADLineaCarrito() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool readLineaCarrito(ENLineaCarrito lincarrito) {

			bool leido;
			SqlConnection conex;
			conex = new SqlConnection(constring);
			leido = false;

			try {
				SqlCommand comandoSQL;
				string consultaSQL;

				conex.Open();

				consultaSQL = "Select * from LinCarrito where usuario = '" + lincarrito.usuario + "'";

				comandoSQL = new SqlCommand(consultaSQL, conex);

				SqlDataReader readerSQL;
				readerSQL = comandoSQL.ExecuteReader();

				readerSQL.Read();
				bool condicion;
				condicion = (readerSQL["usuario"].ToString() == lincarrito.usuario);
				if (condicion) {
					
					lincarrito.id_carrito = int.Parse(readerSQL["id_carrito"].ToString());
					lincarrito.linea = int.Parse(readerSQL["linea"].ToString());
					lincarrito.importe = float.Parse(readerSQL["importe"].ToString());
					lincarrito.articulo = readerSQL["articulo"].ToString();


					leido = true;
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

        public bool createLineaCarrito(ENLineaCarrito lincarrito) {
			bool creado;
			creado = false;
			SqlConnection conex;
			conex = null;
            try {
				conex = new SqlConnection(constring);
				conex.Open();
				string consultaSQL;

				consultaSQL = "Insert into LinCarrito (linea, id_carrito, importe, usuario, articulo) VALUES ("+lincarrito.linea+", "+lincarrito.id_carrito+", "+lincarrito.importe+", "+lincarrito.usuario+ ", "+ lincarrito.articulo+ ", '" + "')";
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

        public bool deleteLineaCarrito(ENLineaCarrito lincarrito) {

			bool borrado;
			borrado = false;
			SqlConnection conex;
			conex = null;

            try {
				conex = new SqlConnection(constring);
				conex.Open();
				string consultaSQL;

				consultaSQL = "Delete from LinCarrito  where linea='"+lincarrito.linea+"')";
				SqlCommand comandoSQL;
				comandoSQL = new SqlCommand(consultaSQL, conex);

				comandoSQL.ExecuteNonQuery();
				borrado = true;
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

			return borrado;
        }

        public DataSet enlistarLineaCarrito(ENLineaCarrito lincarrito) {

			DataSet dataset;
			dataset= new DataSet();
			SqlConnection conex;
			conex = null;

			try {
				string consultaSQL;
				consultaSQL = "Select * from LinCarrito l where l.id_carrito = '"+lincarrito.id_carrito + "'";

				conex = new SqlConnection(constring);

				SqlDataAdapter dataAdapter;
				dataAdapter = new SqlDataAdapter(consultaSQL, conex);
				dataAdapter.Fill(dataset,"LinCarrito");

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

			return dataset;

		}

		public int obtenerMaxLineaCarrito(int num_carrito) {
			int linea = 0;
			SqlConnection conex = null;

			try {
				conex = new SqlConnection(constring);
				conex.Open();
				string consultaSQL;

				consultaSQL = "Select * from LinCarrito where id_carrito=" + num_carrito;
				SqlCommand comandoSQL;
				comandoSQL = new SqlCommand(consultaSQL, conex);

				SqlDataReader readerSQL;
				readerSQL = comandoSQL.ExecuteReader();

				while(readerSQL.Read()) {
					if(linea < int.Parse(readerSQL["linea"].ToString())) {
						linea = int.Parse(readerSQL["linea"].ToString());
                    }
                }

				readerSQL.Close();

			} catch (SqlException exception) {
				Console.WriteLine("User operation has failed. Error: {0}", exception.Message);
			} catch (Exception exception) {
				Console.WriteLine("User operation has failed. Error: {0}", exception.Message);
			} finally {

				if (conex.State == ConnectionState.Open) {
					conex.Close();
				}
			}

			return linea;
		}

    }
}
