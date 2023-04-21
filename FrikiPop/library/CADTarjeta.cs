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
            return true;
        }

        //Lee la tarjeta pasada como parámetro
        public bool readTarjeta(ENTarjeta tarjeta)
        {
            return true;
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
        public void addTarjetaUsuario(ENTarjeta tarjeta, string usuario)
        {

        }

        //Lista las tarjetas del usuario pasado como parámetro
        public DataSet listarTarjetas(string usuario)
        {
            DataSet bdvirtual = new DataSet();
            /*SqlConnection connection = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select * from [dbo].[TARJETA] where usuario= '" + usuario + "'", connection);
            da.Fill(bdvirtual, "TARJETA");*/
            return bdvirtual;
        }
    }
}
