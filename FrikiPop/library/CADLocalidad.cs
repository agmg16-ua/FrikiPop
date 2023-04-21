using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace library {
    class CADLocalidad {

        private String constring;
        
        public CADLocalidad() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createLocalidad(ENLocalidad localidad) {
            return true;
        }

        public bool deleteLocalidad(ENLocalidad localidad) {
            return true;
        }

        public bool readLocalidad(ENLocalidad localidad) {
            return true;
        }

        public bool updateLocalidad(ENLocalidad localidad) {
            return true;
        }


    }
}
