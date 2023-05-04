using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using library;


namespace library
{
    public class ENLineaCarrito {
        private int linea_;
        private int id_carrito_;
        private float importe_;
        private string usuario_;
        private string articulo_;

        public int linea {
            get{
                return linea_;
            }
            set{
                linea_=value;
            }
        }

        public int id_carrito
        {
            get{
                return id_carrito_;
            }
            set{
                id_carrito_=value;
            }
        }

        public float importe{
            get {
                return importe_;
            }
            set{
                importe_=value;
            }
        }

        public string usuario{
            get{
                return usuario_;
            }
            set{
                usuario_=value;
            }
        }
        public string articulo{
            get{
                return articulo_;
            }
            set{
                articulo_=value;
            }
        }

        public ENLineaCarrito() {

            linea=0;
            id_carrito=0;
            importe=0;
            usuario=null;
            articulo = null;

        }
        public ENLineaCarrito(int linea_, int id_carrito_, float importe_, string usuario_, string articulo_) {

            linea = linea_;
            id_carrito = id_carrito_;
            importe = importe_;
            usuario = usuario_;
            articulo = articulo_;
        }

        public bool readLineaCarrito() {
            bool leido;
            CADLineaCarrito lineaCarri;
            lineaCarri = new CADLineaCarrito();
            leido = lineaCarri.readLineaCarrito(this);
            return leido;
        }
        public bool createLineaCarrito() {
            bool creado;
            CADLineaCarrito lineaCarri;
            lineaCarri = new CADLineaCarrito();
            creado = lineaCarri.createLineaCarrito(this);
            return creado;
        }
        public bool deleteLineaCarrito() {
            bool borrado;
            CADLineaCarrito lineaCarri;
            lineaCarri = new CADLineaCarrito();
            borrado = lineaCarri.deleteLineaCarrito(this);
            return borrado;
        }

        public DataSet enlistarLineaCarrito() {

            CADLineaCarrito lineaCarri;
            lineaCarri= new CADLineaCarrito();
            DataSet dataSet; new DataTable();
            dataSet = lineaCarri.enlistarLineaCarrito(this);
            return dataSet;
        }
    }
 }
