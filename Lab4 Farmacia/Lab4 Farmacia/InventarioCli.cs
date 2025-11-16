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
            inv.Show();
            this.Hide();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
