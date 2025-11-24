using System;
using System.Windows.Forms;

namespace Lab4_Farmacia
{
    public partial class frmInicioCliente : Form
    {
        int idCliente;
        string usuarioActual;
        string rolActual;

        public frmInicioCliente(int idCliente,string usuario, string rol)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            this.usuarioActual = usuario;
            this.rolActual = rol;
        }

        private void frmInicioCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioCli inv = new InventarioCli();
            inv.MdiParent = this;
            inv.WindowState= FormWindowState.Maximized;
            inv.Show();
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sesionCli ventanaSesion = new sesionCli(usuarioActual, rolActual);
            ventanaSesion.MdiParent = this;
            ventanaSesion.WindowState = FormWindowState.Maximized;
            ventanaSesion.Show();

        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPedidosCli pedidosCli = new frmPedidosCli(idCliente, usuarioActual,rolActual);
            pedidosCli.MdiParent = this;
            pedidosCli.WindowState= FormWindowState.Maximized;
            pedidosCli.Show();
        }
    }
}

