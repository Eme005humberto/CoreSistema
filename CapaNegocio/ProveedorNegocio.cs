using CapaDatos_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ProveedorNegocio
    {
        private ProveedorService pr = new ProveedorService();
        public DataTable MostrarProveedor()
        {
            DataTable table = new DataTable();
            table = pr.MostrarProveedor();
            return table;

        }
        public void insertData(string Proveedor,string Telefono)
        {
            pr.InsertarProveedor(Proveedor, Telefono);
        }

        public void UpdateData(string Proveedor , string Telefono, int IdProveedor)
        {
            pr.ModificarProveedor(Proveedor, Telefono, IdProveedor);
        }

        public void DeleteData(int IdProveedor)
        {
            pr.EliminarProveedor(IdProveedor);
        }
    }
}
