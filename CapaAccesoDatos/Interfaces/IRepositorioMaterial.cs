using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CapaLogicaNegocio;

namespace CapaAccesoDatos.Interfaces
{
    public interface IRepositorioMaterial
    {
        List<Material> ObtenerMateriales();
        // Otros métodos de la interfaz para operaciones con materiales
    }
}
