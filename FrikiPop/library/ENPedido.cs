using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;

namespace library {
    class ENPedido {
        private int _idPedido;
        private string _user;
        private string _date;
        private string _address;
        public int idPedido {
            get { return _idPedido; }
            set { _idPedido = value; }
        }
        public string user {
            get { return _user; }
            set { _user = value; }
        }
        public string date {
            get { return _date; }
            set { _date = value; }
        }
        public string address {
            get { return _address; }
            set { _address = value; }
        }
       /* public DataTable joinPedido() {
            CADPedido pedido = new CADPedido();
            return pedido.joinPedido(this);
        }*/

        public ENPedido() {
            idPedido = 0;
            date = null;
            address = null;
        }
        public bool createPedido() {
            CADPedido pedido = new CADPedido();
            return pedido.createPedido(this);
        }
        public bool readPedido() {
            CADPedido pedido = new CADPedido();
            return pedido.readPedido(this);
        }
        public bool deletePedido() {
            CADPedido pedido = new CADPedido();
            return pedido.deletePedido(this);
        }
       /* public static DataSet listPedidos(string mail) {
            CADPedido pedidos = new CADPedido();
            return pedidos.listPedidos(mail);
        }*/

        internal void getId() {
            CADPedido pedido = new CADPedido();
            this.idPedido = pedido.getId();
        }

    }
}
