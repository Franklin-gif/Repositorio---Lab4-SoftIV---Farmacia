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
            panel1 = new Panel();
            btnActualizarCli = new Button();
            dgvMedicamentosCliente = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentosCliente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btnActualizarCli);
            panel1.Controls.Add(dgvMedicamentosCliente);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 604);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnActualizarCli
            // 
            btnActualizarCli.BackColor = Color.DimGray;
            btnActualizarCli.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarCli.ForeColor = SystemColors.ButtonFace;
            btnActualizarCli.Location = new Point(391, 435);
            btnActualizarCli.Margin = new Padding(3, 4, 3, 4);
            btnActualizarCli.Name = "btnActualizarCli";
            btnActualizarCli.Size = new Size(122, 53);
            btnActualizarCli.TabIndex = 1;
            btnActualizarCli.Text = "Actualizar";
            btnActualizarCli.UseVisualStyleBackColor = false;
            btnActualizarCli.Click += btnActualizarCli_Click;
            // 
            // dgvMedicamentosCliente
            // 
            dgvMedicamentosCliente.AllowUserToAddRows = false;
            dgvMedicamentosCliente.AllowUserToDeleteRows = false;
            dgvMedicamentosCliente.AllowUserToOrderColumns = true;
            dgvMedicamentosCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicamentosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentosCliente.Location = new Point(159, 160);
            dgvMedicamentosCliente.Margin = new Padding(3, 4, 3, 4);
            dgvMedicamentosCliente.Name = "dgvMedicamentosCliente";
            dgvMedicamentosCliente.ReadOnly = true;
            dgvMedicamentosCliente.RowHeadersWidth = 51;
            dgvMedicamentosCliente.Size = new Size(571, 255);
            dgvMedicamentosCliente.TabIndex = 0;
            dgvMedicamentosCliente.CellContentClick += dgvMedicamentosCliente_CellContentClick;
            // 
            // InventarioCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventarioCli";
            Text = "InventarioCli";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentosCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvMedicamentosCliente;
        private Button btnActualizarCli;
    }
}