using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENTarjeta
    {
        private int _num;
        private int _diaFecha;
        private int _mesFecha;
        private int _cvv;
        private string _usuario;

        public int num
        {
            get
            {
                return _num;
            }
            set{
                _num = value;
            }
        }

        public int diaFecha
        {
            get
            {
                return _diaFecha;
            }
            set
            {
                _diaFecha = value;
            }
        }

        public int mesFecha
        {
            get
            {
                return _mesFecha;
            }
            set
            {
                _mesFecha = value;
            }
        }

        public int cvv
        {
            get
            {
                return _cvv;
            }
            set
            {
                _cvv = value;
            }
        }

        public string usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }
        public ENTarjeta()
        {
            num = 0;
            diaFecha = 0;
            mesFecha = 0;
            cvv = 0;
            usuario = "";
        }

        public ENTarjeta(int num, int diaFecha, int mesFecha, int cvv, string usuario)
        {
            this.num = num;
            this.diaFecha = diaFecha;
            this.mesFecha = mesFecha;
            this.cvv = cvv;
            this.usuario = usuario;
        }

        public bool createTarjeta()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            bool creado = false;
            if (!tarjeta.createTarjeta(this))
            {
                creado = tarjeta.createTarjeta(this);
            }
            return creado;
        }

        public bool readTarjeta()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            bool read = tarjeta.readTarjeta(this);
            return read;
        }

        public bool updateTarjeta()
        {
            ENTarjeta aux = new ENTarjeta();
            CADTarjeta tarjeta = new CADTarjeta();

            bool actualizado = false;
            aux._usuario = this._usuario;
            aux._num = this._num;
            aux._diaFecha = this._diaFecha;
            aux._mesFecha = this._mesFecha;
            aux._cvv = this._cvv;

            if (tarjeta.readTarjeta(this))
            {
                this._usuario = aux._usuario;
                this._num = aux._num;
                this._diaFecha = aux._diaFecha;
                this._mesFecha = aux._mesFecha;
                this._cvv = aux._cvv;
                actualizado = tarjeta.updateTarjeta(this);
            }

            return actualizado;
        }

        public bool deleteTarjeta()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            bool leido = false;
            if (tarjeta.readTarjeta(this))
            {
                leido = tarjeta.deleteTarjeta(this);
            }
            return leido;
        }

        public void addTarjeta(string usuario)
        {
            CADTarjeta tarjeta = new CADTarjeta();
            ENTarjeta nuevaTarjeta = new ENTarjeta();
            tarjeta.addTarjetaUsuario(nuevaTarjeta, usuario);
        }

    }
}
