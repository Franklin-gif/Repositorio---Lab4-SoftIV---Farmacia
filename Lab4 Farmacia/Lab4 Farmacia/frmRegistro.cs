using Npgsql;
using System;
using System.Windows.Forms;

namespace Lab4_Farmacia
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btmRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtContraseña.Text;

            try
            {
                using (var conn = ConexionBd.ObtenerConexion())
                {
                    string query = "INSERT INTO usuarios (usuario, clave, tipo_usuario) VALUES (@u, @c, 'Cliente')";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", usuario);
                        cmd.Parameters.AddWithValue("@c", clave);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente registrado correctamente.");
                    }

                    Form1 form1 = new Form1();
                    form1.Show();
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message);
            }
            
        }

    }
}
