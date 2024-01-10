using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using CapaLogicaNegocio;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CapaAccesoDatos
{
    public class RepositorioMaterial
    {
        private ConexionBaseDatos conexion;

        public RepositorioMaterial(string rutaBD)
        {
            conexion = new ConexionBaseDatos(rutaBD);
        }

        public List<Material> ObtenerMateriales()
        {
            List<Material> materiales = new List<Material>();

            using (SQLiteConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Materiales";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Material material = new Material();

                        // Verifica si los valores obtenidos de la base de datos son nulos antes de asignarlos
                        material.Id = dataReader["Id"] != DBNull.Value ? Convert.ToInt32(dataReader["Id"]) : 0;
                        material.Nombre = dataReader["Nombre"] != DBNull.Value ? dataReader["Nombre"].ToString() : string.Empty;
                        material.Cantidad = dataReader["Cantidad"] != DBNull.Value ? Convert.ToInt32(dataReader["Cantidad"]) : 0;
                        material.Gabinete = dataReader["Gabinete"] != DBNull.Value ? dataReader["Gabinete"].ToString() : string.Empty;

                        materiales.Add(material);
                    }
                }
            }

            return materiales;
        }

        public bool AgregarMaterial(Material material)
        {
            using (SQLiteConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Materiales (Nombre, Cantidad, Gabinete, FechaRegistro) VALUES (@Nombre, @Cantidad, @Gabinete, @FechaRegistro)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", material.Nombre);
                cmd.Parameters.AddWithValue("@Cantidad", material.Cantidad);
                cmd.Parameters.AddWithValue("@Gabinete", material.Gabinete);
                cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now); // Fecha actual como ejemplo

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public bool ActualizarMaterial(Material material)
        {
            using (SQLiteConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Materiales SET Nombre = @Nombre, Cantidad = @Cantidad, Gabinete = @Gabinete WHERE Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", material.Nombre);
                cmd.Parameters.AddWithValue("@Cantidad", material.Cantidad);
                cmd.Parameters.AddWithValue("@Gabinete", material.Gabinete);
                cmd.Parameters.AddWithValue("@Id", material.Id);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public bool EliminarMaterial(int materialId)
        {
            using (SQLiteConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Materiales WHERE Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", materialId);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }
    }
}

