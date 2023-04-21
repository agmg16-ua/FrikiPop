using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace library
{
    public class CADUsuario
    {
        private string constring;
        
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        
        public bool createUsuario(ENUsuario en)
        {
            return true;
        }

        //Devuelve solo el usuario indicado leído de la BD.
        public bool readUsuario(ENUsuario en)
        {
            return true;
        }

        //: Actualiza los datos de un usuario en la BD con los datos del usuario
        //representado por el parámetro en.
        public bool updateUsuario(ENUsuario en)
        {
            return true;
        }

        //: Borra el usuario representado
        //  en EN de la BD.
        public bool deleteUsuario(ENUsuario en)
        {
            return true;
        }

        public bool filtrarPorLocalidad(ENUsuario en)
        {
            return true;
        }
    
        public bool filtrarPorEdad(ENUsuario en)
        {
            return true;
        }
        public bool filtrarPorNombre(ENUsuario en)
        {
            return true;
        }
        public bool filtrarPorApellidos(ENUsuario en)
        {
            return true;
        }
    }
}
