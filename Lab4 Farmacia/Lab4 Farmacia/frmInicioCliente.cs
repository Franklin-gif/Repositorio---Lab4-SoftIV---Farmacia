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

        }
    }
}
