using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IDUSUARIO { get; set; }
        public string TIPO_DOC { get; set; }
        public string NRO_DOC { get; set; }
        public string NOMBRE_APELLIDO { get; set; }
        public string USUARIO { get; set; }
        public string CLAVE { get; set; }
    }
}