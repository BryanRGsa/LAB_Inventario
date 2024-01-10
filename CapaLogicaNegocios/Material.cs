using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Material
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Gabinete { get; set; }

        public Material()
        {
            // Asignar valores predeterminados para evitar valores nulos
            Id = 0;
            Nombre = string.Empty;
            Cantidad = 0;
            Gabinete = string.Empty;
        }

        public Material(int id, string nombre, int cantidad, string gabinete)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Gabinete = gabinete;
        }
    }
}
