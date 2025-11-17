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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }


        private void CargarMedicamentos()
        {
            try
            {
                var dt = Admin.TraerMedicamentos();
                dgvInv.Rows.Clear();

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

                dgvInv.ClearSelection();
                dgvInv.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message);
            }
        }



        private void FrmInventario_Load(object sender, EventArgs e)
        {

            CargarMedicamentos();

        }
    }
}
