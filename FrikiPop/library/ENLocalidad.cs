using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    class ENLocalidad {

        private string _localidad;

        public string localidad {
            get { return _localidad; }
            set { _localidad = value; }
        }

        public ENLocalidad() {
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
            CADLocalidad localidad = new CADLocalidad();
            if(!localidad.readLocalidad(this)) {
                return localidad.updateLocalidad(this);
            }
            return false;
        }

    }
}
