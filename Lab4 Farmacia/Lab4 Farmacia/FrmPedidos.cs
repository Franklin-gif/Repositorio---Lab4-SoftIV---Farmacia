using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Lab4_Farmacia
{
    public partial class FrmPedidos : Form
    {


        public FrmPedidos()
        {
            
            InitializeComponent();
            CargarPedidos();

        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {

            //CargarPedidos();

        }
        /*
        private void CargarPedidos()
        {
            try
            {
                var dt = Admin.TraerPedidos();
                dgvPedidos.Rows.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPedidos);

                    row.Cells[dgvPedidos.Columns["Cliente"].Index].Value = dr["usuario_cliente"];
                    row.Cells[dgvPedidos.Columns["Medicamento"].Index].Value = dr["medicamento"];
                    row.Cells[dgvPedidos.Columns["Cantidad"].Index].Value = dr["cantidad"];
                    row.Cells[dgvPedidos.Columns["Subtotal"].Index].Value = dr["subtotal"];
                    row.Cells[dgvPedidos.Columns["Fecha"].Index].Value = dr["fecha"];

                    dgvPedidos.Rows.Add(row);
                }

                dgvPedidos.ClearSelection();
                dgvPedidos.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }*/

        private void CargarPedidos()
        {
            try
            {
                DataTable dtPedidos = Admin.TraerPedidos();

                if (dtPedidos == null)
                {
                    MessageBox.Show("Error: No se pudo obtener la información de pedidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtPedidos != null&&dtPedidos.Rows.Count > 0)
                {
                    dgvPedidos.AutoGenerateColumns = true;
                    dgvPedidos.DataSource = dtPedidos;
                }
                else
                {
                    dgvPedidos.DataSource = null;
                    MessageBox.Show("No hay pedidos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

