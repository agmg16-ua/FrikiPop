using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace library {
    public class CADProvincia {

        private String constring;

        public CADProvincia() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createProvincia(ENProvincia provincia) {
            bool creado = false;
            SqlConnection conexion = null;
            
            try {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Insert into Provincia (provincia, pais) values ('" + provincia.provincia + "', '" + provincia.pais + "')";
                SqlCommand command = new SqlCommand(consulta, conexion);

                command.ExecuteNonQuery();
                creado = true;

            } catch (SqlException e) {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            } catch (Exception e) {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            } finally {
                if(conexion.State == ConnectionState.Open) {
                    conexion.Close();
                }
            }

            return creado;
        }

        public bool deleteProvincia(ENProvincia provincia) {
            bool eliminado = false;
            SqlConnection conexion = null;

            try {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Delete from Provincia where provincia = '" + provincia.provincia + "' and pais = '" + provincia.pais + "'";
                SqlCommand command = new SqlCommand(consulta, conexion);

                command.ExecuteNonQuery();
                eliminado = true;
            } catch (SqlException e) {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            } catch (Exception e) {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            } finally {
                if(conexion.State == ConnectionState.Open) {
                    conexion.Close();
                }
            }

            return eliminado;
        }

        public bool readProvincia(ENProvincia provincia) {
            bool leido = false;
            SqlConnection conexion = null;

            try {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Select * from Provincia where provincia = '" + provincia.provincia + "' and pais = '" + provincia.pais + "'";
                SqlCommand command = new SqlCommand(consulta, conexion);

                SqlDataReader busqueda = command.ExecuteReader();
                busqueda.Read();

                if(busqueda["provincia"].ToString() == provincia.provincia &&
                    busqueda["pais"].ToString() == provincia.pais) {
                    provincia.provincia = busqueda["provincia"].ToString();
                    provincia.pais = busqueda["pais"].ToString();
                    leido = true;
                }

                busqueda.Close();

            } catch (SqlException e) {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            } catch (Exception e) {
                Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            } finally {
                if(conexion.State == ConnectionState.Open) {
                    conexion.Close();
                }
            }

            return leido;
        }

        public DataTable listarProvincias() {
            DataTable tabla = new DataTable();
            SqlConnection conexion = null;

            try {
                conexion = new SqlConnection(constring);

                SqlDataAdapter data = new SqlDataAdapter("Select * from Provincia", conexion);
                data.Fill(tabla);

            } catch (SqlException e) {
                Console.WriteLine("The operation has failed.Error: {0}", e.Message);
            } catch (Exception e) {
                Console.WriteLine("The operation has failed.Error: {0}", e.Message);
            } finally {
                if (conexion.State == ConnectionState.Open) {
                    conexion.Close();
                }
            }
            return tabla;
        }
    }
}
