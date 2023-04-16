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
        }

        public ENTarjeta(int num, int diaFecha, int mesFecha, int cvv)
        {
            this.num = num;
            this.diaFecha = diaFecha;
            this.mesFecha = mesFecha;
            this.cvv = cvv;
        }

        public bool createTarjeta()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            return tarjeta.createTarjeta();
        }

        public bool readTarjeta()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            return tarjeta.readTarjeta();
        }

        public bool updateTarjeta()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            return tarjeta.updateTarjeta();
        }

        public bool deleteTarjeta()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            return tarjeta.deleteTarjeta();
        }


    }
}
