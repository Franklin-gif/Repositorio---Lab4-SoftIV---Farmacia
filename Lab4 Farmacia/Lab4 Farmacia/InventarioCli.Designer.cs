namespace Lab4_Farmacia
{
    partial class InventarioCli
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            pnlGeneral = new Panel();
            dgvMedicamentosCliente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            imagen = new DataGridViewImageColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentosCliente).BeginInit();
            SuspendLayout();
            // 
            // pnlGeneral
            // 
            pnlGeneral.BackColor = Color.Transparent;
            pnlGeneral.Controls.Add(dgvMedicamentosCliente);
            pnlGeneral.Controls.Add(lblTitulo);
            pnlGeneral.Dock = DockStyle.Fill;
            pnlGeneral.Location = new Point(0, 0);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Padding = new Padding(40);
            pnlGeneral.Size = new Size(914, 600);
            pnlGeneral.TabIndex = 5;
            pnlGeneral.Paint += pnlGeneral_Paint_1;
            // 
            // dgvMedicamentosCliente
            // 
            dgvMedicamentosCliente.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMedicamentosCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicamentosCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicamentosCliente.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMedicamentosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicamentosCliente.ColumnHeadersHeight = 29;
            dgvMedicamentosCliente.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, descripcion, imagen, cantidad, precio });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvMedicamentosCliente.DefaultCellStyle = dataGridViewCellStyle8;
            dgvMedicamentosCliente.Dock = DockStyle.Fill;
            dgvMedicamentosCliente.Location = new Point(40, 140);
            dgvMedicamentosCliente.Margin = new Padding(3, 4, 3, 4);
            dgvMedicamentosCliente.MultiSelect = false;
            dgvMedicamentosCliente.Name = "dgvMedicamentosCliente";
            dgvMedicamentosCliente.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvMedicamentosCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvMedicamentosCliente.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMedicamentosCliente.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvMedicamentosCliente.RowTemplate.Height = 120;
            dgvMedicamentosCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentosCliente.Size = new Size(834, 420);
            dgvMedicamentosCliente.TabIndex = 8;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            ID.DefaultCellStyle = dataGridViewCellStyle3;
            ID.FillWeight = 40F;
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 50;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            ID.Width = 88;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            nombre.DefaultCellStyle = dataGridViewCellStyle4;
            nombre.FillWeight = 70F;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 153;
            // 
            // descripcion
            // 
            descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descripcion.DataPropertyName = "descripcion";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
            descripcion.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopLeft;
            cantidad.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopLeft;
            precio.DefaultCellStyle = dataGridViewCellStyle7;
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
            lblTitulo.Location = new Point(40, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(834, 100);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Inventario";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InventarioCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__1_;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlGeneral);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventarioCli";
            Text = "InventarioCli";
            Load += InventarioCli_Load;
            pnlGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentosCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGeneral;
        private Label lblTitulo;
        private DataGridView dgvMedicamentosCliente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewImageColumn imagen;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
    }
}