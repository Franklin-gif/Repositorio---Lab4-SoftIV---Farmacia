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
                using (NpgsqlConnection conn = ConexionBd.ObtenerConexion())
                {
                    // ?? Traer tanto el nombre de usuario como el tipo (rol)
                    string query = "SELECT usuario, tipo_usuario FROM usuarios WHERE usuario=@u AND clave=@c";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", usuario);
                        cmd.Parameters.AddWithValue("@c", clave);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // ?? Obtener datos del usuario
                            string nombreUsuario = reader.GetString(0);
                            string tipoUsuario = reader.GetString(1);

                            // ?? Mostrar mensaje opcional
                            MessageBox.Show($"Bienvenido {nombreUsuario} ({tipoUsuario})", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                         
                            if (tipoUsuario == "Admin")
                            {
                                frmInicioAdmin frmAdmin = new frmInicioAdmin();
                                frmAdmin.Show();
                                sesion ventanaSesion = new sesion(nombreUsuario, tipoUsuario);
                                


                                // Abrir la ventana 'sesion' automáticamente
 
                            }
                            else if (tipoUsuario == "Cliente")
                            {
                                frmInicioCliente frmCliente = new frmInicioCliente(nombreUsuario);
                                frmCliente.Show();

                                sesion ventanaSesion = new sesion(nombreUsuario, tipoUsuario);
                              
                            }
                            else
                            {
                                MessageBox.Show("Rol no reconocido en la base de datos.");
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btmRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
