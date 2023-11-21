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
    public class RepositorioMaterialDanado
    {
        private ConexionBaseDatos conexion;

        public RepositorioMaterialDanado()
        {
            conexion = new ConexionBaseDatos();
        }

        // Método para manejar operaciones de material dañado en la base de datos
        // Por ejemplo:
        public void RegistrarMaterialDanado(MaterialDanado materialDanado)
        {
            // Lógica para registrar material dañado en la base de datos utilizando la conexión
            // Ejemplo:
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                // Insertar datos en la tabla de material dañado
                // ...
            }
        }

        // Otros métodos para operaciones con material dañado
    }
}
