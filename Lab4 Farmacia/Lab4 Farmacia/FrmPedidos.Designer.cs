namespace Lab4_Farmacia
{
    partial class FrmPedidos
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
            pnlGeneral = new Panel();
            dgvPedidos = new DataGridView();
            cliente = new DataGridViewTextBoxColumn();
            medicamentos = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // pnlGeneral
            // 
            pnlGeneral.BackColor = Color.Transparent;
            pnlGeneral.Controls.Add(dgvPedidos);
            pnlGeneral.Dock = DockStyle.Fill;
            pnlGeneral.Location = new Point(0, 0);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Padding = new Padding(40, 120, 40, 40);
            pnlGeneral.Size = new Size(998, 543);
            pnlGeneral.TabIndex = 5;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedidos.ColumnHeadersHeight = 29;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { cliente, medicamentos, cantidad, total, fecha });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.Location = new Point(40, 120);
            dgvPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.RowTemplate.Height = 120;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(918, 383);
            dgvPedidos.TabIndex = 4;
            // 
            // cliente
            // 
            cliente.DataPropertyName = "cliente";
            cliente.HeaderText = "Cliente";
            cliente.MinimumWidth = 6;
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            // 
            // medicamentos
            // 
            medicamentos.DataPropertyName = "medicamentos";
            medicamentos.HeaderText = "Medicamentos";
            medicamentos.MinimumWidth = 6;
            medicamentos.Name = "medicamentos";
            medicamentos.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "cantidad";
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // total
            // 
            total.DataPropertyName = "total";
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
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(998, 100);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Pedidos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__1_;
            ClientSize = new Size(998, 543);
            Controls.Add(lblTitulo);
            Controls.Add(pnlGeneral);
            Name = "FrmPedidos";
            Text = "FrmPedidos";
            Load += FrmPedidos_Load;
            pnlGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGeneral;
        private DataGridView dgvPedidos;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn medicamentos;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn fecha;
    }
}