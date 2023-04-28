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
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createUsuario(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try

            String comando = "Insert into [dbo].[Usuario] (nick_name,nombre,apellidos,edad,contrasenya,url_imagen,admin,localidad,provincia,pais)" +
                "                            VALUES('" + en.nick + "','" + en.nombre + "','" + en.apellidos + "'," + en.edad +
                                                    ",'" + en.contrasenya + "','" + en.imagen + "'," + en.admin + "," +
                                                    "'" + en.localidad + "','" + en.provincia + "','" + en.pais + "')";
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
            String comando = "Select * from [dbo].[Usuario] where nick = '" + en.nick + "'";
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    en.nombre = dr["nombre"].ToString();
                    en.apellidos = dr["apellidos"].ToString();
                    en.edad = int.Parse(dr["edad"].ToString());
                    en.contrasenya = dr["contrasenya"].ToString();
                    en.imagen = dr["imagen"].ToString();
                    en.admin = int.Parse(dr["admin"].ToString());
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
            String comando = "UPDATE [dbo].[Usuario] SET edad = " + en.edad + ",nombre = '" + en.nombre +
                                        "',apellidos = '" + en.apellidos + "',contrasenya = '" + en.contrasenya +
                                        "',localidad = '" + en.localidad + "',provincia = '" + en.provincia + "',pais = '" + en.pais +
                                        "', url_imagen = '" + en.imagen + "', admin = " + en.admin + " where nick_name = '" + en.nick + "'";

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
            String comando = "DELETE FROM [dbo].[Usuario] WHERE nick_name = '" + en.nick + "'";

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

        public bool esAdmin(ENUsuario en)
        {
            SqlConnection conn = null;
            // Encapsula todo el acceso a datos dentro del try
            String comando = "SELECT FROM [dbo].[Usuario] WHERE nick_name = '" + en.nick + "'";

            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                return (int.Parse(dr["admin"].ToString()) == 1);
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

        //FILTROS A LA BASE DE DATOS PARA LOS ADMINS
        public DataSet mostrarTodosLosUsuarios()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[Usuario]", c);
            da.Fill(bdvirtual, "[dbo].[Usuario]");

            return bdvirtual;
        }

        public DataSet filtrarPorEdad(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[Usuario] where edad = " + en.edad, c);
            da.Fill(bdvirtual, "[dbo].[Usuario]");

            return bdvirtual;
        }
        public DataSet filtrarPorNombre(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[Usuario] where nombre = '" + en.nombre + "'", c);
            da.Fill(bdvirtual, "[dbo].[Usuario]");

            return bdvirtual;
        }
        public DataSet filtrarPorApellidos(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            SqlDataAdapter da = new SqlDataAdapter("Select * from [dbo].[Usuario] where apellidos like '" + en.apellidos + "%'", c);
            da.Fill(bdvirtual, "[dbo].[Usuario]");

            return bdvirtual;
        }
        public DataSet filtrarPorLocalidad(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[Usuario] where localidad = '" + en.localidad + "'", c);
            da.Fill(bdvirtual, "[dbo].[Usuario]");

            return bdvirtual;
        }
        public DataSet filtrarPorProvincia(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring); 

            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[Usuario] where provincia = '" + en.provincia + "'", c);
            da.Fill(bdvirtual, "[dbo].[Usuario]");

            return bdvirtual;
        }
        public DataSet filtrarPorPais(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[Usuario] where pais = '" + en.pais + "'", c);
            da.Fill(bdvirtual, "[dbo].[Usuario]");

            return bdvirtual;
        }
    }
}
