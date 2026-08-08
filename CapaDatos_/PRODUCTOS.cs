using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PRODUCTOS
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public int Stock { get; set; }
        public CATEGORIA oCategoria { get; set; }
        public decimal Precio { get; set; }
    }
}
