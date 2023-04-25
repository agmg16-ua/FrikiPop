using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Configuration;
using library;

namespace library
{
    class CADLinPedido
    {
        private string constring;
        public CADLinPedido()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        public bool createLinPedido(ENLinPedido en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [dbo].[LINPED] (numPedido, linea, articulo, importe) " +
                    "VALUES ('" + en._pedido + "', '" + en._linea + "', '" + en._articulo + "', '" + en._importe , connection);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool readLinPedido(ENLinPedido en)
        {
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[LINPED] " +
                    "WHERE numPedido = '" + en._pedido + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (int.Parse(reader["numPedido"].ToString()) == en._pedido)
                {
                    en._pedido = (int)reader["numPedido"];
                    en._linea = (int)reader["linea"];
                    en._articulo = (int)reader["articulo"];
                    en._importe = (float)reader["importe"];
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;

            }
            finally
            {
                connection.Close();
            }
        }
        public bool updateLinPedido(ENLinPedido en)
        {
            SqlConnection conexion = new SqlConnection(constring);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("Update [dbo].[Articulo] set numPedido= '" + en._pedido + "' ,linea=" + en._linea
                    + " ,articulo='" + en._articulo + "' ,importe='" + en._importe  , conexion);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                conexion.Close();
            }

            return true;
        }
        public bool deleteLinPedido(ENLinPedido en)
        {
            SqlConnection conexion = new SqlConnection(constring);
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("Delete * from [dbo].[Articulo] where numPedido= " + en._pedido, conexion);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                conexion.Close();
            }

            return true;
        }
    }
}
