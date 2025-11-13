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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioAdmin));
            menuStrip1 = new MenuStrip();
            medicamentosToolStripMenuItem = new ToolStripMenuItem();
            inventariosToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            sesionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { medicamentosToolStripMenuItem, inventariosToolStripMenuItem, pedidosToolStripMenuItem, sesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // medicamentosToolStripMenuItem
            // 
            medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            medicamentosToolStripMenuItem.Size = new Size(116, 20);
            medicamentosToolStripMenuItem.Text = "Medicamentos";
            // 
            // inventariosToolStripMenuItem
            // 
            inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            inventariosToolStripMenuItem.Size = new Size(103, 20);
            inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(71, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // sesionToolStripMenuItem
            // 
            sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            sesionToolStripMenuItem.Size = new Size(63, 20);
            sesionToolStripMenuItem.Text = "Sesion";
            // 
            // frmInicioAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "frmInicioAdmin";
            Text = "frmInicioAdmin";
            Load += frmInicioAdmin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem medicamentosToolStripMenuItem;
        private ToolStripMenuItem inventariosToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem sesionToolStripMenuItem;
    }
}