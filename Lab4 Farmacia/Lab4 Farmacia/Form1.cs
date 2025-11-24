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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            {
                string usuario = txtUsuario.Text.Trim();
                string clave = txtContra.Text.Trim();
                

                try
                {
                    using (NpgsqlConnection conn = ConexionBd.ObtenerConexion())
                    {
                        string query = "SELECT id, usuario, tipo_usuario FROM usuarios WHERE usuario=@u AND clave=@c";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@u", usuario);
                            cmd.Parameters.AddWithValue("@c", clave);

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    LimpiarCampos();
                                    return;
                                }

                                // ?? Obtener datos del usuario
                                int idUsuario = reader.GetInt32(0);
                                string nombreUsuario = reader.GetString(1);
                                string tipoUsuario = reader.GetString(2);

                                MessageBox.Show($"Bienvenido {nombreUsuario} ({tipoUsuario})", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (tipoUsuario == "Admin")
                                {
                                    frmInicioAdmin frmAdmin = new frmInicioAdmin(nombreUsuario, tipoUsuario);
                                    frmAdmin.Show();
                                    LimpiarCampos();

                                }
                                else if (tipoUsuario == "Cliente")
                                {
                                    frmInicioCliente frmCliente = new frmInicioCliente(idUsuario,nombreUsuario,tipoUsuario);
                                    frmCliente.Show();
                                    LimpiarCampos();
                                }
                                else
                                {
                                    MessageBox.Show("Rol no reconocido en la base de datos.");
                                    LimpiarCampos();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                    return;
                }

            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.WindowState = FormWindowState.Maximized;
            frmRegistro.Show();
        }

    }
}
