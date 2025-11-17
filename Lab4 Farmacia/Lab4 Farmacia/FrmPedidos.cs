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

            CargarPedidos();

        }

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
        }
    }
}
