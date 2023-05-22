using library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb {
    public partial class paginaPrincipal : System.Web.UI.Page {

        private ENArticulo articulo = new ENArticulo();

        protected void Page_Load(object sender, EventArgs e) {
            if (Request.QueryString["sesion"] == "cerrar") {
                Session.Remove("nick");
                Session.Remove("imagen");
                Session.Remove("admin");
                Response.Redirect("~/paginaPrincipal.aspx");
            }

            if(Request.QueryString["param"] == "Merchan") {
                PrincipalListView.DataSource = articulo.filtrarPorTipo("Merchan");
                PrincipalListView.DataBind();
            } else if(Request.QueryString["param"] == "Videojuegos") {
                PrincipalListView.DataSource = articulo.filtrarPorTipo("Videojuego");
                PrincipalListView.DataBind();
            } else if(Request.QueryString["param"] == "Consolas") {
                PrincipalListView.DataSource = articulo.filtrarPorTipo("Consola");
                PrincipalListView.DataBind();
            } else {
                PrincipalListView.DataSource = articulo.usuarioArticulo("");
                PrincipalListView.DataBind();
            }
           

            if (!IsPostBack) {
                string connectionString = ConfigurationManager.ConnectionStrings["Database"].ToString(); ;
                string tableName = "Publicidad";

                List<string> ids = new List<string>();

                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    connection.Open();

                    // Obtener todos los valores de la columna id_publi
                    SqlCommand selectCommand = new SqlCommand($"SELECT id_publi FROM {tableName}", connection);
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    while (reader.Read()) {
                        string id = reader["id_publi"].ToString();
                        ids.Add(id);
                    }

                    reader.Close();
                }

                if (ids.Count > 0) {
                    Random random = new Random();
                    int randomIndex = random.Next(0, ids.Count);
                    string randomId = ids[randomIndex];

                    // Utiliza el id aleatorio seleccionado para obtener el resto de los datos de la publicidad
                    using (SqlConnection connection = new SqlConnection(connectionString)) {
                        connection.Open();

                        SqlCommand selectCommand = new SqlCommand($"SELECT url_imagen, link_empresa FROM {tableName} WHERE id_publi = @id", connection);
                        selectCommand.Parameters.AddWithValue("@id", randomId);
                        SqlDataReader reader = selectCommand.ExecuteReader();

                        if (reader.Read()) {
                            string imageUrl = reader["url_imagen"].ToString();
                            string linkUrl = reader["link_empresa"].ToString();

                            // Asignar la URL de la imagen y la URL de redirección al control ImageButton
                            publicidad_imagen.ImageUrl = imageUrl;
                            publicidad_imagen.Attributes["onclick"] = $"window.location='{linkUrl}'";
                        }

                        reader.Close();
                    }
                }
            }

        }
    }
}