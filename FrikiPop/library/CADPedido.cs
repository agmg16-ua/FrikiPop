using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace library {
    class CADPedido {
        private string constring;
        public CADPedido() {
            constring = ConfigurationManager.ConnectionStrings["Database1"].ToString()
        }
        public bool createPedido(ENPedido en) {
            SqlConnection connection = new SqlConnection(constring);
        }
        public bool readPedido(ENPedido en) {

        }
        public int obtenerId() {

        }
        
        public DataTable joinPedido(ENPedido en) {

        }
        public bool devolucionPedido(ENPedido en) {

        }

        public bool deletePedido(ENPedido en) {

        }
        public DataSet listarPedidos(string en) {

        }
    }
}
