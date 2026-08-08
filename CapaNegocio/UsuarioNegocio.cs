using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        private UsuariosService us = new UsuariosService();

        public DataTable MostrarInformacion()
        {
            DataTable table = new DataTable();
            table = us.MostrarUsuarios();
            return table;
        }

        public void insertData(string nombreCompleto, string DUI, string Usuario, string Clave, string Telefono, int IdCargo, int Activo)
        {
            us.InsertarUsuarios(nombreCompleto, DUI, Usuario, Clave, Telefono, IdCargo, Activo);
        }

        public void updateData(int IdUsuario, string nombreCompleto, string DUI, string Usuario, string Clave, string Telefono, int IdCargo, int Activo)
        {
            us.ModificarUsuarios(IdUsuario,nombreCompleto,DUI, Usuario, Clave,Telefono, IdCargo,Activo);
        }

        public void deleteData(int Id)
        {
            us.EliminarUsuarios(Id);
        }
    }
}
