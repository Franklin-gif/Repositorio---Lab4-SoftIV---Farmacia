using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab4_Farmacia
{
    public partial class FrmMedicamentos : Form
    {

        public FrmMedicamentos()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbAgregar.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(rtbDescrip.Text) || pbImagen.Image == null
                        || string.IsNullOrWhiteSpace(txtPrecio.Text) || nudCant.Value <= 0)
                    {
                        MessageBox.Show("Ingrese todos los datos");
                        return;
                    }

                    string nombre = txtNombre.Text.Trim();
                    string desc = rtbDescrip.Text.Trim();
                    int cant = (int)nudCant.Value;
                    decimal precio = decimal.Parse(txtPrecio.Text);
                    byte[] imgBytes = Admin.ConvertirImagenABytes(pbImagen.Image);

                    // Agregar a BD
                    try
                    {
                        Admin.AgregarMedicamento(nombre, desc, cant, precio, imgBytes);
                        MessageBox.Show("Medicamento agregado correctamente.");

                        // Actualizar dgv
                        CargarMedicamentos();  // método que usa Admin.TraerMedicamentos()
                        LimpiarCampos();       // limpia todo para agregar uno nuevo
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }


                else if (rdbModificar.Checked)
                {
                }
                else if (rdbReabastecer.Checked)
                {
                }
                else
                {
                    MessageBox.Show("Seleccione una acción: Agregar, Modificar o Reabastecer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            rtbDescrip.Text = "";
            nudCant.Value = 0;
            txtPrecio.Text = "";
            pbImagen.Image = null;
        }


        private void CargarMedicamentos()
        {
            var dt = Admin.TraerMedicamentos();
            dgvDatos.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDatos);

                row.Cells[dgvDatos.Columns["ID"].Index].Value = dr["id"];
                row.Cells[dgvDatos.Columns["nombre"].Index].Value = dr["nombre"];
                row.Cells[dgvDatos.Columns["descripcion"].Index].Value = dr["descripcion"];
                row.Cells[dgvDatos.Columns["Cantidad"].Index].Value = dr["cantidad"];
                row.Cells[dgvDatos.Columns["Precio"].Index].Value = dr["precio"];

                byte[] bytes = dr["imagen"] as byte[];
                row.Cells[dgvDatos.Columns["Imagen"].Index].Value = bytes != null ? Image.FromStream(new MemoryStream(bytes)) : null;
                dgvDatos.Rows.Add(row);
            }

            var blank = new DataGridViewRow();
            blank.CreateCells(dgvDatos);
            dgvDatos.Rows.Add(blank);

            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;

            LimpiarCampos();


        }

        private void rdbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAgregar.Checked)
            {
                grpInf.Visible = true;
                btnEjecutar.Text = "Agregar";
            }
        }


        private void pbImagen_DoubleClick(object sender, EventArgs e)
        {

            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccione una imagen del medicamento";
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.tif;*.ico\"";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pbImagen.Image = Image.FromFile(ofd.FileName);


                    }
                    catch
                    {
                        pbImagen.Image = null;
                        MessageBox.Show("No se pudo cargar la imagen seleccionada.");
                    }
                }
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow == null)
                return;


            txtNombre.Text = dgvDatos.CurrentRow.Cells["nombre"].Value?.ToString() ?? "";
            rtbDescrip.Text = dgvDatos.CurrentRow.Cells["descripcion"].Value?.ToString() ?? "";

            if (int.TryParse(dgvDatos.CurrentRow.Cells["cantidad"].Value?.ToString(), out int cant))
                nudCant.Value = cant;

            else
                nudCant.Value = nudCant.Minimum;


            if (decimal.TryParse(dgvDatos.CurrentRow.Cells["precio"].Value?.ToString(), out decimal precio))
                txtPrecio.Text = precio.ToString("0.00");
            else
                txtPrecio.Text = "";

            // Imagen: convertir bytes a Image
            var imgBytes = dgvDatos.CurrentRow.Cells["Imagen"].Value as Image;
            pbImagen.Image = imgBytes;
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {
            CargarMedicamentos();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control (borrar, retroceso)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir un solo punto decimal
            if (e.KeyChar == '.' && !txtPrecio.Text.Contains("."))
                return;

            // Bloquear todo lo demás (letras, signos, más de un punto)
            e.Handled = true;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
