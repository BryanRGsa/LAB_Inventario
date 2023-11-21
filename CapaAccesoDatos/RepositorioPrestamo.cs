using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;
using CapaLogicaNegocio;

namespace CapaAccesoDatos
{
    public class RepositorioPrestamo
    {
        private ConexionBaseDatos conexion;

        public RepositorioPrestamo()
        {
            conexion = new ConexionBaseDatos();
        }

        // Método para manejar operaciones de préstamo en la base de datos
        // Por ejemplo:
        public void RegistrarPrestamo(Prestamo prestamo)
        {
            // Lógica para registrar un préstamo en la base de datos utilizando la conexión
            // Ejemplo:
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                // Insertar datos en la tabla de préstamos
                // ...
            }
        }

        // Otros métodos para operaciones con préstamos
    }
}
