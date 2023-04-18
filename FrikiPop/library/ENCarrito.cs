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
		
		public bool createCarrito(){
			bool creado;
			CADCarrito carri = new CADCarrito();
			creado = carri.createCarrito(this);
			return creado;
		}

		public bool readCarrito()
		{
			bool leido;
			CADCarrito carri = new CADCarrito();
			leido = carri.readCarrito(this);
			return leido;
		}

		public DataTable unirCarrito(){

			CADCarrito carri = new CADCarrito();
			DataTable dataTable = new DataTable();
			dataTable = carri.unirCarrito(this);
			return dataTable;
		}

		public bool makePedido()
		{
			bool realizado;
			CADCarrito carri = new CADCarrito();
			realizado = carri.makePedido(this);
			return realizado;

		}

		public void getId(){
			int id;
			CADCarrito carri = new CADCarrito();
			id = carri.getId();
			this.numeroCarrito_=id;
		}

		public bool vaciarCarrito(){
			bool vaciado;
			CADCarrito carri = new CADCarrito();
			vaciado = carri.vaciarCarrito(this);
			return vaciado;
		}
	}
}
