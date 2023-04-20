using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class CADPublicidad
    {
        private string constring;

        //Constructor por defecto
        public CADPublicidad()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        //Crea la publicidad pasada como parámetro
        public bool createPublicidad(ENPublicidad publicidad)
        {
            return true;
        }

        //Lee la publicidad pasada como parámetro
        public bool readPublicidad(ENPublicidad publicidad)
        {
            return true;
        }
        //Actualiza la publicidad actual por la pasada por parámetro
        public bool updatePublicidad(ENPublicidad publicidad)
        {
            return true;
        }
        //Borra la publicidad pasada como parámetro si existe
        public bool deletePublicidad(ENPublicidad publicidad)
        {
            return true;
        }
    }
}
