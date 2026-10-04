using CapaDatos;
using CapaDatos_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CompraNegocio
    {
        private CompraService cs = new CompraService();

        public void RealizarCompra(COMPRAS compra)
        {
            cs.RealizarCompra(compra);
        }
    }
}
