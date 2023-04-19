using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {
        private string _nick;
        private string _nombre;
        private string _apellidos;
        private int _edad;
        private string _contrasenya;
        private string _imagen;
        private string _localidad;

        public string nick
        {
            get
            {
                return _nick;
            }
            set
            {
                _nick = value;
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
        public string apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = value;
            }
        }
        public int edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = edad;
            }
        }
        public string contrasenya
        {
            get
            {
                return _contrasenya;
            }
            set
            {
                _contrasenya = value;
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
        public string localidad
        {
            get
            {
                return _localidad;
            }
            set
            {
                _localidad = value;
            }
        }
        
        public ENUsuario()
        {
            nick = null;
            nombre = null;
            apellidos = null;
            contrasenya = null;
            imagen = null;
            localidad = null;
            edad = 0;
        }
        public ENUsuario(string nif, string nombre,string apellidos,string contrasenya,string localidad, int edad)
        {
            this.nick = nif;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.contrasenya = contrasenya;
            this.imagen = imagen;
            this.localidad = localidad;
            this.edad = edad;
        }

        //Comandos CRUD
        public bool createUsuario()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.createUsuario(this);
        }
        public bool readUsuario()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.readUsuario(this);
        }
        public bool updateUsuario()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.updateUsuario(this);
        }
        public bool deleteUsuario()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.deleteUsuario(this);
        }

        //FILTROS DE LOS USUARIOS SEGUN SUS ATRIBUTOS(No filtro por contraseña porque no tiene sentido, se supone que es privada para nosotros)
        public bool filtrarPorLocalidad()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.filtrarPorLocalidad(this);
        }
        public bool filtrarPorNombre()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.filtrarPorNombre(this);
        }
        public bool filtrarPorApellidos()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.filtrarPorApellidos(this);
        }
        public bool filtrarPorEdad()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.filtrarPorEdad(this);
        }
    }
}

