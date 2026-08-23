using CapaDatos;
using CapaDatos_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class VentaNegocio
    {
        private VentaService ventaService = new VentaService();

        public void RealizarVenta(VENTAS venta)
        {
            ventaService.RealizarVenta(venta);
        }
    }
}
