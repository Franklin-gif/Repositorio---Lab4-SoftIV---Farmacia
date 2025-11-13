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
            panel1 = new Panel();
            btmRegistro = new Button();
            label1 = new Label();
            lblUsuario = new Label();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            btmIniciarSesion = new Button();
            lblFarmatec = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btmRegistro);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtContra);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btmIniciarSesion);
            panel1.Controls.Add(lblFarmatec);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btmRegistro
            // 
            btmRegistro.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmRegistro.Location = new Point(287, 343);
            btmRegistro.Name = "btmRegistro";
            btmRegistro.Size = new Size(110, 27);
            btmRegistro.TabIndex = 6;
            btmRegistro.Text = "Registro";
            btmRegistro.UseVisualStyleBackColor = true;
            btmRegistro.Click += btmRegistro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 9.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(322, 212);
            label1.Name = "label1";
            label1.Size = new Size(89, 16);
            label1.TabIndex = 5;
            label1.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Stencil", 9.75F);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(322, 105);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 16);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(322, 231);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(154, 22);
            txtContra.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(322, 127);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(154, 22);
            txtUsuario.TabIndex = 2;
            // 
            // btmIniciarSesion
            // 
            btmIniciarSesion.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmIniciarSesion.Location = new Point(417, 344);
            btmIniciarSesion.Name = "btmIniciarSesion";
            btmIniciarSesion.Size = new Size(110, 26);
            btmIniciarSesion.TabIndex = 1;
            btmIniciarSesion.Text = "Iniciar";
            btmIniciarSesion.UseVisualStyleBackColor = true;
            btmIniciarSesion.Click += btmIniciarSesion_Click;
            // 
            // lblFarmatec
            // 
            lblFarmatec.AutoSize = true;
            lblFarmatec.BackColor = Color.Transparent;
            lblFarmatec.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFarmatec.ForeColor = Color.White;
            lblFarmatec.Location = new Point(304, 16);
            lblFarmatec.Name = "lblFarmatec";
            lblFarmatec.Size = new Size(195, 42);
            lblFarmatec.TabIndex = 0;
            lblFarmatec.Text = "FARMATEC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Inicio De Sesion";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblFarmatec;
        private Button btmIniciarSesion;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Button btmRegistro;
        private Label label1;
        private Label lblUsuario;
    }
}
