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
    public partial class sesionCli : Form
    {
        public sesionCli(string usuario, string rol)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            lblUsuario.Text = usuario;
            lblRol.Text = rol;
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
    }
}
