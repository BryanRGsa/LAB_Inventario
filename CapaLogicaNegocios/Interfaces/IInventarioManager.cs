using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogicaNegocio;

namespace CapaLogicaNegocios.Interfaces
{
    public interface IInventarioManager
    {
        bool ValidarDatosEntrada(Material material);
        int CalcularExistencias(int idMaterial);
        void ControlarMovimientoInventario(Prestamo prestamo);
        // Otros métodos relacionados con la gestión del inventario
    }
}
