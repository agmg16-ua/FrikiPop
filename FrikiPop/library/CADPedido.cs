using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace library {
    public class CADPedido {
        private string constring;
        public CADPedido() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        public bool createPedido(ENPedido en) {
            SqlConnection connection = new SqlConnection(constring);
            return true;
        }
        public bool readPedido(ENPedido en) {
            return true;
        }
        public int getId() {
            return 1;

        }
        
       /*public DataTable joinPedido(ENPedido en) {
       }*/
        public bool devolucionPedido(ENPedido en) {
            return true;
        }

        public bool deletePedido(ENPedido en) {
            return true;
        }
        /*public DataSet listPedidos(string en) {
            
        }*/
    }
}
