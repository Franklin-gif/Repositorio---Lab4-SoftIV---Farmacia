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

        private void frmPedidosCli_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dgvInv.CellClick += dgvMedicamentos_CellClick;  

            CargarMedicamentos();                            
            dgvInv.ClearSelection();                         
            dgvInv.CurrentCell = null;

            txtNom.ReadOnly = true;
        }

        private void CargarPedidosCliente(int idCliente)
        {
            dgvPedidosCli.Rows.Clear();

            try
            {
                using (var con = ConexionBd.ObtenerConexion())
                using (var cmd = new NpgsqlCommand(
                    "SELECT * FROM sp_ver_pedidos_cliente(@id);", con))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.CreateCells(dgvPedidosCli);

                            fila.Cells[dgvPedidosCli.Columns["IDPedido"].Index].Value = dr["id_pedido"];
                            fila.Cells[dgvPedidosCli.Columns["Medicamento"].Index].Value = dr["nombre_medicamento"];
                            fila.Cells[dgvPedidosCli.Columns["Cantidad"].Index].Value = dr["cantidad"];
                            fila.Cells[dgvPedidosCli.Columns["Total"].Index].Value = dr["subtotal"];
                            fila.Cells[dgvPedidosCli.Columns["Fecha"].Index].Value = dr["fecha"];

                            dgvPedidosCli.Rows.Add(fila);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos del cliente: " + ex.Message);
            }
        }


        private void CargarMedicamentos()
        {
            try
            {
                var dt = Farmacia.TraerMedicamentos();

                foreach (DataRow dr in dt.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvInv);

                    row.Cells[dgvInv.Columns["ID"].Index].Value = dr["id"];
                    row.Cells[dgvInv.Columns["nombre"].Index].Value = dr["nombre"];
                    row.Cells[dgvInv.Columns["descripcion"].Index].Value = dr["descripcion"];
                    row.Cells[dgvInv.Columns["Cantidad"].Index].Value = dr["cantidad"];
                    row.Cells[dgvInv.Columns["Precio"].Index].Value = dr["precio"];

                    byte[] bytes = dr["imagen"] as byte[];
                    row.Cells[dgvInv.Columns["Imagen"].Index].Value = bytes != null ? Image.FromStream(new MemoryStream(bytes)) : null;

                    dgvInv.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message);
            }
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvInv.Rows[e.RowIndex];
                    string nombre = fila.Cells["nombre"].Value.ToString();
                    txtNom.Text = nombre;
                    nudCant.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo obtener el nombre del medicamento.");
            }
        }

        private int ObtenerIdPorNombre(string nombre)
        {
            try
            {
                using (var con = ConexionBd.ObtenerConexion())
                using (var cmd = new NpgsqlCommand(
                    "SELECT id FROM medicamentos WHERE LOWER(nombre) = LOWER(@n);", con))
                {
                    cmd.Parameters.AddWithValue("@n", nombre.Trim());
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buscando medicamento: " + ex.Message);
            }

            return -1;
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
                {
            string nombreMed = txtNom.Text.Trim();

            if (string.IsNullOrEmpty(nombreMed))
            {
                MessageBox.Show("Seleccione un medicamento.");
                return;
            }

            int idMedicamento = ObtenerIdPorNombre(nombreMed);

            if (idMedicamento == -1)
            {
                MessageBox.Show("No existe un medicamento con ese nombre.");
                return;
            }

            int cantidad = (int)nudCant.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            int cli = 1;

            try
            {
                using (var con = ConexionBd.ObtenerConexion())
                using (var cmd = new NpgsqlCommand(
                    "CALL sp_registrar_pedido_cli(@p_id_cliente, @p_id_medicamento, @p_cantidad);",
                    con))
                {

                    cmd.Parameters.AddWithValue("@p_id_cliente", cli);
                    cmd.Parameters.AddWithValue("@p_id_medicamento", idMedicamento);
                    cmd.Parameters.AddWithValue("@p_cantidad", cantidad);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Pedido registrado correctamente.");
                CargarMedicamentos();
                txtNom.Clear();
                nudCant.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pedido: " + ex.Message);
            }
        }
    }
}
