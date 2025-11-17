using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Lab4_Farmacia
{
    public partial class frmPedidosCli : Form
    {
        public frmPedidosCli()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------------
        // Cargar medicamentos automáticamente al abrir el formulario
        // ---------------------------------------------------------
        private void frmPedidosCli_Load(object sender, EventArgs e)
        {
            CargarMedicamentos();
        }

        // ---------------------------------------------------------
        // FUNCIÓN: Cargar los medicamentos al DataGridView
        // ---------------------------------------------------------
        private void CargarMedicamentos()
        {
            using (var con = ConexionBd.ObtenerConexion())
            {
                string sql = "SELECT id, nombre, descripcion, cantidad, precio FROM medicamentos";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMedicamentos.DataSource = dt;
            }
        }

        // ---------------------------------------------------------
        // BOTÓN: Actualizar lista de medicamentos
        // ---------------------------------------------------------
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMedicamentos();
            MessageBox.Show("Lista de medicamentos actualizada.");
        }

        // ---------------------------------------------------------
        // BOTÓN: Confirmar pedido
        // ---------------------------------------------------------
        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un medicamento.");
                return;
            }

            int idCliente = 1; // ← Cambiar por el cliente que inició sesión
            int idMedicamento = Convert.ToInt32(dgvMedicamentos.SelectedRows[0].Cells["id"].Value);
            int cantidad = (int)nudCant.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            decimal precio = Convert.ToDecimal(dgvMedicamentos.SelectedRows[0].Cells["precio"].Value);
            decimal subtotal = cantidad * precio;

            using (var con = ConexionBd.ObtenerConexion())
            using (var trans = con.BeginTransaction())
            {
                try
                {
                    // -----------------------------------
                    // 1) Insertar el pedido
                    // -----------------------------------
                    string sqlPedido = "INSERT INTO pedidos(id_cliente) VALUES(@cli) RETURNING id";
                    int idPedido = 0;

                    using (var cmd = new NpgsqlCommand(sqlPedido, con, trans))
                    {
                        cmd.Parameters.AddWithValue("@cli", idCliente);
                        idPedido = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // -----------------------------------
                    // 2) Insertar detalle del pedido
                    // -----------------------------------
                    string sqlDetalle =
                        @"INSERT INTO detalle_pedido(id_pedido, id_medicamento, cantidad, subtotal)
                          VALUES(@p, @m, @c, @s)";

                    using (var cmd = new NpgsqlCommand(sqlDetalle, con, trans))
                    {
                        cmd.Parameters.AddWithValue("@p", idPedido);
                        cmd.Parameters.AddWithValue("@m", idMedicamento);
                        cmd.Parameters.AddWithValue("@c", cantidad);
                        cmd.Parameters.AddWithValue("@s", subtotal);
                        cmd.ExecuteNonQuery();
                    }

                    // -----------------------------------
                    // 3) Descontar inventario
                    // -----------------------------------
                    string sqlUpdate =
                        @"UPDATE medicamentos
                          SET cantidad = cantidad - @cant
                          WHERE id = @id AND cantidad >= @cant";

                    using (var cmd = new NpgsqlCommand(sqlUpdate, con, trans))
                    {
                        cmd.Parameters.AddWithValue("@cant", cantidad);
                        cmd.Parameters.AddWithValue("@id", idMedicamento);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                            throw new Exception("Inventario insuficiente.");
                    }

                    // -----------------------------------
                    // 4) Confirmar transacción
                    // -----------------------------------
                    trans.Commit();
                    MessageBox.Show("Pedido registrado exitosamente.");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al registrar pedido: " + ex.Message);
                }
            }

            // Recargar inventario actualizado
            CargarMedicamentos();
        }
    }
}
