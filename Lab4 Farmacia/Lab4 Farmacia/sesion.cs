using System;
using System.Windows.Forms;

namespace Lab4_Farmacia
{
    public partial class sesion : Form
    {
        private string usuarioSesion;
        private string rolSesion;

        public sesion(string usuario, string rol)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            rolSesion = rol;
        }

        private void sesion_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {usuarioSesion}";
            lblRol.Text = $"Rol: {rolSesion}";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
         
            this.Close();
            MessageBox.Show($"Sesión De: {usuarioSesion} cerrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
