﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace library
{
    public class CADUsuario
    {
        private string constring;
        
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        
        public bool createUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try

            String comando = "Insert into [dbo].[Usuarios] (nick,nombre,apellidos,edad,contrasenya,imagen,localidad)" +
                "                            VALUES('" + en.nick + "','" + en.nombre + "','" + en.apellidos + "'," + en.edad +
                                                    ",'" + en.contrasenya + "','" + en.imagen + "','" + en.localidad + ")";
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                if (cmd.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                return true;
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine("User operation has failed.Error: " + sqlex.Message);
                return false;
            }
            catch (Exception ex)
            {

                Console.WriteLine("User operation has failed.Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
        }

        //Devuelve solo el usuario indicado leído de la BD.
        public bool readUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try
            String comando = "Select * from [dbo].[Usuarios] where nick = '" + en.nick + "'";
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    en.nick = dr["nick"].ToString();
                    en.nombre = dr["nombre"].ToString();
                    en.apellidos = dr["apellidos"].ToString();
                    en.edad = int.Parse(dr["edad"].ToString());
                    en.contrasenya = dr["contrasenya"].ToString();
                    en.imagen = dr["imagen"].ToString();
                    en.localidad = dr["localidad"].ToString();
                    dr.Close();
                    return true;
                }
                dr.Close();
                return false;
            }
            catch (SqlException sqlex)
            {

                Console.WriteLine("User operation has failed.Error: " + sqlex.Message);
                return false;
            }
            catch (Exception ex)
            {

                Console.WriteLine("User operation has failed.Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
        }

        //: Actualiza los datos de un usuario en la BD con los datos del usuario
        //representado por el parámetro en.
        public bool updateUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try
            String comando = "UPDATE [dbo].[Usuarios] SET edad = " + en.edad + ",nombre = '" + en.nombre + 
                                        "',apellidos = '" + en.apellidos + "' where nick = '" + en.nick + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                return true;
            }
            catch (SqlException sqlex)
            {

                Console.WriteLine("User operation has failed.Error: " + sqlex.Message);
                return false;
            }
            catch (Exception ex)
            {

                Console.WriteLine("User operation has failed.Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
        }

        //: Borra el usuario representado
        //  en EN de la BD.
        public bool deleteUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try
            String comando = "DELETE FROM [dbo].[Usuarios] WHERE nif = '" + en.nif + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    return false;
                }
                return true;
            }
            catch (SqlException sqlex)
            {

                Console.WriteLine("User operation has failed.Error: " + sqlex.Message);
                return false;
            }
            catch (Exception ex)
            {

                Console.WriteLine("User operation has failed.Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null) conn.Close(); // Se asegura de cerrar la conexión.
            }
        }
        
    }
}
