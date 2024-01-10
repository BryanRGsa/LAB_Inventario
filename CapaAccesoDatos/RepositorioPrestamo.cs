using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; // Importar el espacio de nombres para SQLite
using CapaLogicaNegocio;

namespace CapaAccesoDatos
{
    public class RepositorioPrestamo
    {
        private ConexionBaseDatos conexion;

        public RepositorioPrestamo(string rutaBD)
        {
            conexion = new ConexionBaseDatos(rutaBD);
        }

        public void RegistrarPrestamo(Prestamo prestamo)
        {
            using (SQLiteConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Prestamos (NombrePersona, MaterialPrestado, DNI, FechaPrestamo, CantidadPrestada) VALUES (@NombrePersona, @MaterialPrestado, @DNI, @FechaPrestamo, @CantidadPrestada)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar valores a los parámetros
                    cmd.Parameters.AddWithValue("@NombrePersona", prestamo.NombrePersona);
                    cmd.Parameters.AddWithValue("@MaterialPrestado", prestamo.MaterialPrestado);
                    cmd.Parameters.AddWithValue("@DNI", prestamo.DNI);
                    cmd.Parameters.AddWithValue("@FechaPrestamo", prestamo.FechaPrestamo);
                    cmd.Parameters.AddWithValue("@CantidadPrestada", prestamo.CantidadPrestada);

                    try
                    {
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("El préstamo se ha registrado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo registrar el préstamo.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al registrar el préstamo: " + ex.Message);
                        // Puedes manejar o registrar la excepción según sea necesario
                    }
                }
            }
        }
    }
}
