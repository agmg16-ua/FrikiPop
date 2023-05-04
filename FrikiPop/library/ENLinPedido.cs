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
        private int articulo;
        private float importe;
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
        public int _articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }
        public float _importe
        {
            get { return importe; }
            set { importe = value; }
        }
 
        public ENLinPedido(int pedido, int linea, int articulo, float importe)
        {
            this.pedido = pedido;
            this.linea = linea;
            this.articulo = articulo;
            this.importe = importe;
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
