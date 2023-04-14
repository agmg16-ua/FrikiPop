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
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool createLocalidad(ENLocalidad localidad) {

        }

        public bool deleteLocalidad(ENLocalidad localidad) {

        }

        public bool readLocalidad(ENLocalidad localidad) {

        }

        public bool updateLocalidad(ENLocalidad localidad) {

        }


    }
}
