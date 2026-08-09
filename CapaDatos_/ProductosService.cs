using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos_
{
    public class ProductosService
    {
        Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarProductos()
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SELECT * FROM PRODUCTOS";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            Conexion.Conectar().Close();
            return table;
        }

        public void InsertarProductos(string Producto, int Stock, int IdCategoria)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_AGREGAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Producto", Producto);
            cmd.Parameters.AddWithValue("@Stock",Stock);
            cmd.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ModificarProductos(string Producto, int Stock, int IdCategoria,int IdProducto)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ACTUALIZAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Producto", Producto);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EliminarProductos (int IdProducto)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ELIMINAR_USUARIOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

    }
}
