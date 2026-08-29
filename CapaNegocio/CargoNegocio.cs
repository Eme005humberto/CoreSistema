using CapaDatos_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CargoNegocio
    {
        private CargoService sr = new CargoService();

        public DataTable MostrarCargos()
        {
            DataTable table = new DataTable();
            table = sr.MostrarCargos();
            return table;
        }

        public void insertData(string Cargo)
        {
            sr.InsertarCargo(Cargo);
        }

        public void updateData(int IdCargo,string Cargo)
        {
            sr.ModificarCargo(IdCargo,Cargo);
        }

        public void deleteData(int Id)
        {
            sr.EliminarCargo(Id);
        }

        public void CargarCargos()
        {
            sr.ObtenerCategorias();
        }
    }
}
