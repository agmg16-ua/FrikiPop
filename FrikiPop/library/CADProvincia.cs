using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace library {
    class CADProvincia {

        private String constring;

        public CADProvincia() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createProvincia(ENProvincia provincia) {

        }

        public bool deleteProvincia(ENProvincia provincia) {

        }

        public bool readProvincia(ENProvincia provincia) {

        }

        public bool updateProvincia(ENProvincia provincia) {

        }
    }
}
