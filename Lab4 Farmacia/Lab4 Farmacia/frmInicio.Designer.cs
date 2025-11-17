namespace Lab4_Farmacia
{
    partial class frmInicioAdmin
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
            mnAdmin = new MenuStrip();
            medicamentosToolStripMenuItem = new ToolStripMenuItem();
            inventariosToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            sesionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            mnAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // mnAdmin
            // 
            mnAdmin.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnAdmin.ImageScalingSize = new Size(20, 20);
            mnAdmin.Items.AddRange(new ToolStripItem[] { medicamentosToolStripMenuItem, inventariosToolStripMenuItem, pedidosToolStripMenuItem, sesionToolStripMenuItem, toolStripMenuItem1 });
            mnAdmin.Location = new Point(0, 0);
            mnAdmin.Name = "mnAdmin";
            mnAdmin.Padding = new Padding(7, 3, 0, 3);
            mnAdmin.Size = new Size(914, 45);
            mnAdmin.TabIndex = 1;
            mnAdmin.Text = "MenuAdmin";
            // 
            // medicamentosToolStripMenuItem
            // 
            medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            medicamentosToolStripMenuItem.Size = new Size(253, 39);
            medicamentosToolStripMenuItem.Text = "Medicamentos";
            medicamentosToolStripMenuItem.Click += medicamentosToolStripMenuItem_Click;
            // 
            // inventariosToolStripMenuItem
            // 
            inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            inventariosToolStripMenuItem.Size = new Size(223, 39);
            inventariosToolStripMenuItem.Text = "Inventarios";
            inventariosToolStripMenuItem.Click += inventariosToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(152, 39);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // sesionToolStripMenuItem
            // 
            sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            sesionToolStripMenuItem.Size = new Size(132, 39);
            sesionToolStripMenuItem.Text = "Sesion";
            sesionToolStripMenuItem.Click += sesionToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 39);
            // 
            // frmInicioAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(mnAdmin);
            IsMdiContainer = true;
            MainMenuStrip = mnAdmin;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInicioAdmin";
            Text = "frmInicioAdmin";
            Load += frmInicioAdmin_Load;
            mnAdmin.ResumeLayout(false);
            mnAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnAdmin;
        private ToolStripMenuItem medicamentosToolStripMenuItem;
        private ToolStripMenuItem inventariosToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem sesionToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}