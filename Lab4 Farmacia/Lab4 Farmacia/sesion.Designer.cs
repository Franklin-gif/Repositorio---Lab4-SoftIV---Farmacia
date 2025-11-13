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
            lblRol.Font = new Font("Stencil", 36F);
            lblRol.ForeColor = SystemColors.Window;
            lblRol.Location = new Point(393, 212);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(142, 71);
            lblRol.TabIndex = 13;
            lblRol.Text = "Rol";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Stencil", 36F);
            lblUsuario.ForeColor = SystemColors.Window;
            lblUsuario.Location = new Point(322, 104);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(287, 71);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.ButtonFace;
            btnCerrarSesion.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(322, 341);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(287, 76);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // sesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título__1_;
            ClientSize = new Size(944, 527);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblRol);
            Controls.Add(lblUsuario);
            Name = "sesion";
            Text = "sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRol;
        private Label lblUsuario;
        private Button btnCerrarSesion;
    }
}