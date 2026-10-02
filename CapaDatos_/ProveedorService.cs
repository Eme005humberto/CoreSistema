using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos_
{
    public class ProveedorService
    {
        Conexion conexion = new Conexion();

        SqlDataReader leer;

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarProveedor()
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SELECT * FROM PROVEEDOR";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(leer);
            cmd.Connection.Close();

            return tabla;
        }

        public void InsertarProveedor(string Proveedor,string Telefono)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_AGREGAR_PROVEEDOR";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Proveedor", Proveedor);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ModificarProveedor(string Proveedor, string Telefono,int IdProveedor)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_MODIFICAR_PROVEEDOR";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Proveedor", Proveedor);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EliminarProveedor(int IdProveedor)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ELIMINAR_PROVEEDOR";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProveedor", IdProveedor);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
