using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Farmacia
{
    internal class Admin
    {
        public static byte[] ConvertirImagenABytes(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static void AgregarMedicamento(string nombre, string descripcion, int cantidad, decimal precio, byte[] imagen)
        {
            using (var conn = ConexionBd.ObtenerConexion())
            using (var cmd = new NpgsqlCommand("CALL sp_agregar_medicamento(@p_nom, @p_desc, @p_img, @cant, @precio)", conn))
            {
                cmd.Parameters.AddWithValue("p_nom", nombre);
                cmd.Parameters.AddWithValue("p_desc", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion);
                cmd.Parameters.AddWithValue("cant", cantidad);
                cmd.Parameters.AddWithValue("precio", precio);

                var pImg = new NpgsqlParameter("p_img", NpgsqlDbType.Bytea) { Value = imagen ?? (object)DBNull.Value };
                cmd.Parameters.Add(pImg);

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable TraerMedicamentos()
        {
            DataTable dt = new DataTable();
            using (var conn = ConexionBd.ObtenerConexion())
            using (var da = new NpgsqlDataAdapter("SELECT id, nombre, descripcion, imagen, cantidad, precio FROM medicamentos ORDER BY id ASC", conn))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public static void ModificarMedicamento(int id, string nombre, string descripcion, int cantidad, decimal precio, byte[] imagen)
        {

            using (var conn = ConexionBd.ObtenerConexion())
            using (var cmd = new NpgsqlCommand("CALL sp_modificar_medicamento(@p_id, @p_nom, @p_desc, @p_img, @cant, @p_precio)", conn))
            {
                cmd.Parameters.AddWithValue("p_id", id);
                cmd.Parameters.AddWithValue("p_nom", nombre);
                cmd.Parameters.AddWithValue("p_desc", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion);
                cmd.Parameters.AddWithValue("cant", cantidad);
                cmd.Parameters.AddWithValue("p_precio", precio);

                var pImg = new NpgsqlParameter("p_img", NpgsqlTypes.NpgsqlDbType.Bytea)
                {
                    Value = imagen ?? (object)DBNull.Value
                };
                cmd.Parameters.Add(pImg);

                cmd.ExecuteNonQuery();
            }

        }


    }
}
