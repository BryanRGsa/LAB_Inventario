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
        Material ObtenerMaterialPorId(int id);
        void AgregarMaterial(Material material);
        void ActualizarMaterial(Material material);
        void EliminarMaterial(int id);
        // Otros métodos de la interfaz para operaciones con materiales
    }
}
