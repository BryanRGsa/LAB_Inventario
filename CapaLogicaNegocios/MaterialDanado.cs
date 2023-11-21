using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class MaterialDanado
    {
        public string? Causante { get; set; } // Marcar como nullable si puede aceptar valores NULL

        public DateTime FechaIncidente { get; set; }
        public int CantidadDanada { get; set; }

        // Constructor
        public MaterialDanado()
        {
            // Asigna un valor predeterminado si es necesario
            Causante = string.Empty; // O cualquier otro valor predeterminado
        }
    }
}
