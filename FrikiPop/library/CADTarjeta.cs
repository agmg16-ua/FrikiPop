using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADTarjeta
    {
        private string constring;

        //Constructor por defecto
        public CADTarjeta()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        //Crea la tarjeta pasada como parámetro
        public bool createTarjeta(ENTarjeta tarjeta)
        {
            SqlConnection connection = new SqlConnection(constring);

            try {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert INTO [dbo].[TARJETA](numTarjeta, cvv, mes_cad, anyo_cad, usuario) VALUES(" + tarjeta.num + ", " + tarjeta.cvv + ", " + tarjeta.mesFecha + ", " + tarjeta.anyoFecha + ", '" + tarjeta.usuario + "')");
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception e) {
                Console.WriteLine("Create TARJETA has failed. Error: {0}", e.Message);
                return false;
            }
            finally {
                connection.Close();
            }
        }

        //Lee la tarjeta pasada como parámetro
        public bool readTarjeta(ENTarjeta tarjeta)
        {
            SqlConnection connection = new SqlConnection(constring);
            try {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * FROM [dbo].[TARJETA] where numTarjeta= " + tarjeta.num, connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception e) {
                Console.WriteLine("Reading TARJETA table has failed. Error: {0}", e.Message);
                return false;
            }
            finally {
                connection.Close();
            }
        }
        //Actualiza la tarjeta actual por la pasada por parámetro
        public bool updateTarjeta(ENTarjeta tarjeta)
        {
            return true;
        }
        //Borra la tarjeta pasada como parámetro si existe
        public bool deleteTarjeta(ENTarjeta tarjeta)
        {
            return true;
        }
        
        //Añade una tarjeta pasada como parámetro al usuario pasado como parámetro
        public void addTarjetaUsuario(ENTarjeta tarjeta)
        {

        }

        //Lista las tarjetas del usuario pasado como parámetro
        public DataSet listarTarjetas(string usuario)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection connection = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[TARJETA] where usuario= '" + usuario + "'", connection);
            da.Fill(bdvirtual, "TARJETA");
            return bdvirtual;
        }
    }
}
