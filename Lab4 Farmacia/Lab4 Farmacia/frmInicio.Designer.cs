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
            mnAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // mnAdmin
            // 
            mnAdmin.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnAdmin.ImageScalingSize = new Size(20, 20);
            mnAdmin.Items.AddRange(new ToolStripItem[] { medicamentosToolStripMenuItem, inventariosToolStripMenuItem, pedidosToolStripMenuItem, sesionToolStripMenuItem });
            mnAdmin.Location = new Point(0, 0);
            mnAdmin.Name = "mnAdmin";
            mnAdmin.Size = new Size(800, 24);
            mnAdmin.TabIndex = 1;
            mnAdmin.Text = "MenuAdmin";
            // 
            // medicamentosToolStripMenuItem
            // 
            medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            medicamentosToolStripMenuItem.Size = new Size(116, 20);
            medicamentosToolStripMenuItem.Text = "Medicamentos";
            medicamentosToolStripMenuItem.Click += medicamentosToolStripMenuItem_Click;
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
            sesionToolStripMenuItem.Click += sesionToolStripMenuItem_Click;
            // 
            // frmInicioAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnAdmin);
            IsMdiContainer = true;
            MainMenuStrip = mnAdmin;
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
    }
}