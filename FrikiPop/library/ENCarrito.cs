using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;
using System.Data;

namespace library{
	public class ENCarrito {

		private string usuario_;

		private int numeroCarrito_;

		private string estadoCarrito_;

		public int numeroCarrito{
			get{ return numeroCarrito_;}
			set{ numeroCarrito_=value;}
		}
		public string usuario{
			get{ return usuario_;}
			set{ usuario_=value;}
		}

		public string estadoCarrito{
			get { return estadoCarrito_; }
			set { estadoCarrito_=value; }
		}
		public ENCarrito(){
			numeroCarrito=0;
			estadoCarrito=null;
			usuario=null;
		}
		public ENCarrito(string usuario_, int numeroCarrito_, string estadoCarrito_) {
			usuario = usuario_;
			numeroCarrito = numeroCarrito_;
			estadoCarrito = estadoCarrito_;
        }
		
		public bool createCarrito(){
			bool creado;
			CADCarrito carri;
			carri= new CADCarrito();
			creado = carri.createCarrito(this);
			return creado;
		}

		public bool readCarrito(){
			bool leido;
			CADCarrito carri;
			carri= new CADCarrito();
			leido = carri.readCarrito(this);
			return leido;
		}

		public bool updateCarrito() {
			bool actualizado;
			CADCarrito carri;
			carri= new CADCarrito();
			actualizado = carri.updateCarrito(this);
			return actualizado;
        }

		public DataTable unirCarrito(){

			CADCarrito carri;
			carri= new CADCarrito();
			DataTable dataTable;
			dataTable= new DataTable();
			dataTable = carri.unirCarrito(this);
			return dataTable;
		}

		public bool makePedido(){
			bool realizado;
			CADCarrito carri;
			carri= new CADCarrito();
			realizado = carri.makePedido(this);
			return realizado;

		}
		public bool vaciarCarrito(){
			bool vaciado;
			CADCarrito carri;
			carri= new CADCarrito();
			vaciado = carri.vaciarCarrito(this);
			return vaciado;
		}

		public bool deleteArticulo(int linea) {
			bool borradoArticulo;
			CADCarrito carri;
			carri= new CADCarrito();
			borradoArticulo= carri.deleteArticulo(this, linea);
			return borradoArticulo;
		}

		public int obtenerIdCarrito(string nick) {
			CADArticulo articulo = new CADArticulo();
			int numero = obtenerIdCarrito(nick);
			return numero;
		}
	}
}
