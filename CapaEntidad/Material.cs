using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Material
    {
        public int IDMATERIAL { get; set; }
        public string CODIGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string TIPO { get; set; }
        public char ESTADO { get; set; }
    }
}