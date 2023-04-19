using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;

namespace library {
    class ENPedido {
        private int idPedido;
        private string user;
        private string date;
        private string address;
        public int _idPedido {
            get { return idPedido; }
            set { idPedido = value; }
        }
        public string _user {
            get { return user; }
            set { user = value; }
        }
        public string _date {
            get { return date; }
            set { date = value; }
        }
        public string _address {
            get { return address; }
            set { address = value; }
        }
        public DataTable joinPedido() {
            CADPedido pedido = new CADPedido();
            return pedido.joinPedido(this);
        }

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
        public static DataSet listPedidos(string mail) {
            CADPedido pedidos = new CADPedido();
            return pedidos.listPedidos(mail);
        }

        internal void getId() {
            CADPedido pedido = new CADPedido();
            this.idPedido = pedido.getId();
        }

    }
}
