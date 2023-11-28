using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;
using CapaLogicaNegocio;
using System.Data.SQLite;



SQLiteConnection conexion = new SQLiteConnection("Data Source=ruta_base_datos.db;Version=3;");

namespace CapaAccesoDatos
{
    public class RepositorioMaterialDanado
    {
        private ConexionBaseDatos conexion;

        public RepositorioMaterialDanado(string rutaBaseDatos)
        {
            conexion = new ConexionBaseDatos(rutaBaseDatos); // Proporciona la ruta de la base de datos aquí
        }

        // Método para manejar operaciones de material dañado en la base de datos
        // Por ejemplo:
        public void RegistrarMaterialDanado(MaterialDanado materialDanado)
        {
            // Lógica para registrar material dañado en la base de datos utilizando la conexión
            // Ejemplo:
            SQLiteConnection conexion = new SQLiteConnection("Data Source=ruta_base_datos.db;Version=3;");
            {
                // Insertar datos en la tabla de material dañado
                // ...
            }
        }

        // Otros métodos para operaciones con material dañado
    }
}
