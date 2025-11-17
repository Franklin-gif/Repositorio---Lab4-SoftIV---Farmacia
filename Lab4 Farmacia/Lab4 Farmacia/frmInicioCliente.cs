using System;
using System.Windows.Forms;

namespace Lab4_Farmacia
{
    public partial class frmInicioCliente : Form
    {
        string usuarioActual;


        public frmInicioCliente(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;

        }

        private void frmInicioCliente_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenido, " + usuarioActual;
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

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

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Deseas cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
