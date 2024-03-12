using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace INVENTARIOUPI
{
    public partial class Bodega : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                LlenarGrid();
            }
        }

        private void LlenarGrid()
        {
            SqlConnection con = null;
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                con = new SqlConnection(constr);
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Bodega", con))
                {
                    con.Open();

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" INSERT INTO bodega VALUES('" + tdescripcion.Text + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }

        protected void beliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = null;
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

                conexion = new SqlConnection(connectionString);
                conexion.Open();

                string query = "DELETE FROM bodega WHERE codigoBodega = @CodigoBodega";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@CodigoBodega", tcodigo.Text);
                    comando.ExecuteNonQuery();
                }

                // Llama al método LlenarGrid() después de eliminar el registro.
                LlenarGrid();
            }
            catch (Exception ex)
            {
                // Maneja la excepción aquí
            }
            finally
            {
                // Asegúrate de cerrar la conexión en el bloque finally para garantizar su cierre adecuado.
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
        }
    }
}