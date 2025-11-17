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
        private void CargarInventario()
        {
            using (var conexion = ConexionBd.ObtenerConexion())
            {
                string query = "SELECT nombre, descripcion, cantidad, precio FROM medicamentos";
                NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(query, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvMedicamentosCliente.DataSource = tabla;
            }
        }

        private void btnActualizarCli_Click(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioCli inv = new InventarioCli();
            inv.MdiParent = this;
            inv.WindowState= FormWindowState.Maximized;
            inv.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos pedidosCli = new FrmPedidos();
            pedidosCli.MdiParent = this;
            pedidosCli.WindowState= FormWindowState.Maximized;
            pedidosCli.Show();

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Deseas cerrar sesión?",
                                 "Confirmar",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void dgvMedicamentosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
