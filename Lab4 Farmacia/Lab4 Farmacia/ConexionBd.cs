using Npgsql;
using System.Data;

public class ConexionBd
{
    private string cadena = "Host=localhost;Port=5432;Database=Farmacia;Username=postgres;Password=HiLlarY2013;";

    public NpgsqlConnection Conectar()
    {
        NpgsqlConnection cn = new NpgsqlConnection(cadena);
        cn.Open();
        return cn;
    }
}
