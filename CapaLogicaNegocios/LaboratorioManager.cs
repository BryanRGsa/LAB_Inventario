using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class LaboratorioManager : IInventarioManager
    {
        public bool ValidarDatosEntrada(Material material)
        {
            // Lógica para validar los datos de entrada del material
            // Retorna true si los datos son válidos, de lo contrario, false
            bool datosValidos = false;

            // Implementa la lógica para validar los datos aquí y actualiza datosValidos según corresponda

            return datosValidos; // Asegúrate de devolver un valor en todos los posibles caminos de ejecución
        }

        public int CalcularExistencias(int idMaterial)
        {
            // Lógica para calcular las existencias del material con el ID proporcionado
            // Retorna la cantidad disponible del material en el inventario

            int cantidadDisponible = 0;

            // Implementa la lógica para calcular la cantidad disponible del material aquí y actualiza cantidadDisponible

            return cantidadDisponible; // Asegúrate de devolver un valor en todos los posibles caminos de ejecución
        }


        public void ControlarMovimientoInventario(Prestamo prestamo)
        {
            // Lógica para controlar el movimiento del inventario al realizar un préstamo
            // Actualiza las existencias o realiza las acciones necesarias en el inventario
        }

        // Otros métodos y lógica relacionados con la gestión del inventario
    }

    public interface IInventarioManager
    {
        bool ValidarDatosEntrada(Material material);
        int CalcularExistencias(int idMaterial);
        void ControlarMovimientoInventario(Prestamo prestamo);
        // Otros métodos relacionados con la gestión del inventario
    }
}