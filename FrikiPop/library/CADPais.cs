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
    class CADPais
    {
        private string constring;

        public CADPais()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        
        //Crea el pais pasado como parametro
        public bool createPais(ENPais pais)
        {
            return true;
        }

        //Lee el pais pasado como parametro
        public bool readPais(ENPais pais)
        {
            return true;
        }
        //Actualiza el pais actual por el pasado por parametro
        public bool updatePais(ENPais pais)
        {
            return true;
        }
        //Borra el pais pasado como parametro si existe
        public bool deletePais(ENPais pais)
        {
            return true;
        }
    }
}
