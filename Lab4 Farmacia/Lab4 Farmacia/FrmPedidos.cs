using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Lab4_Farmacia
{
    public partial class FrmPedidos : Form
    {
        private int idCliente = 1; // ID del cliente actual, se puede cambiar según sesión

        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CargarPedidos();
        }

        // ==========================================
        // CARGAR PEDIDOS DEL CLIENTE EN EL DATAGRID
        // ==========================================
        private void CargarPedidos()
        {
            try
            {
                using (var con = ConexionBd.ObtenerConexion())
                {
                    string sql = @"
                        SELECT 
                            p.id AS 'ID Pedido',
                            u.usuario AS Cliente,
                            m.nombre AS Medicamento,
                            dp.cantidad AS Cantidad,
                            dp.subtotal AS Subtotal,
                            p.fecha AS Fecha
                        FROM pedidos p
                        INNER JOIN usuarios u ON p.id_cliente = u.id
                        INNER JOIN detalle_pedido dp ON dp.id_pedido = p.id
                        INNER JOIN medicamentos m ON dp.id_medicamento = m.id
                        WHERE p.id_cliente = @cli
                        ORDER BY p.fecha DESC;
                    ";

                    using (var cmd = new NpgsqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@cli", idCliente);
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvPedidos.DataSource = dt;

                        FormatearDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }

        // ==========================================
        // FORMATEAR DATAGRIDVIEW
        // ==========================================
        private void FormatearDataGrid()
        {
            dgvPedidos.ClearSelection();
            dgvPedidos.ReadOnly = true;
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Opcional: formato de columnas
            if (dgvPedidos.Columns.Contains("Subtotal"))
                dgvPedidos.Columns["Subtotal"].DefaultCellStyle.Format = "C2"; // Formato moneda

            if (dgvPedidos.Columns.Contains("Fecha"))
                dgvPedidos.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes agregar acciones si quieres, por ejemplo, mostrar detalles del pedido
        }
    }
}
