namespace Lab4_Farmacia
{
    partial class frmPedidosCli
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvPedidosCli = new DataGridView();
            IDCliente = new DataGridViewTextBoxColumn();
            medicamento = new DataGridViewTextBoxColumn();
            cantidadCliente = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            lblPedidos = new Label();
            groupBox3 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnOrdenar = new Button();
            lblNom = new Label();
            txtNom = new TextBox();
            lblCant = new Label();
            nudCant = new NumericUpDown();
            lblInventario = new Label();
            dgvInv = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            imagen = new DataGridViewImageColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosCli).BeginInit();
            groupBox3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInv).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvPedidosCli, 0, 3);
            tableLayoutPanel1.Controls.Add(lblPedidos, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 4);
            tableLayoutPanel1.Controls.Add(lblInventario, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvInv, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(914, 619);
            tableLayoutPanel1.TabIndex = 17;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dgvPedidosCli
            // 
            dgvPedidosCli.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPedidosCli.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedidosCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidosCli.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPedidosCli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPedidosCli.ColumnHeadersHeight = 29;
            dgvPedidosCli.Columns.AddRange(new DataGridViewColumn[] { IDCliente, medicamento, cantidadCliente, total, fecha });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvPedidosCli.DefaultCellStyle = dataGridViewCellStyle7;
            dgvPedidosCli.Dock = DockStyle.Fill;
            dgvPedidosCli.Location = new Point(30, 245);
            dgvPedidosCli.Margin = new Padding(30, 0, 30, 0);
            dgvPedidosCli.MultiSelect = false;
            dgvPedidosCli.Name = "dgvPedidosCli";
            dgvPedidosCli.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvPedidosCli.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvPedidosCli.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPedidosCli.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvPedidosCli.RowTemplate.Height = 120;
            dgvPedidosCli.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidosCli.Size = new Size(854, 123);
            dgvPedidosCli.TabIndex = 20;
            // 
            // IDCliente
            // 
            IDCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IDCliente.DataPropertyName = "id";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            IDCliente.DefaultCellStyle = dataGridViewCellStyle3;
            IDCliente.FillWeight = 40F;
            IDCliente.Frozen = true;
            IDCliente.HeaderText = "ID";
            IDCliente.MinimumWidth = 50;
            IDCliente.Name = "IDCliente";
            IDCliente.ReadOnly = true;
            IDCliente.Resizable = DataGridViewTriState.True;
            IDCliente.Width = 88;
            // 
            // medicamento
            // 
            medicamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            medicamento.DataPropertyName = "medicamento";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            medicamento.DefaultCellStyle = dataGridViewCellStyle4;
            medicamento.FillWeight = 70F;
            medicamento.HeaderText = "Medicamento";
            medicamento.MinimumWidth = 6;
            medicamento.Name = "medicamento";
            medicamento.ReadOnly = true;
            medicamento.Width = 153;
            // 
            // cantidadCliente
            // 
            cantidadCliente.DataPropertyName = "cantidad";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
            cantidadCliente.DefaultCellStyle = dataGridViewCellStyle5;
            cantidadCliente.FillWeight = 45F;
            cantidadCliente.HeaderText = "Cantidad";
            cantidadCliente.MinimumWidth = 6;
            cantidadCliente.Name = "cantidadCliente";
            cantidadCliente.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.DataPropertyName = "total";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopLeft;
            total.DefaultCellStyle = dataGridViewCellStyle6;
            total.FillWeight = 45F;
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "fecha";
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // lblPedidos
            // 
            lblPedidos.Anchor = AnchorStyles.None;
            lblPedidos.BackColor = Color.Transparent;
            lblPedidos.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedidos.ForeColor = SystemColors.Window;
            lblPedidos.Location = new Point(3, 199);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(908, 30);
            lblPedidos.TabIndex = 19;
            lblPedidos.Text = "Pedidos realizados";
            lblPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(10, 378);
            groupBox3.Margin = new Padding(10);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(894, 231);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pedido";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnOrdenar, 0, 4);
            tableLayoutPanel2.Controls.Add(lblNom, 0, 0);
            tableLayoutPanel2.Controls.Add(txtNom, 0, 1);
            tableLayoutPanel2.Controls.Add(lblCant, 0, 2);
            tableLayoutPanel2.Controls.Add(nudCant, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 39.5061722F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60.4938278F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(888, 203);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Anchor = AnchorStyles.Top;
            btnOrdenar.BackColor = SystemColors.ButtonFace;
            btnOrdenar.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrdenar.ForeColor = Color.Black;
            btnOrdenar.Location = new Point(302, 159);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(283, 41);
            btnOrdenar.TabIndex = 22;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click_1;
            // 
            // lblNom
            // 
            lblNom.Anchor = AnchorStyles.None;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNom.ForeColor = SystemColors.Window;
            lblNom.Location = new Point(3, 1);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(882, 24);
            lblNom.TabIndex = 14;
            lblNom.Text = "Nombre";
            lblNom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNom
            // 
            txtNom.Anchor = AnchorStyles.Top;
            txtNom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNom.Location = new Point(313, 31);
            txtNom.Margin = new Padding(3, 4, 3, 4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(262, 34);
            txtNom.TabIndex = 21;
            // 
            // lblCant
            // 
            lblCant.Anchor = AnchorStyles.None;
            lblCant.BackColor = Color.Transparent;
            lblCant.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCant.ForeColor = SystemColors.Window;
            lblCant.Location = new Point(3, 69);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(882, 30);
            lblCant.TabIndex = 15;
            lblCant.Text = "Cantidad";
            lblCant.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudCant
            // 
            nudCant.Anchor = AnchorStyles.Top;
            nudCant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCant.Location = new Point(307, 105);
            nudCant.Margin = new Padding(3, 4, 3, 4);
            nudCant.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nudCant.Name = "nudCant";
            nudCant.Size = new Size(273, 34);
            nudCant.TabIndex = 12;
            // 
            // lblInventario
            // 
            lblInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInventario.BackColor = Color.Transparent;
            lblInventario.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventario.ForeColor = SystemColors.Window;
            lblInventario.Location = new Point(3, 0);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(908, 61);
            lblInventario.TabIndex = 16;
            lblInventario.Text = "Inventario (Seleccione un medicamento de la lista)";
            lblInventario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvInv
            // 
            dgvInv.AllowUserToAddRows = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInv.BackgroundColor = Color.White;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvInv.ColumnHeadersHeight = 29;
            dgvInv.Columns.AddRange(new DataGridViewColumn[] { ID, nombre, descripcion, imagen, cantidad, precio });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = SystemColors.Window;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvInv.DefaultCellStyle = dataGridViewCellStyle17;
            dgvInv.Dock = DockStyle.Fill;
            dgvInv.Location = new Point(30, 61);
            dgvInv.Margin = new Padding(30, 0, 30, 0);
            dgvInv.MultiSelect = false;
            dgvInv.Name = "dgvInv";
            dgvInv.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvInv.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dgvInv.RowHeadersWidth = 51;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvInv.RowsDefaultCellStyle = dataGridViewCellStyle19;
            dgvInv.RowTemplate.Height = 120;
            dgvInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInv.Size = new Size(854, 123);
            dgvInv.TabIndex = 15;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "id";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.TopLeft;
            ID.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.TopLeft;
            nombre.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.TopLeft;
            descripcion.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.TopLeft;
            cantidad.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.TopLeft;
            precio.DefaultCellStyle = dataGridViewCellStyle16;
            precio.FillWeight = 45F;
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // frmPedidosCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__1_;
            ClientSize = new Size(914, 619);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPedidosCli";
            Text = "frmPedidosCli";
            Load += frmPedidosCli_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidosCli).EndInit();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvInv;
        private Label lblPedidos;
        private GroupBox groupBox3;
        private Label lblInventario;
        private DataGridView dgvPedidosCli;
        private DataGridViewTextBoxColumn IDCliente;
        private DataGridViewTextBoxColumn medicamento;
        private DataGridViewTextBoxColumn cantidadCliente;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewImageColumn imagen;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblNom;
        private Button btnOrdenar;
        private TextBox txtNom;
        private Label lblCant;
        private NumericUpDown nudCant;
    }
}