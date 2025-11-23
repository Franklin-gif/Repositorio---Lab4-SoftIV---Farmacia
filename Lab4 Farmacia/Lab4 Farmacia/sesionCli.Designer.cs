namespace Lab4_Farmacia
{
    partial class sesionCli
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblUsuario = new Label();
            lblRol = new Label();
            btnCerrarSesion = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblUsuario, 0, 0);
            tableLayoutPanel1.Controls.Add(lblRol, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCerrarSesion, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 208F));
            tableLayoutPanel1.Size = new Size(900, 517);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Bottom;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Window;
            lblUsuario.Location = new Point(3, 37);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(894, 117);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = SystemColors.Window;
            lblRol.Location = new Point(3, 179);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(894, 104);
            lblRol.TabIndex = 13;
            lblRol.Text = "Rol";
            lblRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top;
            btnCerrarSesion.BackColor = SystemColors.ButtonFace;
            btnCerrarSesion.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(179, 311);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(542, 76);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // sesionCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__1_;
            ClientSize = new Size(900, 517);
            Controls.Add(tableLayoutPanel1);
            Name = "sesionCli";
            Text = "sesionCli";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUsuario;
        private Label lblRol;
        private Button btnCerrarSesion;
    }
}