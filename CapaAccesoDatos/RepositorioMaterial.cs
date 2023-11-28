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
                        Material material = new Material
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            Nombre = dataReader["Nombre"].ToString(),
                            // Agregar otras propiedades aquí...
                        };
                        materiales.Add(material);
                    }
                }
            }

            return materiales;
        }

        // Implementa métodos para agregar, actualizar, eliminar materiales, etc.
        // ...




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
                cmd.Parameters.AddWithValue("@FechaRegistro", material.FechaRegistro);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public bool ActualizarMaterial(Material material)
        {
            using (SQLiteConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Materiales SET Nombre = @Nombre, Cantidad = @Cantidad, Gabinete = @Gabinete, FechaRegistro = @FechaRegistro WHERE Id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", material.Nombre);
                cmd.Parameters.AddWithValue("@Cantidad", material.Cantidad);
                cmd.Parameters.AddWithValue("@Gabinete", material.Gabinete);
                cmd.Parameters.AddWithValue("@FechaRegistro", material.FechaRegistro);
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