using System;
using System.Windows.Forms;

namespace Lab4_Farmacia
{
    public partial class frmInicioCliente : Form
    {
        string usuarioActual;

        // 🔹 Constructor que recibe el usuario
        public frmInicioCliente(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void frmInicioCliente_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenido, " + usuarioActual;
        }
    }
}
