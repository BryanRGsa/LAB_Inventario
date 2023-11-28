using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System;

namespace CapaAccesoDatos
{
    public class ConexionBaseDatos
    {
        private string rutaBaseDatos;

        public ConexionBaseDatos(string rutaBD)
        {
            rutaBaseDatos = rutaBD;
        }

        public SQLiteConnection ObtenerConexion()
        {
            string connectionString = $"Data Source={rutaBaseDatos};Version=3;";
            return new SQLiteConnection(connectionString);
        }
    }
}
