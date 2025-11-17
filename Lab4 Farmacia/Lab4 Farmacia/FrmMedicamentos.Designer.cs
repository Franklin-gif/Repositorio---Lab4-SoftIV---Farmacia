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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicamentos));
            pnlDesicion = new Panel();
            rdbReabastecer = new RadioButton();
            rdbEliminar = new RadioButton();
            rdbModificar = new RadioButton();
            dgvDatos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            imagen = new DataGridViewImageColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            rdbAgregar = new RadioButton();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            pnlGeneral = new Panel();
            grpInf = new GroupBox();
            lblPieFoto = new Label();
            rtbDescrip = new RichTextBox();
            lblDescripcion = new Label();
            lblNombre = new Label();
            btnEjecutar = new Button();
            lblPrecio = new Label();
            nudCant = new NumericUpDown();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            lblmagen = new Label();
            lblCantidad = new Label();
            lblPrecioUnidad = new Label();
            pbImagen = new PictureBox();
            pnlDesicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            pnlGeneral.SuspendLayout();
            grpInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // pnlDesicion
            // 
            pnlDesicion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlDesicion.Controls.Add(rdbReabastecer);
            pnlDesicion.Controls.Add(rdbEliminar);
            pnlDesicion.Controls.Add(rdbModificar);
            pnlDesicion.Controls.Add(dgvDatos);
            pnlDesicion.Controls.Add(rdbAgregar);
            pnlDesicion.Location = new Point(3, 4);
            pnlDesicion.Margin = new Padding(3, 4, 3, 4);
            pnlDesicion.Name = "pnlDesicion";
            pnlDesicion.Size = new Size(1196, 1023);
            pnlDesicion.TabIndex = 0;
            // 
            // rdbReabastecer
            // 
            rdbReabastecer.AutoSize = true;
            rdbReabastecer.Font = new Font("Stencil", 22.2F);
            rdbReabastecer.ForeColor = Color.White;
            rdbReabastecer.Location = new Point(840, 35);
            rdbReabastecer.Margin = new Padding(3, 4, 3, 4);
            rdbReabastecer.Name = "rdbReabastecer";
            rdbReabastecer.Size = new Size(294, 48);
            rdbReabastecer.TabIndex = 4;
            rdbReabastecer.TabStop = true;
            rdbReabastecer.Text = "Reabastecer";
            rdbReabastecer.UseVisualStyleBackColor = true;
            rdbReabastecer.CheckedChanged += rdbReabastecer_CheckedChanged;
            // 
            // rdbEliminar
            // 
            rdbEliminar.AutoSize = true;
            rdbEliminar.Font = new Font("Stencil", 22.2F);
            rdbEliminar.ForeColor = Color.White;
            rdbEliminar.Location = new Point(580, 35);
            rdbEliminar.Margin = new Padding(3, 4, 3, 4);
            rdbEliminar.Name = "rdbEliminar";
            rdbEliminar.Size = new Size(215, 48);
            rdbEliminar.TabIndex = 3;
            rdbEliminar.TabStop = true;
            rdbEliminar.Text = "Eliminar";
            rdbEliminar.UseVisualStyleBackColor = true;
            rdbEliminar.CheckedChanged += rdbEliminar_CheckedChanged;
            // 
            // rdbModificar
            // 
            rdbModificar.AutoSize = true;
            rdbModificar.Font = new Font("Stencil", 22.2F);
            rdbModificar.ForeColor = Color.White;
            rdbModificar.Location = new Point(284, 35);
            rdbModificar.Margin = new Padding(3, 4, 3, 4);
            rdbModificar.Name = "rdbModificar";
            rdbModificar.Size = new Size(247, 48);
            rdbModificar.TabIndex = 2;
            rdbModificar.TabStop = true;
            rdbModificar.Text = "Modificar ";
            rdbModificar.UseVisualStyleBackColor = true;
            rdbModificar.CheckedChanged += rdbModificar_CheckedChanged;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeight = 29;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, descripcion, imagen, cantidad, precio });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDatos.Location = new Point(38, 130);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 120;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1096, 669);
            dgvDatos.TabIndex = 1;
            dgvDatos.CellDoubleClick += dgvDatos_CellDoubleClick;
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.FillWeight = 40F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 50;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre.DataPropertyName = "nombre";
            nombre.FillWeight = 70F;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descripcion.DataPropertyName = "descripcion";
            descripcion.FillWeight = 80F;
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // imagen
            // 
            imagen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imagen.DataPropertyName = "imagen";
            imagen.HeaderText = "Imagen";
            imagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imagen.MinimumWidth = 6;
            imagen.Name = "imagen";
            imagen.ReadOnly = true;
            imagen.Resizable = DataGridViewTriState.True;
            imagen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            cantidad.FillWeight = 45F;
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // precio
            // 
            precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            precio.DataPropertyName = "precio";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            precio.DefaultCellStyle = dataGridViewCellStyle4;
            precio.FillWeight = 45F;
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // rdbAgregar
            // 
            rdbAgregar.AutoSize = true;
            rdbAgregar.Font = new Font("Stencil", 22.2F);
            rdbAgregar.ForeColor = Color.White;
            rdbAgregar.Location = new Point(38, 35);
            rdbAgregar.Margin = new Padding(3, 4, 3, 4);
            rdbAgregar.Name = "rdbAgregar";
            rdbAgregar.Size = new Size(206, 48);
            rdbAgregar.TabIndex = 0;
            rdbAgregar.TabStop = true;
            rdbAgregar.Text = "Agregar";
            rdbAgregar.UseVisualStyleBackColor = true;
            rdbAgregar.CheckedChanged += rdbAgregar_CheckedChanged;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // pnlGeneral
            // 
            pnlGeneral.BackColor = Color.Transparent;
            pnlGeneral.Controls.Add(grpInf);
            pnlGeneral.Controls.Add(pnlDesicion);
            pnlGeneral.Location = new Point(-1, 0);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(1928, 1059);
            pnlGeneral.TabIndex = 1;
            // 
            // grpInf
            // 
            grpInf.Controls.Add(lblPieFoto);
            grpInf.Controls.Add(rtbDescrip);
            grpInf.Controls.Add(lblDescripcion);
            grpInf.Controls.Add(lblNombre);
            grpInf.Controls.Add(btnEjecutar);
            grpInf.Controls.Add(lblPrecio);
            grpInf.Controls.Add(nudCant);
            grpInf.Controls.Add(txtPrecio);
            grpInf.Controls.Add(txtNombre);
            grpInf.Controls.Add(lblmagen);
            grpInf.Controls.Add(lblCantidad);
            grpInf.Controls.Add(lblPrecioUnidad);
            grpInf.Controls.Add(pbImagen);
            grpInf.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpInf.ForeColor = Color.White;
            grpInf.Location = new Point(1214, 39);
            grpInf.Margin = new Padding(3, 4, 3, 4);
            grpInf.Name = "grpInf";
            grpInf.Padding = new Padding(3, 4, 3, 4);
            grpInf.Size = new Size(639, 832);
            grpInf.TabIndex = 5;
            grpInf.TabStop = false;
            grpInf.Text = "Información";
            grpInf.Visible = false;
            // 
            // lblPieFoto
            // 
            lblPieFoto.AutoSize = true;
            lblPieFoto.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPieFoto.Location = new Point(27, 495);
            lblPieFoto.Name = "lblPieFoto";
            lblPieFoto.Size = new Size(275, 21);
            lblPieFoto.TabIndex = 15;
            lblPieFoto.Text = "Doble click para seleccionar imagen";
            // 
            // rtbDescrip
            // 
            rtbDescrip.Location = new Point(338, 177);
            rtbDescrip.Margin = new Padding(3, 4, 3, 4);
            rtbDescrip.Name = "rtbDescrip";
            rtbDescrip.Size = new Size(261, 303);
            rtbDescrip.TabIndex = 14;
            rtbDescrip.Text = "";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Stencil", 18F);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(350, 137);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(208, 35);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Stencil", 18F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(26, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(136, 35);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = SystemColors.ButtonFace;
            btnEjecutar.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEjecutar.ForeColor = Color.Black;
            btnEjecutar.Location = new Point(216, 735);
            btnEjecutar.Margin = new Padding(3, 4, 3, 4);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(230, 76);
            btnEjecutar.TabIndex = 9;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Stencil", 18F);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(116, 632);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(122, 35);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // nudCant
            // 
            nudCant.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCant.Location = new Point(336, 542);
            nudCant.Margin = new Padding(3, 4, 3, 4);
            nudCant.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nudCant.Name = "nudCant";
            nudCant.Size = new Size(216, 47);
            nudCant.TabIndex = 11;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(336, 632);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(215, 41);
            txtPrecio.TabIndex = 5;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(189, 60);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(411, 41);
            txtNombre.TabIndex = 2;
            // 
            // lblmagen
            // 
            lblmagen.AutoSize = true;
            lblmagen.Font = new Font("Stencil", 18F);
            lblmagen.ForeColor = Color.White;
            lblmagen.Location = new Point(27, 137);
            lblmagen.Name = "lblmagen";
            lblmagen.Size = new Size(126, 35);
            lblmagen.TabIndex = 3;
            lblmagen.Text = "Imagen";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Stencil", 18F);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(116, 553);
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
            lblPrecioUnidad.Location = new Point(116, 679);
            lblPrecioUnidad.Name = "lblPrecioUnidad";
            lblPrecioUnidad.Size = new Size(140, 21);
            lblPrecioUnidad.TabIndex = 8;
            lblPrecioUnidad.Text = "Precio por Unidad";
            // 
            // pbImagen
            // 
            pbImagen.BackColor = Color.White;
            pbImagen.Location = new Point(27, 176);
            pbImagen.Margin = new Padding(3, 4, 3, 4);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(272, 304);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 10;
            pbImagen.TabStop = false;
            pbImagen.DoubleClick += pbImagen_DoubleClick;
            // 
            // FrmMedicamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlGeneral);
            Name = "FrmMedicamentos";
            Text = "FrmMedicamentos";
            Load += FrmMedicamentos_Load;
            pnlDesicion.ResumeLayout(false);
            pnlDesicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            pnlGeneral.ResumeLayout(false);
            grpInf.ResumeLayout(false);
            grpInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDesicion;
        private RadioButton rdbAgregar;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private RadioButton rdbModificar;
        private RadioButton rdbReabastecer;
        private RadioButton rdbEliminar;
        private Panel pnlGeneral;
        private Label lblPrecio;
        private Label lblmagen;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblPrecioUnidad;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private Button btnEjecutar;
        private PictureBox pbImagen;
        private NumericUpDown nudCant;
        private GroupBox grpInf;
        private Label lblDescripcion;
        private RichTextBox rtbDescrip;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewImageColumn imagen;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private Label lblPieFoto;
    }
}