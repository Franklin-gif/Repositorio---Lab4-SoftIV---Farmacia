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
    internal class Farmacia
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
            using (var conn = ConexionBd.ObtenerConexion())
            using (var cmd = new NpgsqlCommand("SELECT * FROM sp_ver_inventario()", conn))
            using (var da = new NpgsqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                var dv = new DataView(dt) { RowFilter = "cantidad > 0" };

                return dv.ToTable();

            }
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

        public static void ReabastecerMedicamento(int id, int cantidadAgregar)
        {
            using (var conn = ConexionBd.ObtenerConexion())
            using (var cmd = new NpgsqlCommand("CALL sp_reabastecer_medicamento(@p_id, @cant_agregar)", conn))
            {
                cmd.Parameters.AddWithValue("p_id", id);
                cmd.Parameters.AddWithValue("cant_agregar", cantidadAgregar);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarMedicamento(int id)
        {
            using (var conn = ConexionBd.ObtenerConexion())
            using (var cmd = new NpgsqlCommand("CALL sp_eliminar_medicamento(@p_id)", conn))
            {
                cmd.Parameters.AddWithValue("p_id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable TraerPedidos()
        {
            DataTable dtPedidos = new DataTable();

            using (var conn = ConexionBd.ObtenerConexion())
            {

                using (var cmd = new NpgsqlCommand("SELECT * FROM sp_consultar_pedidos()", conn))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dtPedidos);
                }
            }

            return dtPedidos;
        }

        public static void RegistrarPedido(int idCliente, int idMedicamento, int cantidad)
        {
            using (var conn = ConexionBd.ObtenerConexion())
            using (var cmd = new NpgsqlCommand("CALL sp_registrar_pedido_cli(@p_id_cliente, @p_id_medicamento, @p_cantidad);", conn))
            {
                cmd.Parameters.AddWithValue("p_id_cliente", idCliente);
                cmd.Parameters.AddWithValue("p_id_medicamento", idMedicamento);
                cmd.Parameters.AddWithValue("p_cantidad", cantidad);

                cmd.ExecuteNonQuery();
            }

        }
    }


}


