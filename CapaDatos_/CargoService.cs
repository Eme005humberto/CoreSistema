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
    public class CargoService
    {
        Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();


        public DataTable MostrarCargos()
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SELECT * FROM CARGO";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            Conexion.Conectar().Close();
            return table;
        }

        public void InsertarCargo(string Cargo) { 
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_AGREGAR_CARGO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ModificarCargo(int IdCargo, string Cargo)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ACTUALIZAR_CARGO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@IdCargo", IdCargo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EliminarCargo(int IdCargo)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ELIMINAR_CARGO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCargo", IdCargo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
