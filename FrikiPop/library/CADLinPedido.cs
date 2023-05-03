using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace library
{
    public class CADLinPedido
    {
        private string constring;
        public CADLinPedido()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        public bool createLinPedido(ENLinPedido en)
        {
            return true;
        }
        public bool readLinPedido(ENLinPedido en)
        {
            return true;
        }
        public bool updateLinPedido(ENLinPedido en)
        {
            return true;
        }
        public bool deleteLinPedido(ENLinPedido en)
        {
            return true;
        }
    }
}
