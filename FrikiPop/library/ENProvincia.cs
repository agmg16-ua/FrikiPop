using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    class ENProvincia {

        private string _provincia;

        private string _pais;

        public string provincia {
            set { _provincia = value; }
            get { return _provincia; }
        }

        public string pais {
            set { _pais = value; }
            get { return _pais; }
        }

        public ENProvincia() {
            provincia = null;
            pais = null;
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
            ENProvincia aux = new ENProvincia();
            CADProvincia provincia = new CADProvincia();

            aux.provincia = this.provincia;
            aux.pais = this.pais;

            if(provincia.readProvincia(this)) {
                this.provincia = aux.provincia;
                this.pais = aux.pais;
                return provincia.updateProvincia(this);
            }

            return false;
        }
        
    }
}
