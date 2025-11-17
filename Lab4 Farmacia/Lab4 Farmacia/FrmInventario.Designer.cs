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
            pnlGeneral = new Panel();
            dgvInventario = new DataGridView();
            lblTitulo = new Label();
            pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // pnlGeneral
            // 
            pnlGeneral.BackColor = Color.Transparent;
            pnlGeneral.Controls.Add(dgvInventario);
            pnlGeneral.Dock = DockStyle.Fill;
            pnlGeneral.Location = new Point(0, 0);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Padding = new Padding(40);
            pnlGeneral.Size = new Size(965, 507);
            pnlGeneral.TabIndex = 4;
            // 
            // dgvInventario
            // 
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.Location = new Point(40, 40);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.Size = new Size(885, 427);
            dgvInventario.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Stencil", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(965, 149);
            lblTitulo.TabIndex = 5;
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
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlGeneral;
        private DataGridView dgvInventario;
        private Label lblTitulo;
    }
}