using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENTarjeta
    {
        private int _num;
        private int _anyoFecha;
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

        public int anyoFecha
        {
            get
            {
                return _anyoFecha;
            }
            set
            {
                _anyoFecha = value;
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

        //Constructor por defecto
        public ENTarjeta()
        {
            num = 0;
            anyoFecha = 0;
            mesFecha = 0;
            cvv = 0;
            usuario = "";
        }

        //constructor de copia
        public ENTarjeta(int num, int anyoFecha, int mesFecha, int cvv, string usuario)
        {
            this.num = num;
            this.anyoFecha = anyoFecha;
            this.mesFecha = mesFecha;
            this.cvv = cvv;
            this.usuario = usuario;
        }

        //crea la tarjeta
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

        //lee la tarjeta
        public bool readTarjeta()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            bool read = tarjeta.readTarjeta(this);
            return read;
        }

        //actualiza la tarjeta
        public bool updateTarjeta()
        {
            ENTarjeta aux = new ENTarjeta();
            CADTarjeta tarjeta = new CADTarjeta();

            bool actualizado = false;
            aux.usuario = this.usuario;
            aux.num = this.num;
            aux.anyoFecha = this.anyoFecha;
            aux.mesFecha = this.mesFecha;
            aux.cvv = this.cvv;

            if (tarjeta.readTarjeta(this))
            {
                this.usuario = aux.usuario;
                this.num = aux.num;
                this.anyoFecha = aux.anyoFecha;
                this.mesFecha = aux.mesFecha;
                this.cvv = aux.cvv;
                actualizado = tarjeta.updateTarjeta(this);
            }

            return actualizado;
        }

        //borra la tarjeta
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

        //lista las tarjetas
        public DataTable listarTarjetas()
        {
            CADTarjeta tarjeta = new CADTarjeta();
            return tarjeta.listarTarjetas();
        }

        //lista las tarjetas dado un usuario
        public static DataSet listarTarjetas() {
            CADTarjeta tarjeta = new CADTarjeta();
            return tarjeta.listarTarjetas(string usuario);
        }

    }
}
