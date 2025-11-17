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
    public partial class frmInicioAdmin : Form
    {
        private string usuarioActual;
        private string rolActual;

        public frmInicioAdmin(string usuario, string rol)
        {
            InitializeComponent();
            usuarioActual = usuario;   
            rolActual = rol;
        }


        public frmInicioAdmin()
        {
            InitializeComponent();
        }
      
        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicamentos frmMedicamentos = new FrmMedicamentos();
            frmMedicamentos.MdiParent = this;
            frmMedicamentos.WindowState= FormWindowState.Maximized;
            frmMedicamentos.Show();
          
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.MdiParent = this;
            frmInventario.WindowState= FormWindowState.Maximized;
            frmInventario.Show();
            
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedido  = new FrmPedidos();
            frmPedido.MdiParent = this;
            frmPedido.WindowState= FormWindowState.Maximized;
            frmPedido.Show();
            
        }

        private void sesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sesion ventanaSesion = new sesion(usuarioActual, rolActual); 
            ventanaSesion.MdiParent = this;
            ventanaSesion.WindowState= FormWindowState.Maximized;
            ventanaSesion.Show();
        }

        private void frmInicioAdmin_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

        }
    }
}
