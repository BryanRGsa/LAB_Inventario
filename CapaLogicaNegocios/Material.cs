using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Material
    {
        // Declara la propiedad como nullable si es apropiado (añade ? al tipo de dato)
        public string? Nombre { get; set; } // Agrega ? para permitir valores nulos

        public int NumeroGabinete { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Cantidad { get; set; }

        // Constructor
        public Material()
        {
            // Asigna un valor predeterminado a la propiedad si no debe ser NULL
            Nombre = string.Empty; // O cualquier otro valor predeterminado
        }
    }
}
