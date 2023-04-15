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
        private int _cvc;

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
                __mesFecha = value;
            }
        }

        public int cvc
        {
            get
            {
                return _cvc;
            }
            set
            {
                _cvc = value;
            }
        }


    }
}
