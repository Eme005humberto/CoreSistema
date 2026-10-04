using CapaDatos;
using CapaDatos_;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable ReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            return ventaService.ReporteVentas(fechaInicio, fechaFin);
        }
    }
}
