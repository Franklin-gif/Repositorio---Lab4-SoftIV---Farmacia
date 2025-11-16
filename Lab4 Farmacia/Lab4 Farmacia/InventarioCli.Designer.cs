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
            menuStrip1 = new MenuStrip();
            inventariosToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            sesionToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentosCliente).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btnActualizarCli);
            panel1.Controls.Add(dgvMedicamentosCliente);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 423);
            panel1.TabIndex = 0;
            // 
            // btnActualizarCli
            // 
            btnActualizarCli.BackColor = Color.DimGray;
            btnActualizarCli.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarCli.ForeColor = SystemColors.ButtonFace;
            btnActualizarCli.Location = new Point(347, 300);
            btnActualizarCli.Name = "btnActualizarCli";
            btnActualizarCli.Size = new Size(107, 40);
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
            dgvMedicamentosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentosCliente.Location = new Point(144, 80);
            dgvMedicamentosCliente.Name = "dgvMedicamentosCliente";
            dgvMedicamentosCliente.ReadOnly = true;
            dgvMedicamentosCliente.Size = new Size(500, 191);
            dgvMedicamentosCliente.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventariosToolStripMenuItem, pedidosToolStripMenuItem, sesionToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // inventariosToolStripMenuItem
            // 
            inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            inventariosToolStripMenuItem.Size = new Size(103, 20);
            inventariosToolStripMenuItem.Text = "Inventarios";
            inventariosToolStripMenuItem.Click += inventariosToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(71, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // sesionToolStripMenuItem
            // 
            sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            sesionToolStripMenuItem.Size = new Size(63, 20);
            sesionToolStripMenuItem.Text = "Sesion";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(117, 20);
            cerrarSesionToolStripMenuItem.Text = "cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // InventarioCli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "InventarioCli";
            Text = "InventarioCli";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentosCliente).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventariosToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem sesionToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private DataGridView dgvMedicamentosCliente;
        private Button btnActualizarCli;
    }
}