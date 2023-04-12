using System;
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
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public bool createUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try

            String comando = "Insert into [dbo].[Usuarios] (nif,nombre,edad) VALUES('" + en.nif + "','" + en.nombre + "'," + en.edad + ")";
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
            String comando = "Select * from [dbo].[Usuarios] where nif = '" + en.nif + "'";
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    en.nif = dr["nif"].ToString();
                    en.nombre = dr["nombre"].ToString();
                    en.edad = int.Parse(dr["edad"].ToString());
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

        //Devuelve solo el primer usuario de la BD
        public bool readFirstUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try
            String comando = "Select * from [dbo].[Usuarios]";
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    en.nif = dr["nif"].ToString();
                    en.nombre = dr["nombre"].ToString();
                    en.edad = int.Parse(dr["edad"].ToString());
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

        //Devuelve solo el usuario siguiente al indicado.

        public bool readNextUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try
            String comando = "Select * from [dbo].[Usuarios]";
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                ENUsuario aux = new ENUsuario();
                bool encontrado = false;
                while (dr.Read())
                {
                    aux.nif = dr["nif"].ToString();
                    aux.nombre = dr["nombre"].ToString();
                    aux.edad = int.Parse(dr["edad"].ToString());

                    if (aux.nif == en.nif)
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (dr.Read() && encontrado == true)
                {
                    en.nif = dr["nif"].ToString();
                    en.nombre = dr["nombre"].ToString();
                    en.edad = int.Parse(dr["edad"].ToString());
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    return false;
                }
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

        //Devuelve solo el usuario anterior al indicado.

        public bool readPrevUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try
            String comando = "Select * from [dbo].[Usuarios]";
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();


                ENUsuario auxAnterior = new ENUsuario();
                ENUsuario auxNext = new ENUsuario();
                bool encontrado = false;
                while (dr.Read())
                {

                    auxAnterior.nif = dr["nif"].ToString();
                    auxAnterior.nombre = dr["nombre"].ToString();
                    auxAnterior.edad = int.Parse(dr["edad"].ToString());

                    if (auxAnterior.nif == en.nif)
                    {
                        if (auxNext.nif == null)
                        {
                            return false;
                        }

                        en.nif = auxNext.nif;
                        en.nombre = auxNext.nombre;
                        en.edad = auxNext.edad;
                        encontrado = true;
                        break;
                    }

                    dr.Read();

                    auxNext.nif = dr["nif"].ToString();
                    auxNext.nombre = dr["nombre"].ToString();
                    auxNext.edad = int.Parse(dr["edad"].ToString());

                    if (auxNext.nif == en.nif)
                    {
                        en.nif = auxAnterior.nif;
                        en.nombre = auxAnterior.nombre;
                        en.edad = auxAnterior.edad;
                        encontrado = true;
                        break;
                    }
                }
                if (encontrado == false)
                {
                    dr.Close();
                    return false;
                }
                dr.Close();
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

        //: Actualiza los datos de un usuario en la BD con los datos del usuario
        //representado por el parámetro en.
        public bool updateUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try
            String comando = "UPDATE [dbo].[Usuarios] SET edad = " + en.edad + ",nombre = '" + en.nombre + "' where nif = '" + en.nif + "'";

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
