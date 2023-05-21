using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Common;



namespace library
{
    public class CADArticulo
    {
        private String constring;

        public CADArticulo()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createArticulo(ENArticulo articulo)
        {
            bool creado = false;
            SqlConnection conexion = null;

            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Insert into Articulo (codigo,nombre,descripcion,precio,url_imagen,usuario,tipo) values ('" + articulo.codigo + "', '" + articulo.nombre + "' , '" + articulo.descripcion + articulo.urlImagen + "', '" + articulo.usuario + "' , '" + articulo.tipoArticulo + "')";
                SqlCommand command = new SqlCommand(consulta, conexion);

                command.ExecuteNonQuery();
                creado = true;

            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return creado;
        }

        public bool deleteArticulo(ENArticulo articulo)
        {
            bool eliminado = false;
            SqlConnection conexion = null;

            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Delete from Articulo where codigo = '" + articulo.codigo + "' and nombre = '" + articulo.nombre + "' and descripcion = '" + articulo.descripcion + "' and url_imagen = '" + articulo.urlImagen + "' and usuario = '" + articulo.usuario + "' and tipo = '" + articulo.tipoArticulo + "'";
                SqlCommand command = new SqlCommand(consulta, conexion);

                command.ExecuteNonQuery();
                eliminado = true;

            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return eliminado;
        }

        public bool readArticulo(ENArticulo articulo)
        {
            bool leido = false;
            SqlConnection conexion = null;

            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Select * from Articulo where codigo = '" + articulo.codigo + "' and nombre = '" + articulo.nombre + "' and descripcion = '" + articulo.descripcion + "' and precio = '" + articulo.precio + "' and url_imagen = '" + articulo.urlImagen + "' and usuario = '" + articulo.usuario + "' and tipo = '" + articulo.tipoArticulo + "'";

                SqlCommand command = new SqlCommand(consulta, conexion);

                SqlDataReader busqueda = command.ExecuteReader();
                busqueda.Read();

                if (busqueda.HasRows)
                {
                    if (busqueda["codigo"].ToString() == articulo.codigo &&
                            busqueda["nombre"].ToString() == articulo.nombre &&
                            busqueda["descripcion"].ToString() == articulo.descripcion &&
                            Convert.ToDouble(busqueda["precio"]) == articulo.precio &&
                            busqueda["url_imagen"].ToString() == articulo.urlImagen &&
                            busqueda["usuario"].ToString() == articulo.usuario &&
                            busqueda["tipo"].ToString() == articulo.tipoArticulo)
                    {
                        articulo.codigo = busqueda["codigo"].ToString();
                        articulo.nombre = busqueda["nombre"].ToString();
                        articulo.descripcion = busqueda["descripcion"].ToString();
                        articulo.precio = Convert.ToDouble(busqueda["precio"]);
                        articulo.urlImagen = busqueda["url_imagen"].ToString();
                        articulo.usuario = busqueda["usuario"].ToString();
                        articulo.tipoArticulo = busqueda["tipo"].ToString();
                        leido = true;
                    }
                }

                busqueda.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return leido;
        }

        public bool updateArticulo(ENArticulo articulo)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE [dbo].[Articulo] set codigo = '" + articulo.codigo + "' , nombre = '" + articulo.nombre + "' , descripcion = '" + articulo.descripcion + "' , precio = '" + articulo.precio + "' , url_imagen = '" + articulo.urlImagen + "' , usuario = '" + articulo.usuario + "' , tipo = '" + articulo.tipoArticulo + "'", connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable usuarioArticulo(string usuarioArticulo)
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = null;

            try
            {
                conexion = new SqlConnection(constring);
                string consulta = null;
                if (usuarioArticulo == "")
                {
                    consulta = "Select * from Articulo";
                }
                else
                {
                    consulta = "Select * from Articulo where usuario = '" + usuarioArticulo + "'";
                }
                SqlDataAdapter data = new SqlDataAdapter(consulta, conexion);
                data.Fill(tabla);

            }
            catch (SqlException e)
            {
                Console.WriteLine("The operation has failed.Error: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("The operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return tabla;
        }
    }
}
