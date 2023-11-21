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

        public RepositorioMaterial()
        {
            conexion = new ConexionBaseDatos();
        }

        // Aquí podrías tener métodos para operaciones con materiales en la base de datos
        // Por ejemplo:
        public List<Material> ObtenerMateriales()
        {
            List<Material> materiales = new List<Material>();
            // Lógica para obtener materiales desde la base de datos utilizando la conexión
            // Ejemplo:
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                // Ejecutar consulta SQL y obtener datos
                // ...
            }
            return materiales;
        }

        // Otros métodos para insertar, actualizar, eliminar, etc.
    }
}
