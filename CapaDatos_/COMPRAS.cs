using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class COMPRAS
    {
        public int IdCompras { get; set; }
        public PRODUCTOS oProductos { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public int IdProveedor { get; set; }
        public DateTime FechaCompra { get; set; }
    }
}
