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

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarCategorias()
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SELECT * FROM CATEGORIA";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(leer);
            cmd.Connection.Close();

            return tabla;
        }

        public DataTable MostrarProductos()
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SELECT * FROM PRODUCTOS WHERE Activo = 1";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(leer);
            cmd.Connection.Close();

            return tabla;
        }

        public void InsertarProductos(string Producto, int Stock, int IdCategoria,decimal Precio)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_AGREGAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Producto", Producto);
            cmd.Parameters.AddWithValue("@Stock",Stock);
            cmd.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ModificarProductos(string Producto, int Stock, int IdCategoria, decimal Precio, int IdProducto)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ACTUALIZAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Producto", Producto);
            cmd.Parameters.AddWithValue("@Stock", Stock);
            cmd.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EliminarProductos (int IdProducto)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ELIMINAR_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

    }
}
