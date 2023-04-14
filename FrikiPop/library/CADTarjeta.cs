using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADTarjeta
    {
        private string constring;

        public CADTarjeta()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        //Crea el pais pasado como parametro
        public bool createTarjeta(ENTarjeta tarjeta)
        {

        }

        //Lee el pais pasado como parametro
        public bool readTarjeta(ENTarjeta tarjeta)
        {

        }
        //Actualiza el pais actual por el pasado por parametro
        public bool updateTarjeta(ENTarjeta tarjeta)
        {

        }
        //Borra el pais pasado como parametro si existe
        public bool deleteTarjeta(ENTarjeta tarjeta)
        {

        }
    }
}
