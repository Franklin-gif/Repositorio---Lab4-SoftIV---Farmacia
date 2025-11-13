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
            rdbReabastecer = new RadioButton();
            rdbEliminar = new RadioButton();
            rdbModificar = new RadioButton();
            dataGridView1 = new DataGridView();
            rdbAgregar = new RadioButton();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            pnlGeneral = new Panel();
            nudCant = new NumericUpDown();
            pictureBox1 = new PictureBox();
            btnEjecutar = new Button();
            lblPrecioUnidad = new Label();
            lblCantidad = new Label();
            txtPrecio = new TextBox();
            tctEjecutar = new TextBox();
            lblmagen = new Label();
            lblPrecio = new Label();
            lblNombre = new Label();
            pnlDesicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlDesicion
            // 
            pnlDesicion.Controls.Add(rdbReabastecer);
            pnlDesicion.Controls.Add(rdbEliminar);
            pnlDesicion.Controls.Add(rdbModificar);
            pnlDesicion.Controls.Add(dataGridView1);
            pnlDesicion.Controls.Add(rdbAgregar);
            pnlDesicion.Location = new Point(3, 2);
            pnlDesicion.Margin = new Padding(3, 2, 3, 2);
            pnlDesicion.Name = "pnlDesicion";
            pnlDesicion.Size = new Size(526, 382);
            pnlDesicion.TabIndex = 0;
            // 
            // rdbReabastecer
            // 
            rdbReabastecer.AutoSize = true;
            rdbReabastecer.Font = new Font("Stencil", 22.2F);
            rdbReabastecer.ForeColor = Color.White;
            rdbReabastecer.Location = new Point(248, 94);
            rdbReabastecer.Margin = new Padding(3, 2, 3, 2);
            rdbReabastecer.Name = "rdbReabastecer";
            rdbReabastecer.Size = new Size(240, 39);
            rdbReabastecer.TabIndex = 4;
            rdbReabastecer.TabStop = true;
            rdbReabastecer.Text = "Reabastecer";
            rdbReabastecer.UseVisualStyleBackColor = true;
            // 
            // rdbEliminar
            // 
            rdbEliminar.AutoSize = true;
            rdbEliminar.Font = new Font("Stencil", 22.2F);
            rdbEliminar.ForeColor = Color.White;
            rdbEliminar.Location = new Point(18, 94);
            rdbEliminar.Margin = new Padding(3, 2, 3, 2);
            rdbEliminar.Name = "rdbEliminar";
            rdbEliminar.Size = new Size(174, 39);
            rdbEliminar.TabIndex = 3;
            rdbEliminar.TabStop = true;
            rdbEliminar.Text = "Eliminar";
            rdbEliminar.UseVisualStyleBackColor = true;
            // 
            // rdbModificar
            // 
            rdbModificar.AutoSize = true;
            rdbModificar.Font = new Font("Stencil", 22.2F);
            rdbModificar.ForeColor = Color.White;
            rdbModificar.Location = new Point(248, 40);
            rdbModificar.Margin = new Padding(3, 2, 3, 2);
            rdbModificar.Name = "rdbModificar";
            rdbModificar.Size = new Size(201, 39);
            rdbModificar.TabIndex = 2;
            rdbModificar.TabStop = true;
            rdbModificar.Text = "Modificar ";
            rdbModificar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 151);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(487, 198);
            dataGridView1.TabIndex = 1;
            // 
            // rdbAgregar
            // 
            rdbAgregar.AutoSize = true;
            rdbAgregar.Font = new Font("Stencil", 22.2F);
            rdbAgregar.ForeColor = Color.White;
            rdbAgregar.Location = new Point(18, 40);
            rdbAgregar.Margin = new Padding(3, 2, 3, 2);
            rdbAgregar.Name = "rdbAgregar";
            rdbAgregar.Size = new Size(169, 39);
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
            pnlGeneral.Margin = new Padding(3, 2, 3, 2);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(901, 386);
            pnlGeneral.TabIndex = 1;
            // 
            // nudCant
            // 
            nudCant.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCant.Location = new Point(732, 228);
            nudCant.Margin = new Padding(3, 2, 3, 2);
            nudCant.Name = "nudCant";
            nudCant.Size = new Size(109, 39);
            nudCant.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(732, 92);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 36);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnEjecutar
            // 
            btnEjecutar.BackColor = SystemColors.ButtonFace;
            btnEjecutar.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEjecutar.ForeColor = Color.Black;
            btnEjecutar.Location = new Point(634, 302);
            btnEjecutar.Margin = new Padding(3, 2, 3, 2);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(176, 43);
            btnEjecutar.TabIndex = 9;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = false;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // lblPrecioUnidad
            // 
            lblPrecioUnidad.AutoSize = true;
            lblPrecioUnidad.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioUnidad.ForeColor = Color.White;
            lblPrecioUnidad.Location = new Point(587, 192);
            lblPrecioUnidad.Name = "lblPrecioUnidad";
            lblPrecioUnidad.Size = new Size(116, 17);
            lblPrecioUnidad.TabIndex = 8;
            lblPrecioUnidad.Text = "Precio por Unidad";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Stencil", 18F);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(587, 234);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(129, 29);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 16.2F);
            txtPrecio.Location = new Point(732, 164);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 32);
            txtPrecio.TabIndex = 5;
            // 
            // tctEjecutar
            // 
            tctEjecutar.Font = new Font("Microsoft Sans Serif", 16.2F);
            tctEjecutar.Location = new Point(732, 34);
            tctEjecutar.Margin = new Padding(3, 2, 3, 2);
            tctEjecutar.Name = "tctEjecutar";
            tctEjecutar.Size = new Size(110, 32);
            tctEjecutar.TabIndex = 2;
            // 
            // lblmagen
            // 
            lblmagen.AutoSize = true;
            lblmagen.Font = new Font("Stencil", 18F);
            lblmagen.ForeColor = Color.White;
            lblmagen.Location = new Point(587, 92);
            lblmagen.Name = "lblmagen";
            lblmagen.Size = new Size(102, 29);
            lblmagen.TabIndex = 3;
            lblmagen.Text = "Imagen";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Stencil", 18F);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(587, 166);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(98, 29);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Stencil", 18F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(587, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 29);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // FrmMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(906, 388);
            Controls.Add(pnlGeneral);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMedicamentos";
            Text = "FrmMedicamentos";
            pnlDesicion.ResumeLayout(false);
            pnlDesicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlGeneral.ResumeLayout(false);
            pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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