using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace library
{
    class CADArticulo
    {
        private String constring;

        public CADArticulo()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createArticulo(ENArticulo articulo)
        {

        }

        public bool deleteArticulo(ENArticulo articulo)
        {

        }

        public bool readArticulo(ENArticulo articulo)
        {

        }

        public bool updateArticulo(ENArticulo articulo)
        {

        }

        public bool usuarioArticulo(ENArticulo articulo)
        {

        }
    }
}
