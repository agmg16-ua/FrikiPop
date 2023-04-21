using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace library
{
	public class CADCarrito{
		private string constring;
		public CADCarrito(){
			constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
		}
		public bool readCarrito(ENCarrito carrito){
			return false;
		}
		public bool createCarrito(ENCarrito carrito){
			return false;
		}

		public bool updateCarrito(ENCarrito carrito) {
			return false;
        }
		public DataTable unirCarrito(ENCarrito carrito){
			return new DataTable();
		}

		public bool borrarArticulo(ENCarrito carrito, int linea){
			return false;
		}
		public bool makePedido(ENCarrito carrito)
		{
			return false;
		}
		public bool vaciarCarrito(ENCarrito carrito){
			return false;
		}

	}
}
