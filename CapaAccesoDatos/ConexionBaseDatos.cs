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
        private string rutaBaseDatos;

        public ConexionBaseDatos(string rutaBD)
        {
            rutaBaseDatos = rutaBD;
        }

        public SQLiteConnection ObtenerConexion()
        {
            SQLiteConnection conexion = new SQLiteConnection($"Data Source={rutaBaseDatos};Version=3;");
            return conexion;
        }
    }
}
