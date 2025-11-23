namespace Lab4_Farmacia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            txtContra = new TextBox();
            lblContra = new Label();
            lblTit = new Label();
            btnRegistro = new Button();
            btnIniciar = new Button();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtContra, 0, 4);
            tableLayoutPanel1.Controls.Add(lblContra, 0, 3);
            tableLayoutPanel1.Controls.Add(lblTit, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRegistro, 0, 6);
            tableLayoutPanel1.Controls.Add(btnIniciar, 0, 5);
            tableLayoutPanel1.Controls.Add(lblUsuario, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUsuario, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.1741734F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.21021F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0136776F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.454069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.4174175F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.558558F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.27027F));
            tableLayoutPanel1.Size = new Size(914, 666);
            tableLayoutPanel1.TabIndex = 16;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // txtContra
            // 
            txtContra.Anchor = AnchorStyles.Top;
            txtContra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.Location = new Point(322, 364);
            txtContra.Margin = new Padding(3, 4, 3, 4);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(270, 47);
            txtContra.TabIndex = 26;
            // 
            // lblContra
            // 
            lblContra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContra.AutoSize = true;
            lblContra.BackColor = Color.Transparent;
            lblContra.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContra.ForeColor = SystemColors.Window;
            lblContra.Location = new Point(3, 325);
            lblContra.Name = "lblContra";
            lblContra.Size = new Size(908, 35);
            lblContra.TabIndex = 25;
            lblContra.Text = "Contraseña";
            lblContra.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTit
            // 
            lblTit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTit.AutoSize = true;
            lblTit.BackColor = Color.Transparent;
            lblTit.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTit.ForeColor = SystemColors.Window;
            lblTit.Location = new Point(3, 32);
            lblTit.Name = "lblTit";
            lblTit.Size = new Size(908, 95);
            lblTit.TabIndex = 24;
            lblTit.Text = "FarmaTEC";
            lblTit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegistro
            // 
            btnRegistro.Anchor = AnchorStyles.Top;
            btnRegistro.BackColor = SystemColors.ButtonFace;
            btnRegistro.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = Color.Black;
            btnRegistro.Location = new Point(312, 533);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(290, 40);
            btnRegistro.TabIndex = 16;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top;
            btnIniciar.BackColor = SystemColors.ButtonFace;
            btnIniciar.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.Black;
            btnIniciar.Location = new Point(311, 477);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(291, 39);
            btnIniciar.TabIndex = 17;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Window;
            lblUsuario.Location = new Point(3, 191);
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
            txtUsuario.Location = new Point(326, 230);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(262, 47);
            txtUsuario.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 666);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "FrmInincioSesion";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRegistro;
        private TextBox txtUsuario;
        private Label lblTit;
        private Label lblUsuario;
        private TextBox txtContra;
        private Label lblContra;
        private Button btnIniciar;
    }
}
