﻿//librerias
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
    public class CADLinPedido
    {
        //variable privada que almacena la cadena de conexión a la base de datos
        private string constring;
        //se encarga de inicializar la variable constring con el valor de la cadena de conexión a la base de datos.
        public CADLinPedido()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        //se encarga de insetar un nuevo registro en la tabla
        public bool createLinPedido(ENLinPedido en)
        {
            //Crea una nueva instancia utilizando la cadena de conexión almacenada en 'constring'
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                //abre la conexion
                connection.Open();
                //realiza la consulta
                SqlCommand command = new SqlCommand("INSERT INTO [dbo].[LINPED] (numPedido, linea, articulo, importe) " +
                    "VALUES ('" + en._pedido + "', '" + en._linea + "', '" + en._articulo + "', '" + en._importe , connection);
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                //si salta excepcion se printea un mensaje por pantalla
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;
            }
            //El bloque finally se ejecuta siempre, y se encarga de cerrar la conexión si
            //está abierta utilizando 'connection.Close()'.
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
               
            }
        }
        //Este metodo se encarga de leer un registro en función del número de pedido
        public bool readLinPedido(ENLinPedido en)
        {
            //Crea una nueva instancia utilizando la cadena de conexión almacenada en 'constring'
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                //abro la conexion
                connection.Open();
                //realiza una consulta de seleccion
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[LINPED] " +
                    "WHERE numPedido = '" + en._pedido + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                //llama al metodo 'Read()' en el objeto 'reader'
                //para avanzar al primer registro devuelto por la consulta.
                reader.Read();
                //compara si el número de pedido del registro es igual al número de pedido del objeto 
                if (int.Parse(reader["numPedido"].ToString()) == en._pedido)
                {
                    en._pedido = (int)reader["numPedido"];
                    en._linea = (int)reader["linea"];
                    en._articulo = (int)reader["articulo"];
                    en._importe = (float)reader["importe"];
                    //cierro el lector de datos
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
                //si salta excepcion se printea un mensaje por pantalla
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                return false;

            }
            //El bloque finally se ejecuta siempre, y se encarga de cerrar la conexión si
            //está abierta utilizando 'connection.Close()'.
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        //Este metodo se ncarga de actualizar un registro
        public bool updateLinPedido(ENLinPedido en)
        {
            //Crea una nueva instancia utilizando la cadena de conexión almacenada en 'constring'
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                //abro la conexion
                connection.Open();
                //realizo una consulta que se encarga de actualizar un registro 
                SqlCommand comando = new SqlCommand("Update [dbo].[Articulo] set numPedido= '" + en._pedido + "' ,linea=" + en._linea
                    + " ,articulo='" + en._articulo + "' ,importe='" + en._importe  , connection);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //si salta excepcion se printea un mensaje por pantalla
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            //El bloque finally se ejecuta siempre, y se encarga de cerrar la conexión si
            //está abierta utilizando 'connection.Close()'.
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return true;
        }
        //Este metodo se encarga de eliminar un registro
        public bool deleteLinPedido(ENLinPedido en)
        {
            //Crea una nueva instancia utilizando la cadena de conexión almacenada en 'constring'
            SqlConnection connection = new SqlConnection(constring);
            try
            {
                //abro la conexion
                connection.Open();
                //realizo una consulta que se encarga de eliminar un registro
                SqlCommand comando = new SqlCommand("Delete * from [dbo].[Articulo] where numPedido= " + en._pedido, connection);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //si salta excepcion se printea un mensaje por pantalla
                Console.WriteLine("User operation has failed.Error: {0}", ex.Message);
                return false;
            }
            //El bloque finally se ejecuta siempre, y se encarga de cerrar la conexión si
            //está abierta utilizando 'connection.Close()'.
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return true;
        }
    }
}
