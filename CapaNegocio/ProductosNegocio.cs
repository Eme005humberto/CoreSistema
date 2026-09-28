using CapaDatos_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ProductosNegocio
    {
        private ProductosService sr = new ProductosService();

        public DataTable MostrarInformacion()
        {
            DataTable table = new DataTable();
            table = sr.MostrarProductos();
            return table;
        }

        public DataTable MostrarCategorias()
        {
            DataTable tb = new DataTable();
            tb = sr.MostrarCategorias();
            return tb;
        }

        public void insertData(string Producto, int Stock, int IdCategoria, decimal Precio)
        {
            sr.InsertarProductos(Producto, Stock, IdCategoria, Precio);
        }

        public void updateData(string Producto, int Stock, int IdCategoria, decimal Precio,int IdProducto)
        {
            sr.ModificarProductos(Producto,Stock,IdCategoria,Precio,IdProducto);
        }

        public void deleteData(int Id)
        {
            sr.EliminarProductos(Id);
        }
    }
}
