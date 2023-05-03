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

namespace library {
    class CADLocalidad {

        private String constring;
        
        public CADLocalidad() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createLocalidad(ENLocalidad localidad) {
            bool creado = false;
            SqlConnection conexion = null;

            try {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Insert into Localidad (localidad, provincia, pais) values ('" + localidad.localidad + "', '" + localidad.provincia + "' , '" + localidad.pais + "')";
                SqlCommand command = new SqlCommand(consulta, conexion);

                command.ExecuteNonQuery();
                creado = true;

            } catch(SqlException e) {
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

        public bool deleteLocalidad(ENLocalidad localidad) {
            bool eliminado = false;
            SqlConnection conexion = null;

            try {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Delete from Localidad where localidad = '" + localidad.localidad + "' and provincia = '" + localidad.provincia + "' and pais = '" + localidad.pais + "'";
                SqlCommand command = new SqlCommand(consulta, conexion);

                command.ExecuteNonQuery();
                eliminado = true;

            } catch(SqlException e) {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            } catch (Exception e) {
                Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            } finally {
                if (conexion.State == ConnectionState.Open) {
                    conexion.Close();
                }
            }

            return eliminado;
        }

        public bool readLocalidad(ENLocalidad localidad) {
            bool leido = false;
            SqlConnection conexion = null;

            try {
                conexion = new SqlConnection(constring);
                conexion.Open();

                string consulta = "Select * from Localidad where localidad = '" + localidad.localidad + "' and provincia = '" + localidad.provincia + "' and pais = '" + localidad.pais + "'";
                SqlCommand command = new SqlCommand(consulta, conexion);

                SqlDataReader busqueda = command.ExecuteReader();
                busqueda.Read();

                if(busqueda.HasRows) {
                    if (busqueda["localidad"].ToString() == localidad.localidad &&
                            busqueda["provincia"].ToString() == localidad.provincia &&
                            busqueda["pais"].ToString() == localidad.pais) {
                        localidad.localidad = busqueda["localidad"].ToString();
                        localidad.provincia = busqueda["provincia"].ToString();
                        localidad.pais = busqueda["pais"].ToString();
                        leido = true;
                    }
                }

                busqueda.Close();

            } catch(SqlException e) {
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

        public DataTable listarLocalidad(string provincia, string pais) {
            DataTable tabla = new DataTable();
            SqlConnection conexion = null;

            try {
                conexion = new SqlConnection(constring);
                string consulta = "";
                
                if(provincia == "" || pais == "") {
                    consulta = "Select * from Localidad";
                } else {
                    consulta = "Select * from Localidad where provincia = '" + provincia + "' and pais = '" + pais + "'";
                }

                SqlDataAdapter data = new SqlDataAdapter(consulta, conexion);
                data.Fill(tabla);

            }catch(SqlException e) {
                Console.WriteLine("The operation has failed.Error: {0}", e.Message);
            } catch(Exception e) {
                Console.WriteLine("The operation has failed.Error: {0}", e.Message);
            } finally {
                if(conexion.State == ConnectionState.Open) {
                    conexion.Close();
                }
            }
            return tabla;
        }


    }
}
