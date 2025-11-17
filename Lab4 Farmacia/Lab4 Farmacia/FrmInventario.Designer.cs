namespace Lab4_Farmacia
{
    partial class FrmInventario
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
            pnlGeneral = new Panel();
            dgvInv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            imagen = new DataGridViewImageColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInv).BeginInit();
            SuspendLayout();
            // 
            // pnlGeneral
            // 
            pnlGeneral.BackColor = Color.Transparent;
            pnlGeneral.Controls.Add(dgvInv);
            pnlGeneral.Dock = DockStyle.Fill;
            pnlGeneral.Location = new Point(0, 0);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Padding = new Padding(40, 120, 40, 40);
            pnlGeneral.Size = new Size(965, 507);
            pnlGeneral.TabIndex = 4;
            // 
            // dgvInv
            // 
            dgvInv.AllowUserToAddRows = false;
            dgvInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInv.ColumnHeadersHeight = 29;
            dgvInv.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, descripcion, imagen, cantidad, precio });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvInv.DefaultCellStyle = dataGridViewCellStyle5;
            dgvInv.Dock = DockStyle.Fill;
            dgvInv.Location = new Point(40, 120);
            dgvInv.Margin = new Padding(3, 4, 3, 4);
            dgvInv.MultiSelect = false;
            dgvInv.Name = "dgvInv";
            dgvInv.ReadOnly = true;
            dgvInv.RowHeadersWidth = 51;
            dgvInv.RowTemplate.Height = 120;
            dgvInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInv.Size = new Size(885, 347);
            dgvInv.TabIndex = 4;
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
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(965, 100);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Inventario";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__1_;
            ClientSize = new Size(965, 507);
            Controls.Add(lblTitulo);
            Controls.Add(pnlGeneral);
            Name = "FrmInventario";
            Text = "FrmInventario";
            Load += FrmInventario_Load;
            pnlGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlGeneral;
        private DataGridView dgvInv;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewImageColumn imagen;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private Label lblTitulo;
    }
}