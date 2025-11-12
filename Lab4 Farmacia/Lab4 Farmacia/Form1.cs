using Npgsql;
using System;
using System.Windows.Forms;

namespace Lab4_Farmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtContra.Text.Trim();

            try
            {
                // ?? Obtener conexión desde la clase ConexionBd
                using (NpgsqlConnection conn = ConexionBd.ObtenerConexion())
                {
                    string query = "SELECT tipo_usuario FROM usuarios WHERE usuario=@u AND clave=@c";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", usuario);
                        cmd.Parameters.AddWithValue("@c", clave);

                        object tipo = cmd.ExecuteScalar();

                        if (tipo == null)
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                            return;
                        }

                        // ?? Validación según el tipo
                        if (tipo.ToString() == "Admin")
                        {
                            new frmInicioAdmin().Show();
                            this.Hide();
                        }
                        else if (tipo.ToString() == "Cliente")
                        {
                            new frmInicioCliente(usuario).Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void btmRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
