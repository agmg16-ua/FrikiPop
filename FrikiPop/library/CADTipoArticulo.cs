using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace library {
    class CADTipoArticulo {

        private String constring;

        public CADTipoArticulo() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createTipoArticulo(ENTipoArticulo tipoArticulo) {
            return true;
        }

        public bool deleteTipoArticulo(ENTipoArticulo tipoArticulo) {
            return true;
        }

        public bool readTipoArticulo(ENTipoArticulo tipoArticulo) {
            return true;
        }

        public bool updateTipoArticulo(ENTipoArticulo tipoArticulo) {
            return true;
        }
    }
}
