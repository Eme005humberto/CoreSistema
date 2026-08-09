using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class UsuariosService
    {
        Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand cmd = new SqlCommand();


        public DataTable MostrarUsuarios()
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SELECT * FROM USUARIOS";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            table.Load(leer);
            Conexion.Conectar().Close();
            return table;
        }

        public void InsertarUsuarios(string nombreCompleto, string DUI, string Usuario, string Clave, string Telefono, int IdCargo, int Activo)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_AGREGAR_USUARIOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
            cmd.Parameters.AddWithValue("@DUI", DUI);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@IdCargo", IdCargo);
            cmd.Parameters.AddWithValue("@Activo", Activo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void ModificarUsuarios(int IdUsuario, string nombreCompleto, string DUI, string Usuario, string Clave, string Telefono, int IdCargo, int Activo)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ACTUALIZAR_USUARIOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
            cmd.Parameters.AddWithValue("@DUI", DUI);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@IdCargo", IdCargo);
            cmd.Parameters.AddWithValue("@Activo", Activo);
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void EliminarUsuarios(int IdUsuario)
        {
            cmd.Connection = Conexion.Conectar();
            cmd.CommandText = "SP_ELIMINAR_USUARIOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
