using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENLinPedido
    {
        private int pedido;
        private int linea;
        private string articulo;
        private float importe;
        private string usuario;
        public int _pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }
        public int _linea
        {
            get { return linea; }
            set { linea = value; }
        }
        public string _articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }
        public float _importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public string _usuario {
            get { return usuario; }
            set { usuario = value; }
        }
 
        public ENLinPedido(int linea, int pedido, string articulo, float importe, string usuario)
        {
            this.pedido = pedido;
            this.linea = linea;
            this.articulo = articulo;
            this.importe = importe;
            this.usuario = usuario;
        }
        public bool createLinPedido()
        {
            CADLinPedido pedido = new CADLinPedido();
            if (!pedido.readLinPedido(this))
            {
                return pedido.createLinPedido(this);
            }
            return false;
        }
        public bool readLinPedido()
        {
            CADLinPedido pedido = new CADLinPedido();
            return pedido.readLinPedido(this);
        }
        public bool updateLinPedido()
        {
            CADLinPedido pedido = new CADLinPedido();
            if (pedido.readLinPedido(this))
            {
                return pedido.updateLinPedido(this);
            }

            return false;
        }
        public bool deleteLinPedido()
        {
            CADLinPedido pedido = new CADLinPedido();
            if (pedido.readLinPedido(this))
            {
                return pedido.deleteLinPedido(this);
            }

            return false;
        }
    }
}
