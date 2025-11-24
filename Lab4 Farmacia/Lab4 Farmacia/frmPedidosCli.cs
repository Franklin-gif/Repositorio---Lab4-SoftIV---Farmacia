using Npgsql;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static Lab4_Farmacia.Farmacia;

namespace Lab4_Farmacia
{
    public partial class frmPedidosCli : Form
    {
        private int idCliente;
        private string usuarioCliente;
        public frmPedidosCli(int idCliente, string usuarioCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            this.usuarioCliente = usuarioCliente;
        }

        private void frmPedidosCli_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dgvInv.CellClick += dgvMedicamentos_CellClick;  

            CargarMedicamentos();
            CargarPedidosCliente(usuarioCliente);

            dgvInv.ClearSelection();                         
            dgvInv.CurrentCell = null;

            txtNom.ReadOnly = true;
        }

        private void CargarPedidosCliente(string usuarioCliente)
        {

            try
            {
                dgvPedidosCli.Rows.Clear();

                DataTable dt = TraerPedidos();
                DataView dv = new DataView(dt);
                dv.RowFilter = $"usuario_cliente = '{usuarioCliente}'";

                foreach (DataRowView row in dv)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvPedidosCli);

                    fila.Cells[dgvPedidosCli.Columns["IDPed"].Index].Value = row["id_pedido"];
                    fila.Cells[dgvPedidosCli.Columns["medicamento"].Index].Value = row["medicamento"];
                    fila.Cells[dgvPedidosCli.Columns["cantidadCliente"].Index].Value = row["cantidad"];
                    fila.Cells[dgvPedidosCli.Columns["total"].Index].Value = row["subtotal"];
                    fila.Cells[dgvPedidosCli.Columns["fecha"].Index].Value = row["fecha"];

                    dgvPedidosCli.Rows.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }


        private void CargarMedicamentos()
        {
            try
            {
                dgvInv.Rows.Clear();
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


                    if (dgvInv.Columns.Contains("ID"))
                    {
                        dgvInv.Columns["ID"].SortMode = DataGridViewColumnSortMode.Programmatic;
                        dgvInv.Sort(dgvInv.Columns["ID"], ListSortDirection.Ascending);

                    }
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
                    nudCant.Value = 0;
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

        private int BuscarFilaPorValor(DataGridView dgv, string columnName, object value)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cellVal = row.Cells[columnName].Value;
                if (cellVal != null && cellVal.ToString() == value?.ToString())
                    return row.Index;
            }
            return -1;
        }

        private void SeleccionarYEnfocarFila(DataGridView dgv, int rowIndex, string focusColumnName = null)
        {
            if (rowIndex < 0 || rowIndex >= dgv.Rows.Count) return;

            dgv.ClearSelection();
            int colIndex = 0;
            if (!string.IsNullOrEmpty(focusColumnName) && dgv.Columns.Contains(focusColumnName))
                colIndex = dgv.Columns[focusColumnName].Index;

            dgv.CurrentCell = dgv.Rows[rowIndex].Cells[colIndex];
            dgv.Rows[rowIndex].Selected = true;

            // Enfocar a esa fila
            dgv.FirstDisplayedScrollingRowIndex = rowIndex;
        }

        private int ObtenerUltimoPedidoCliente(int idCliente)
        {
            try
            {
                using (var con = ConexionBd.ObtenerConexion())
                using (var cmd = new NpgsqlCommand(
                    "SELECT id FROM pedidos WHERE id_cliente = @id ORDER BY fecha DESC LIMIT 1;", con))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
            catch
            {
                return -1;
            }
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
            
            try
            {
                Farmacia.RegistrarPedido(idCliente, idMedicamento, cantidad);
                

                int idPedidoNuevo = ObtenerUltimoPedidoCliente(idCliente);
                CargarMedicamentos();
                CargarPedidosCliente(usuarioCliente);

                int idxInv = BuscarFilaPorValor(dgvInv, "ID", idMedicamento);
                SeleccionarYEnfocarFila(dgvInv, idxInv, "nombre");


                if (idPedidoNuevo != -1)
                {
                    int idxPed = BuscarFilaPorValor(dgvPedidosCli, "idPed", idPedidoNuevo);
                    SeleccionarYEnfocarFila(dgvPedidosCli, idxPed, "medicamento");
                }

                MessageBox.Show("Pedido registrado correctamente.");
                
                txtNom.Clear();
                nudCant.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pedido: " + ex.Message);
            }
        }
    }
}
