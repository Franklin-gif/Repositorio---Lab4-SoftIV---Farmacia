using Npgsql;
using System;
using System.Data;

namespace Lab4_Farmacia
{
    public class ConexionBd
    {
        private static string cadena = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=Farmacia";

        public static NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection conexion = new NpgsqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
