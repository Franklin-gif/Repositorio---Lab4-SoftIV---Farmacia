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
            btmRegistrar = new Button();
            label1 = new Label();
            lblUsuario = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblFarmatec = new Label();
            pctbox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctbox).BeginInit();
            SuspendLayout();
            // 
            // btmRegistrar
            // 
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(384, 485);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 36);
            button1.TabIndex = 13;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            btmRegistrar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmRegistrar.Location = new Point(336, 364);
            btmRegistrar.Name = "btmRegistrar";
            btmRegistrar.Size = new Size(110, 27);
            btmRegistrar.TabIndex = 13;
            btmRegistrar.Text = "Registrar";
            btmRegistrar.UseVisualStyleBackColor = true;
            btmRegistrar.Click += btmRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 9.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(360, 325);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 12;
            label1.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Stencil", 9.75F);
            lblUsuario.ForeColor = Color.Transparent;
            lblUsuario.Location = new Point(360, 183);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 20);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            textBox2.Location = new Point(360, 351);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 10;

            txtContraseña.Location = new Point(315, 263);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(154, 23);
            txtContraseña.TabIndex = 10;
            // 
            // txtUsuario
            // 
            textBox1.Location = new Point(360, 212);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 9;

            txtUsuario.Location = new Point(315, 159);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(154, 23);
            txtUsuario.TabIndex = 9;
            // 
            // lblFarmatec
            // 
            lblFarmatec.AutoSize = true;
            lblFarmatec.BackColor = Color.Transparent;
            lblFarmatec.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFarmatec.ForeColor = Color.Transparent;
            lblFarmatec.Location = new Point(333, 61);
            lblFarmatec.Name = "lblFarmatec";
            lblFarmatec.Size = new Size(244, 52);
            lblFarmatec.TabIndex = 7;
            lblFarmatec.Text = "FARMATEC";
            // 
            // pctbox
            // 
            pctbox.BackColor = Color.Transparent;
            pctbox.Image = (Image)resources.GetObject("pctbox.Image");
            pctbox.Location = new Point(216, -81);
            pctbox.Margin = new Padding(0);
            pctbox.Name = "pctbox";
            pctbox.Size = new Size(246, 247);
            pctbox.SizeMode = PictureBoxSizeMode.Zoom;
            pctbox.TabIndex = 14;
            pctbox.TabStop = false;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(lblFarmatec);
            Controls.Add(pctbox);
            Controls.Add(btmRegistrar);
            Controls.Add(label1);
            Controls.Add(lblUsuario);

            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);

            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);

            Name = "frmRegistro";
            Text = "frmRegistro";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pctbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmRegistrar;
        private Label label1;
        private Label lblUsuario;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblFarmatec;
        private PictureBox pctbox;
    }
}