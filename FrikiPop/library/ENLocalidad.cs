using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    class ENLocalidad {

        private string _localidad;

        private string _provincia;

        private string _pais;

        public string localidad {
            get { return _localidad; }
            set { _localidad = value; }
        }

        public string provincia {
            get { return _provincia; }
            set { _provincia = value; }
        }

        public string pais {
            get { return _pais; }
            set { _pais = value; }
        }

        public ENLocalidad() {
            localidad = null;
            provincia = null;
            localidad = null;
        }

        public bool createLocalidad() {
            CADLocalidad localidad = new CADLocalidad();
            if(!localidad.readLocalidad(this)) {
                return localidad.createLocalidad(this);
            }
            return false;
        }

        public bool deleteLocalidad() {
            CADLocalidad localidad = new CADLocalidad();
            if(localidad.readLocalidad(this)) {
                return localidad.deleteLocalidad(this);
            }
            return false;
        }

        public bool readLocalidad() {
            CADLocalidad localidad = new CADLocalidad();
            return localidad.readLocalidad(this);
        }

        public bool updateLocalidad() {
            ENLocalidad aux = new ENLocalidad();
            CADLocalidad localidad = new CADLocalidad();

            aux.localidad = this.localidad;
            aux.provincia = this.provincia;
            aux.pais = this.pais;

            if(localidad.readLocalidad(this)) {
                this.localidad = aux.localidad;
                this.provincia = aux.provincia;
                this.pais = aux.pais;

                return localidad.updateLocalidad(this);
            }
            return false;
        }

    }
}
