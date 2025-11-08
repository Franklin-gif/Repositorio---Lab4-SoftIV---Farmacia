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
            button1 = new Button();
            label1 = new Label();
            lblUsuario = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btmIniciarSesion = new Button();
            lblFarmatec = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btmIniciarSesion);
            panel1.Controls.Add(lblFarmatec);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(287, 343);
            button1.Name = "button1";
            button1.Size = new Size(110, 27);
            button1.TabIndex = 6;
            button1.Text = "Registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            lblUsuario.ForeColor = Color.Transparent;
            lblUsuario.Location = new Point(322, 105);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 16);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(322, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 22);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 22);
            textBox1.TabIndex = 2;
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
            lblFarmatec.ForeColor = Color.Transparent;
            lblFarmatec.Location = new Point(304, 16);
            lblFarmatec.Name = "lblFarmatec";
            lblFarmatec.Size = new Size(195, 42);
            lblFarmatec.TabIndex = 0;
            lblFarmatec.Text = "FARMATEC";
            lblFarmatec.Click += lblFarmatec_Click;
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label lblUsuario;
    }
}
