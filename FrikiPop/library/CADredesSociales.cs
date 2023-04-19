using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace library
{
    class CADredesSociales
    {
        private String constring;

        public CADredesSociales()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        public bool createRedesSociales(ENredesSociales redesSociales)
        {

        }

        public bool deleteRedesSociales(ENredesSociales redesSociales)
        {

        }

        public bool readRedesSociales(ENredesSociales redesSociales)
        {

        }

        public bool updateRedesSociales(ENredesSociales redesSociales)
        {

        }
    }
}
