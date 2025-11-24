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

        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {

            CargarPedidos();

        }

        private void CargarPedidos()
        {
            try
            {
                DataTable dt = Farmacia.TraerPedidos();

                foreach (DataRow dr in dt.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPedidos);

                    row.Cells[dgvPedidos.Columns["id"].Index].Value = dr["id_pedido"];
                    row.Cells[dgvPedidos.Columns["cliente"].Index].Value = dr["usuario_cliente"];
                    row.Cells[dgvPedidos.Columns["medicamentos"].Index].Value = dr["medicamento"];
                    row.Cells[dgvPedidos.Columns["cantidad"].Index].Value = dr["cantidad"];
                    row.Cells[dgvPedidos.Columns["total"].Index].Value = dr["subtotal"];
                    row.Cells[dgvPedidos.Columns["fecha"].Index].Value = dr["fecha"];

                    dgvPedidos.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

