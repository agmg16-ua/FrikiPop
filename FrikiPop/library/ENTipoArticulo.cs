using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    public class ENTipoArticulo {

        private string _tipoArticulo;

        public string tipoArticulo {
            get { return _tipoArticulo; }
            set { _tipoArticulo = value; }
        }

        //Contructor copia
        public ENTipoArticulo() {
            tipoArticulo = null;
        }

        //CRUD (create, read, update, delete)
        public bool createTipoArticulo() {
            CADTipoArticulo tipoArticulo = new CADTipoArticulo();
            if (!tipoArticulo.readTipoArticulo(this)) {
                return tipoArticulo.createTipoArticulo(this);
            }
            return false;
        }

        public bool deleteTipoArticulo() {
            CADTipoArticulo tipoArticulo = new CADTipoArticulo();
            if (tipoArticulo.readTipoArticulo(this)) {
                return tipoArticulo.deleteTipoArticulo(this);
            }
            return false;
        }

        public bool readTipoArticulo() {
            CADTipoArticulo tipoArticulo = new CADTipoArticulo();
            return tipoArticulo.readTipoArticulo(this);
        }

        public bool updateTipoArticulo() {
            CADTipoArticulo tipoArticulo = new CADTipoArticulo();
            if (!tipoArticulo.readTipoArticulo(this)) {
                return tipoArticulo.updateTipoArticulo(this);
            }
            return false;
        }

    }
}
