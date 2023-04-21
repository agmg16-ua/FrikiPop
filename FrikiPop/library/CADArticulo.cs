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
            return true;
        }

        public bool deleteArticulo(ENArticulo articulo)
        {
            return true;
        }

        public bool readArticulo(ENArticulo articulo)
        {
            return true;
        }

        public bool updateArticulo(ENArticulo articulo)
        {
            return true;
        }

        public bool usuarioArticulo(ENArticulo articulo)
        {
            return true;
        }
    }
}
