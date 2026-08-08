using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class USUARIO
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string DUI { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Telefono { get; set; }
        public CARGO oCargo { get; set; }
        public int Activo { get; set; }
    }
}
