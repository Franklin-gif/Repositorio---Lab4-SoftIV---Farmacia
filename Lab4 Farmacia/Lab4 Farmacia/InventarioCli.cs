using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Farmacia
{
    public partial class InventarioCli : Form
    {
        public InventarioCli()
        {
            InitializeComponent();
        }


        private void CargarMedicamentos()
        {
            try
            {
                var dt = Farmacia.TraerMedicamentos();

                foreach (DataRow dr in dt.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvMedicamentosCliente);

                    row.Cells[dgvMedicamentosCliente.Columns["ID"].Index].Value = dr["id"];
                    row.Cells[dgvMedicamentosCliente.Columns["nombre"].Index].Value = dr["nombre"];
                    row.Cells[dgvMedicamentosCliente.Columns["descripcion"].Index].Value = dr["descripcion"];
                    row.Cells[dgvMedicamentosCliente.Columns["Cantidad"].Index].Value = dr["cantidad"];
                    row.Cells[dgvMedicamentosCliente.Columns["Precio"].Index].Value = dr["precio"];

                    byte[] bytes = dr["imagen"] as byte[];
                    row.Cells[dgvMedicamentosCliente.Columns["Imagen"].Index].Value = bytes != null ? Image.FromStream(new MemoryStream(bytes)) : null;

                    dgvMedicamentosCliente.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message);
            }
        }

        private void pnlGeneral_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void InventarioCli_Load(object sender, EventArgs e)
        {
            CargarMedicamentos();
        }
    }
}
