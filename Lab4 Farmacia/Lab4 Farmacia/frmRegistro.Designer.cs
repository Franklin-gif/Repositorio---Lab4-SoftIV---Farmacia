namespace Lab4_Farmacia
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            tlpGeneral = new TableLayoutPanel();
            btnRegistro = new Button();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lblTit = new Label();
            lblContra = new Label();
            tlpGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // tlpGeneral
            // 
            tlpGeneral.AllowDrop = true;
            tlpGeneral.BackColor = Color.Transparent;
            tlpGeneral.BackgroundImageLayout = ImageLayout.Stretch;
            tlpGeneral.ColumnCount = 1;
            tlpGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpGeneral.Controls.Add(btnRegistro, 0, 5);
            tlpGeneral.Controls.Add(lblUsuario, 0, 1);
            tlpGeneral.Controls.Add(txtUsuario, 0, 2);
            tlpGeneral.Controls.Add(txtContraseña, 0, 4);
            tlpGeneral.Controls.Add(lblTit, 0, 0);
            tlpGeneral.Controls.Add(lblContra, 0, 3);
            tlpGeneral.Dock = DockStyle.Fill;
            tlpGeneral.Location = new Point(0, 0);
            tlpGeneral.Name = "tlpGeneral";
            tlpGeneral.RowCount = 6;
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 24.8211021F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 10.166667F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 7.33333349F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpGeneral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpGeneral.Size = new Size(914, 600);
            tlpGeneral.TabIndex = 17;
            // 
            // btnRegistro
            // 
            btnRegistro.Anchor = AnchorStyles.Top;
            btnRegistro.BackColor = SystemColors.ButtonFace;
            btnRegistro.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = Color.Black;
            btnRegistro.Location = new Point(305, 422);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(303, 44);
            btnRegistro.TabIndex = 16;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Window;
            lblUsuario.Location = new Point(3, 183);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(908, 35);
            lblUsuario.TabIndex = 23;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top;
            txtUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(326, 222);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(262, 47);
            txtUsuario.TabIndex = 20;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Top;
            txtContraseña.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(322, 327);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(269, 47);
            txtContraseña.TabIndex = 26;
            // 
            // lblTit
            // 
            lblTit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTit.AutoSize = true;
            lblTit.BackColor = Color.Transparent;
            lblTit.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTit.ForeColor = SystemColors.Window;
            lblTit.Location = new Point(3, 27);
            lblTit.Name = "lblTit";
            lblTit.Size = new Size(908, 95);
            lblTit.TabIndex = 24;
            lblTit.Text = "FarmaTEC";
            lblTit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContra
            // 
            lblContra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContra.AutoSize = true;
            lblContra.BackColor = Color.Transparent;
            lblContra.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContra.ForeColor = SystemColors.Window;
            lblContra.Location = new Point(3, 288);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(908, 35);
            lblContra.TabIndex = 25;
            lblContra.Text = "Contraseña";
            lblContra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(tlpGeneral);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistro";
            Text = "frmRegistro";
            Load += frmRegistro_Load;
            tlpGeneral.ResumeLayout(false);
            tlpGeneral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpGeneral;
        private TextBox txtContraseña;
        private Label lblContra;
        private Label lblTit;
        private Button btnRegistro;
        private Label lblUsuario;
        private TextBox txtUsuario;
    }
}