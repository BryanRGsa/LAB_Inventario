using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Prestamo
    {
        public string? NombrePersona { get; set; } // Marcar como nullable si puede aceptar valores NULL
        public string? MaterialPrestado { get; set; } // Marcar como nullable si puede aceptar valores NULL
        public string? DNI { get; set; } // Marcar como nullable si puede aceptar valores NULL

        public DateTime FechaPrestamo { get; set; }
        public int CantidadPrestada { get; set; }

        // Constructor
        public Prestamo()
        {
            // Asigna un valor predeterminado o inicializa según sea necesario
            NombrePersona = string.Empty; // O cualquier otro valor predeterminado
            MaterialPrestado = string.Empty; // O cualquier otro valor predeterminado
            DNI = string.Empty; // O cualquier otro valor predeterminado
        }
    }
}
