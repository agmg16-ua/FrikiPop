using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class ENArticulo
    {
        private string _codigo;
        private string _nombre;
        private string _descripcion;
        private float _precio;
        private string _imagen;

        public string codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }

        public float precio
        {
            get 
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        public string imagen
        {
            get
            {
                return _imagen;
            }
            set
            {
                _imagen = value;
            }
        }
    }
}
