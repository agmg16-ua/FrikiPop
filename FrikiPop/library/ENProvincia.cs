using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    class ENProvincia {

        private string _provincia;

        public string provincia {
            set { _provincia = value; }
            get { return _provincia; }
        }

        public bool createProvincia() {
            CADProvincia provincia = new CADProvincia();
            if(!provincia.readProvincia(this)) {
                return provincia.createProvincia(this);
            }

            return false;
        }

        public bool deleteProvincia() {
            CADProvincia provincia = new CADProvincia();
            if(provincia.readProvincia(this)) {
                return provincia.deleteProvincia(this);
            }

            return false;
        }

        public bool readProvincia() {
            CADProvincia provincia = new CADProvincia();
            return provincia.readProvincia(this);
        }

        public bool updateProvincia() {
            CADProvincia provincia = new CADProvincia();
            if(provincia.readProvincia(this)) {
                return provincia.updateProvincia(this);
            }

            return false;
        }
        
    }
}
