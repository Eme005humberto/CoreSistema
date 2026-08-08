using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VENTAS
    {
        public int IdVenta { get; set; }
        public PRODUCTOS oProductos { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
