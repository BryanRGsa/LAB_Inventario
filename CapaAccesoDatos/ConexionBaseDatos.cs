using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ConexionBaseDatos
    {
        private string cadenaConexion = "TuCadenaDeConexion"; // Reemplaza con tu cadena de conexión

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
            return conexion;
        }
    }
}
