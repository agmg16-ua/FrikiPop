using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADPais
    {
        private string constring;

        public CADPais()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        //Crea el pais pasado como parametro
        public bool createPais(ENPais pais)
        {

        }

        //Lee el pais pasado como parametro
        public bool readPais(ENPais pais)
        {

        }
        //Actualiza el pais actual por el pasado por parametro
        public bool updatePais(ENPais pais)
        {

        }
        //Borra el pais pasado como parametro si existe
        public bool deletePais(ENPais pais)
        {

        }
    }
}
