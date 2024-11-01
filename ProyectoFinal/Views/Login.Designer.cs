namespace ProyectoFinal
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UsuarioLogin = new System.Windows.Forms.TextBox();
            this.txt_ContrasenaLogin = new System.Windows.Forms.TextBox();
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario (RUT sin guion)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txt_UsuarioLogin
            // 
            this.txt_UsuarioLogin.Location = new System.Drawing.Point(52, 50);
            this.txt_UsuarioLogin.Name = "txt_UsuarioLogin";
            this.txt_UsuarioLogin.Size = new System.Drawing.Size(148, 20);
            this.txt_UsuarioLogin.TabIndex = 0;
            this.txt_UsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UsuarioLogin_KeyPress);
            // 
            // txt_ContrasenaLogin
            // 
            this.txt_ContrasenaLogin.Location = new System.Drawing.Point(52, 100);
            this.txt_ContrasenaLogin.Name = "txt_ContrasenaLogin";
            this.txt_ContrasenaLogin.PasswordChar = '*';
            this.txt_ContrasenaLogin.Size = new System.Drawing.Size(148, 20);
            this.txt_ContrasenaLogin.TabIndex = 1;
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarSesion.Location = new System.Drawing.Point(82, 126);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(89, 29);
            this.btn_IniciarSesion.TabIndex = 4;
            this.btn_IniciarSesion.Text = "Iniciar sesión";
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.Location = new System.Drawing.Point(52, 193);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(148, 29);
            this.btn_Registrar.TabIndex = 5;
            this.btn_Registrar.Text = "Solicitar registro";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿No tiene cuenta?\r\n  Solicite registro\r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.txt_ContrasenaLogin);
            this.Controls.Add(this.txt_UsuarioLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UsuarioLogin;
        private System.Windows.Forms.TextBox txt_ContrasenaLogin;
        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label label3;
    }
}