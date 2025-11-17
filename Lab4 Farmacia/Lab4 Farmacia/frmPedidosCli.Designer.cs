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
            grpPedido = new GroupBox();
            btnConfirmarPedido = new Button();
            label1 = new Label();
            nudCant = new NumericUpDown();
            textBox1 = new TextBox();
            label2 = new Label();
            dgvMedicamentos = new DataGridView();
            Medicamento = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
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
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 446);
            panel1.TabIndex = 2;
            // 
            // grpPedido
            // 
            grpPedido.Controls.Add(btnConfirmarPedido);
            grpPedido.Controls.Add(label1);
            grpPedido.Controls.Add(nudCant);
            grpPedido.Controls.Add(textBox1);
            grpPedido.Controls.Add(label2);
            grpPedido.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPedido.ForeColor = Color.Black;
            grpPedido.Location = new Point(474, 112);
            grpPedido.Name = "grpPedido";
            grpPedido.Size = new Size(312, 253);
            grpPedido.TabIndex = 13;
            grpPedido.TabStop = false;
            grpPedido.Text = "Pedido";
            // 
            // btnConfirmarPedido
            // 
            btnConfirmarPedido.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmarPedido.Location = new Point(94, 195);
            btnConfirmarPedido.Name = "btnConfirmarPedido";
            btnConfirmarPedido.Size = new Size(109, 33);
            btnConfirmarPedido.TabIndex = 13;
            btnConfirmarPedido.Text = "Ordenar";
            btnConfirmarPedido.UseVisualStyleBackColor = true;
          
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 39);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // nudCant
            // 
            nudCant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCant.Location = new Point(133, 125);
            nudCant.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            nudCant.Name = "nudCant";
            nudCant.Size = new Size(157, 29);
            nudCant.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 25);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 125);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 3;
            label2.Text = "Cantidad";
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Columns.AddRange(new DataGridViewColumn[] { Medicamento, Cantidad, Costo });
            dgvMedicamentos.Location = new Point(21, 60);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.Size = new Size(436, 305);
            dgvMedicamentos.TabIndex = 4;
            // 
            // Medicamento
            // 
            Medicamento.HeaderText = "Medicamento";
            Medicamento.Name = "Medicamento";
            Medicamento.Width = 140;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Costo
            // 
            Costo.HeaderText = "Costo";
            Costo.Name = "Costo";
            Costo.Width = 102;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(175, 383);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(114, 33);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // frmPedidosCli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmPedidosCli";
            Text = "frmPedidosCli";
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
        private TextBox textBox1;
        private DataGridView dgvMedicamentos;
        private Label label2;
        private NumericUpDown nudCant;
        private GroupBox grpPedido;
        private Button btnConfirmarPedido;
        private DataGridViewTextBoxColumn Medicamento;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Costo;
        private Button btnActualizar;
    }
}