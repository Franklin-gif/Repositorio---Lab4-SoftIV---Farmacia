namespace Lab4_Farmacia
{
    partial class FrmMedicamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicamentos));
            pnlDesicion = new Panel();
            rdbAgregar = new RadioButton();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dataGridView1 = new DataGridView();
            rdbModificar = new RadioButton();
            rdbEliminar = new RadioButton();
            rdbReabastecer = new RadioButton();
            pnlGeneral = new Panel();
            lblNombre = new Label();
            tctEjecutar = new TextBox();
            lblmagen = new Label();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCantidad = new Label();
            lblPrecioUnidad = new Label();
            btnEjecutar = new Button();
            pictureBox1 = new PictureBox();
            nudCant = new NumericUpDown();
            pnlDesicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCant).BeginInit();
            SuspendLayout();
            // 
            // pnlDesicion
            // 
            pnlDesicion.Controls.Add(rdbReabastecer);
            pnlDesicion.Controls.Add(rdbEliminar);
            pnlDesicion.Controls.Add(rdbModificar);
            pnlDesicion.Controls.Add(dataGridView1);
            pnlDesicion.Controls.Add(rdbAgregar);
            pnlDesicion.Location = new Point(3, 3);
            pnlDesicion.Name = "pnlDesicion";
            pnlDesicion.Size = new Size(601, 509);
            pnlDesicion.TabIndex = 0;
            // 
            // rdbAgregar
            // 
            rdbAgregar.AutoSize = true;
            rdbAgregar.Font = new Font("Stencil", 22.2F);
            rdbAgregar.ForeColor = Color.White;
            rdbAgregar.Location = new Point(21, 54);
            rdbAgregar.Name = "rdbAgregar";
            rdbAgregar.Size = new Size(206, 48);
            rdbAgregar.TabIndex = 0;
            rdbAgregar.TabStop = true;
            rdbAgregar.Text = "Agregar";
            rdbAgregar.UseVisualStyleBackColor = true;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(557, 264);
            dataGridView1.TabIndex = 1;
            // 
            // rdbModificar
            // 
            rdbModificar.AutoSize = true;
            rdbModificar.Font = new Font("Stencil", 22.2F);
            rdbModificar.ForeColor = Color.White;
            rdbModificar.Location = new Point(284, 54);
            rdbModificar.Name = "rdbModificar";
            rdbModificar.Size = new Size(247, 48);
            rdbModificar.TabIndex = 2;
            rdbModificar.TabStop = true;
            rdbModificar.Text = "Modificar ";
            rdbModificar.UseVisualStyleBackColor = true;
            // 
            // rdbEliminar
            // 
            rdbEliminar.AutoSize = true;
            rdbEliminar.Font = new Font("Stencil", 22.2F);
            rdbEliminar.ForeColor = Color.White;
            rdbEliminar.Location = new Point(21, 126);
            rdbEliminar.Name = "rdbEliminar";
            rdbEliminar.Size = new Size(215, 48);
            rdbEliminar.TabIndex = 3;
            rdbEliminar.TabStop = true;
            rdbEliminar.Text = "Eliminar";
            rdbEliminar.UseVisualStyleBackColor = true;
            // 
            // rdbReabastecer
            // 
            rdbReabastecer.AutoSize = true;
            rdbReabastecer.Font = new Font("Stencil", 22.2F);
            rdbReabastecer.ForeColor = Color.White;
            rdbReabastecer.Location = new Point(284, 126);
            rdbReabastecer.Name = "rdbReabastecer";
            rdbReabastecer.Size = new Size(294, 48);
            rdbReabastecer.TabIndex = 4;
            rdbReabastecer.TabStop = true;
            rdbReabastecer.Text = "Reabastecer";
            rdbReabastecer.UseVisualStyleBackColor = true;
            // 
            // pnlGeneral
            // 
            pnlGeneral.BackColor = Color.Transparent;
            pnlGeneral.Controls.Add(nudCant);
            pnlGeneral.Controls.Add(pictureBox1);
            pnlGeneral.Controls.Add(btnEjecutar);
            pnlGeneral.Controls.Add(lblPrecioUnidad);
            pnlGeneral.Controls.Add(lblCantidad);
            pnlGeneral.Controls.Add(txtPrecio);
            pnlGeneral.Controls.Add(tctEjecutar);
            pnlGeneral.Controls.Add(lblmagen);
            pnlGeneral.Controls.Add(lblPrecio);
            pnlGeneral.Controls.Add(lblNombre);
            pnlGeneral.Controls.Add(pnlDesicion);
            pnlGeneral.Location = new Point(3, 2);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(1030, 515);
            pnlGeneral.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Stencil", 18F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(671, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(136, 35);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // tctEjecutar
            // 
            tctEjecutar.Font = new Font("Microsoft Sans Serif", 16.2F);
            tctEjecutar.Location = new Point(836, 46);
            tctEjecutar.Name = "tctEjecutar";
            tctEjecutar.Size = new Size(125, 38);
            tctEjecutar.TabIndex = 2;
            // 
            // lblmagen
            // 
            lblmagen.AutoSize = true;
            lblmagen.Font = new Font("Stencil", 18F);
            lblmagen.ForeColor = Color.White;
            lblmagen.Location = new Point(671, 122);
            lblmagen.Name = "lblmagen";
            lblmagen.Size = new Size(126, 35);
            lblmagen.TabIndex = 3;
            lblmagen.Text = "Imagen";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Stencil", 18F);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(671, 221);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(122, 35);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 16.2F);
            txtPrecio.Location = new Point(836, 218);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 38);
            txtPrecio.TabIndex = 5;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Stencil", 18F);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(671, 312);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(159, 35);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnidad
            // 
            lblPrecioUnidad.AutoSize = true;
            lblPrecioUnidad.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioUnidad.ForeColor = Color.White;
            lblPrecioUnidad.Location = new Point(671, 256);
            lblPrecioUnidad.Name = "lblPrecioUnidad";
            lblPrecioUnidad.Size = new Size(140, 21);
            lblPrecioUnidad.TabIndex = 8;
            lblPrecioUnidad.Text = "Precio por Unidad";
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = SystemColors.ButtonFace;
            btnEjecutar.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEjecutar.ForeColor = Color.Black;
            btnEjecutar.Location = new Point(725, 402);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(201, 57);
            btnEjecutar.TabIndex = 9;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(836, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 48);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // nudCant
            // 
            nudCant.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCant.Location = new Point(836, 304);
            nudCant.Name = "nudCant";
            nudCant.Size = new Size(125, 47);
            nudCant.TabIndex = 11;
            // 
            // FrmMedicamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1036, 518);
            Controls.Add(pnlGeneral);
            Name = "FrmMedicamentos";
            Text = "FrmMedicamentos";
            pnlDesicion.ResumeLayout(false);
            pnlDesicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlGeneral.ResumeLayout(false);
            pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCant).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesicion;
        private RadioButton rdbAgregar;
        private DataGridView dataGridView1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private RadioButton rdbModificar;
        private RadioButton rdbReabastecer;
        private RadioButton rdbEliminar;
        private Panel pnlGeneral;
        private Label lblPrecio;
        private Label lblmagen;
        private TextBox tctEjecutar;
        private Label lblNombre;
        private Label lblPrecioUnidad;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private Button btnEjecutar;
        private PictureBox pictureBox1;
        private NumericUpDown nudCant;
    }
}