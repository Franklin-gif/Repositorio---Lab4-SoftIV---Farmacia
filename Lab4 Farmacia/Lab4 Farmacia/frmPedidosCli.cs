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
            txtNom.ReadOnly = true; 
            CargarMedicamentos();

            
            dgvMedicamentos.CellClick += dgvMedicamentos_CellClick;
        }

        
        private void CargarMedicamentos()
        {
            try
            {
                using (var con = ConexionBd.ObtenerConexion())
                {
                    string sql = "SELECT * FROM sp_ver_inventario_cli();";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMedicamentos.DataSource = dt;

                    if (dgvMedicamentos.Columns.Contains("imagen"))
                        dgvMedicamentos.Columns["imagen"].Visible = false;

                    dgvMedicamentos.ClearSelection();
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
                    DataGridViewRow fila = dgvMedicamentos.Rows[e.RowIndex];
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

        private void btnConfirmarPedido_Click_1(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
