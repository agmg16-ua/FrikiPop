using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    public class CADLineaCarrito{
        private string constring;

        public CADLineaCarrito() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool readLineaCarrito(ENLineaCarrito carrito) {
            return false;
        }

        public bool createLineaCarrito(ENLineaCarrito carrito) {
            return false;
        }

        public bool deleteLineaCarrito(ENLineaCarrito carrito) {
            return false;
        }

        public DataSet enlistarLineaCarrito(ENLineaCarrito carrito) {
            return new DataSet();
        }

        public bool updateLineaCarrito(ENLineaCarrito carrito) {
            return false;
        }


    }
}
