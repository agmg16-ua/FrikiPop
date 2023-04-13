using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {
        private string _nif;
        private string _nombre;
        private int _edad;

        public string nif
        {
            get
            {
                return _nif;
            }
            set
            {
                string dni = value;

                if(dni.Length != 9)
                {
                    dniIncorrecto(this, new DniIncorrectoArgs(dni));
                }

                char letra = dni[dni.Length - 1];
                string dniSinLetra = dni.Remove(dni.Length - 1, 1);
                int numero = int.Parse(dniSinLetra);
                numero = numero % 23;
                switch (numero)
                {
                    case 0: 
                        if(letra != 'T') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 1:
                        if (letra != 'R') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 2:
                        if (letra != 'W') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 3:
                        if (letra != 'A') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 4:
                        if (letra != 'G') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 5:
                        if (letra != 'M') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 6:
                        if (letra != 'Y') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 7:
                        if (letra != 'F') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 8:
                        if (letra != 'P') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 9:
                        if (letra != 'D') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 10:
                        if (letra != 'X') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 11:
                        if (letra != 'B') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 12:
                        if (letra != 'N') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 13:
                        if (letra != 'J') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 14:
                        if (letra != 'Z') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 15:
                        if (letra != 'S') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 16:
                        if (letra != 'Q') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 17:
                        if (letra != 'V') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 18:
                        if (letra != 'H') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 19:
                        if (letra != 'L') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 20:
                        if (letra != 'C') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 21:
                        if (letra != 'K') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                    case 22:
                        if (letra != 'E') { dniIncorrecto(this, new DniIncorrectoArgs(value)); }
                        break;
                }
                _nif = value;
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
        public int edad
        {
            get
            {
                return _edad;
            }
            set
            {
                if(value < 0)
                {
                    edadIncorrecta(this, new EdadIncorrectaArgs(value));
                }
            }
        }
        public ENUsuario()
        {
            nif = null;
            nombre = null;
            edad = 0;
        }
        public ENUsuario(string nif, string nombre, int edad)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.edad = edad;
        }
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
        public bool readFirstUsuario()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.readFirstUsuario(this);
        }
        public bool readNextUsuario()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.readNextUsuario(this);
        }
        public bool readPrevUsuario()
        {
            CADUsuario cADUsuario = new CADUsuario();
            return cADUsuario.readPrevUsuario(this);
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

        //EVENTOS
        public event EventHandler<DniIncorrectoArgs> dniIncorrecto;
        public event EventHandler<EdadIncorrectaArgs> edadIncorrecta;
    }

    //clases para los EVENTOS
    public class DniIncorrectoArgs : EventArgs
    {
        public string dni { get; set; }
        public DniIncorrectoArgs(string dni)
        {
            this.dni = dni;
        }
    }
    public class EdadIncorrectaArgs : EventArgs
    {
        public int edad { get; set; }
        public EdadIncorrectaArgs(int edad)
        {
            this.edad = edad;
        }
    }
}

