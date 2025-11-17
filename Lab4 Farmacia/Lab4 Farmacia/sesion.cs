using System;
using System.Windows.Forms;

namespace Lab4_Farmacia
{
    public partial class sesion : Form
    {


        public sesion(string usuario, string rol)
        {
            InitializeComponent();
            lblUsuario.Text = usuario; // adminFarma o Pedro
            lblRol.Text = rol;         // Admin o Cliente
        }



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!(frm is Form1))
                {
                    frm.Close();
                }
            }
        }

        private void sesion_Load(object sender, EventArgs e)
        {

        }
    }
}
