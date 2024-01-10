using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion; // Ajusta el espacio de nombres según tu proyecto

namespace CapaPresentacion
{
    internal static class Program
    {
        // Instancia del RepositorioMaterial
        private static string rutaBaseDatos = @"C:\Users\DELL\Documents\LAB_Inventario\HessenDB.db";
        private static RepositorioMaterial repositorio = new RepositorioMaterial(rutaBaseDatos);

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uso del repositorio, por ejemplo:
            List<Material> materiales = repositorio.ObtenerMateriales();

            // Puedes realizar más operaciones con los materiales obtenidos
            // o pasar la información a tu formulario de login, según sea necesario.

            Application.Run(new Login());
        }
    }
}

