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
            SuspendLayout();
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = SystemColors.Window;
            lblRol.Location = new Point(333, 166);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(64, 32);
            lblRol.TabIndex = 13;
            lblRol.Text = "Rol";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.Window;
            lblUsuario.Location = new Point(333, 105);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(138, 34);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.ButtonFace;
            btnCerrarSesion.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(282, 256);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(251, 57);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__1_;
            ClientSize = new Size(826, 395);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblRol);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "sesion";
            Text = "sesion";
            Load += sesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRol;
        private Label lblUsuario;
        private Button btnCerrarSesion;
    }
}