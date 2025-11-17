namespace Lab4_Farmacia
{
    partial class sesion
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
            lblRol = new Label();
            lblUsuario = new Label();
            btnCerrarSesion = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = SystemColors.Window;
            lblRol.Location = new Point(376, 146);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(191, 89);
            lblRol.TabIndex = 13;
            lblRol.Text = "Rol";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Bottom;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Window;
            lblUsuario.Location = new Point(274, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(395, 88);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top;
            btnCerrarSesion.BackColor = SystemColors.ButtonFace;
            btnCerrarSesion.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(201, 257);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(542, 76);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblUsuario, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCerrarSesion, 0, 2);
            tableLayoutPanel1.Controls.Add(lblRol, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 273F));
            tableLayoutPanel1.Size = new Size(944, 527);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // sesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__1_;
            ClientSize = new Size(944, 527);
            Controls.Add(tableLayoutPanel1);
            Name = "sesion";
            Text = "sesion";
            Load += sesion_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblRol;
        private Label lblUsuario;
        private Button btnCerrarSesion;
        private TableLayoutPanel tableLayoutPanel1;
    }
}