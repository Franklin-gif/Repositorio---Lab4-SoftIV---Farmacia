using Npgsql;
using System;
using System.Data;

namespace Lab4_Farmacia
{
    public class ConexionBd
    {//deben cambiar solo la contraseña que pusieron en su bd y el nombre si tienen uno diferente 
        private static string cadena = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=Farmacia";
        //private static string cadena = "Host=localhost;Port=5432;Username=postgres;Password=HiLlar12345;Database=Farmacia";
        public static NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection conexion = new NpgsqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
