using CapaDatos_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CategoriaNegocio
    {
        private CategoriaService sr = new CategoriaService();

        public DataTable MostrarCategorias()
        {
            DataTable table = new DataTable();
            table = sr.MostrarCategorias();
            return table;
        }

        public void insertData(string Categoria)
        {
            sr.InsertarCategoria(Categoria);
        }

        public void updateData(int IdCategoria, string Categoria)
        {
            sr.ModificarCategoria(IdCategoria, Categoria);
        }

        public void deleteData(int Id)
        {
            sr.EliminarCategoria(Id);
        }
    }
}
