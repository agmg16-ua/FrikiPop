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
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        //Crea la tarjeta pasada como parametro
        public bool createTarjeta(ENTarjeta tarjeta)
        {

        }

        //Lee la tarjeta pasada como parametro
        public bool readTarjeta(ENTarjeta tarjeta)
        {

        }
        //Actualiza la tarjeta actual por la pasada por parametro
        public bool updateTarjeta(ENTarjeta tarjeta)
        {

        }
        //Borra la tarjeta pasada como parametro si existe
        public bool deleteTarjeta(ENTarjeta tarjeta)
        {

        }
        
        //Añade una tarjeta pasado como parámetro a un usuario
        public bool addTarjetaUsuario(ENTarjeta tarjeta, string usuario)
        {

        }
    }
}
