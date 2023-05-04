using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace library
{
    public class CADredesSociales
    {
        private String constring;

        public CADredesSociales()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createRedesSociales(ENredesSociales redesSociales)
        {
            return true;
        }

        public bool deleteRedesSociales(ENredesSociales redesSociales)
        {
            return true;
        }

        public bool readRedesSociales(ENredesSociales redesSociales)
        {
            return true;
        }

        public bool updateRedesSociales(ENredesSociales redesSociales)
        {
            return true;
        }
    }
}
