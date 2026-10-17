using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_
{
    public class CategoriaService
    {
        Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable table = new DataTable();
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

        public void InsertarCategoria(string Categoria)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_AGREGAR_CATEGORIA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Categoria", Categoria);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ModificarCategoria(int IdCategoria, string Categoria)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ACTUALIZAR_CATEGORIA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Categoria", Categoria);
            cmd.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EliminarCategoria(int IdCategoria)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ELIMINAR_CATEGORIA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCategoria", IdCategoria);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
