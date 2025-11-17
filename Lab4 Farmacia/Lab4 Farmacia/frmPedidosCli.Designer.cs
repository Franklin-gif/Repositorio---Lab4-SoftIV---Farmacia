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
            panel1 = new Panel();
            btnActualizar = new Button();
            grpPedido = new GroupBox();
            btnConfirmarPedido = new Button();
            label1 = new Label();
            nudCant = new NumericUpDown();
            txtNom = new TextBox();
            label2 = new Label();
            dgvMedicamentos = new DataGridView();
            panel1.SuspendLayout();
            grpPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(grpPedido);
            panel1.Controls.Add(dgvMedicamentos);
            panel1.Location = new Point(2, 5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(911, 595);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(421, 296);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(130, 44);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // grpPedido
            // 
            grpPedido.Controls.Add(btnConfirmarPedido);
            grpPedido.Controls.Add(label1);
            grpPedido.Controls.Add(nudCant);
            grpPedido.Controls.Add(txtNom);
            grpPedido.Controls.Add(label2);
            grpPedido.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPedido.ForeColor = Color.Black;
            grpPedido.Location = new Point(215, 360);
            grpPedido.Margin = new Padding(3, 4, 3, 4);
            grpPedido.Name = "grpPedido";
            grpPedido.Padding = new Padding(3, 4, 3, 4);
            grpPedido.Size = new Size(552, 205);
            grpPedido.TabIndex = 13;
            grpPedido.TabStop = false;
            grpPedido.Text = "Pedido";
            // 
            // btnConfirmarPedido
            // 
            btnConfirmarPedido.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmarPedido.Location = new Point(211, 153);
            btnConfirmarPedido.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarPedido.Name = "btnConfirmarPedido";
            btnConfirmarPedido.Size = new Size(125, 44);
            btnConfirmarPedido.TabIndex = 13;
            btnConfirmarPedido.Text = "Ordenar";
            btnConfirmarPedido.UseVisualStyleBackColor = true;
            btnConfirmarPedido.Click += btnConfirmarPedido_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 29);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // nudCant
            // 
            nudCant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCant.Location = new Point(251, 92);
            nudCant.Margin = new Padding(3, 4, 3, 4);
            nudCant.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nudCant.Name = "nudCant";
            nudCant.Size = new Size(179, 34);
            nudCant.TabIndex = 12;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(251, 29);
            txtNom.Margin = new Padding(3, 4, 3, 4);
            txtNom.Multiline = true;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(202, 32);
            txtNom.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 97);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 3;
            label2.Text = "Cantidad";
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(167, 29);
            dgvMedicamentos.Margin = new Padding(3, 4, 3, 4);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.Size = new Size(621, 259);
            dgvMedicamentos.TabIndex = 4;
            // 
            // frmPedidosCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPedidosCli";
            Text = "frmPedidosCli";
            Load += frmPedidosCli_Load_1;
            panel1.ResumeLayout(false);
            grpPedido.ResumeLayout(false);
            grpPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCant).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TextBox txtNom;
        private DataGridView dgvMedicamentos;
        private Label label2;
        private NumericUpDown nudCant;
        private GroupBox grpPedido;
        private Button btnConfirmarPedido;
        private Button btnActualizar;
    }
}