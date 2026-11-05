using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
namespace CapaDatos
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            //Variables dinamicas de configuracion de servidor de base de datos
            string servidor = ConfigurationManager.AppSettings["Servidor"];
            string baseDatos = ConfigurationManager.AppSettings["BaseDatos"];

            string cadena = $"Server={servidor};Database={baseDatos};Trusted_Connection=True;TrustServerCertificate=True;";//Cadena de Conexion
            SqlConnection conexion = new SqlConnection(cadena); //Inicializamos la conexion
            try
            {
                if (conexion.State == ConnectionState.Closed) //Verificamos que la conexion este cerrada
                {
                    conexion.Open(); //Abrimos la conexion
                    Console.WriteLine("La conexion ya esta abierta.");
                }
                else
                {
                    conexion.Close(); //Cerramos la conexion
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
            return conexion; //Retornamos la conexion
        }
    }
}
