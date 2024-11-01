namespace ProyectoFinal
{
    partial class Registrar_Usuario
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
            this.txt_rutRegistro = new System.Windows.Forms.TextBox();
            this.txt_ConstrasenaRegistro = new System.Windows.Forms.TextBox();
            this.txt_CorreoRegistro = new System.Windows.Forms.TextBox();
            this.cmBox_CargoRegistro = new System.Windows.Forms.ComboBox();
            this.txt_telefonoRegistro = new System.Windows.Forms.TextBox();
            this.btn_Guardar_Nuevo = new System.Windows.Forms.Button();
            this.btn_LimpiarRegistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_NomApRegistro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_rutRegistro
            // 
            this.txt_rutRegistro.Location = new System.Drawing.Point(20, 34);
            this.txt_rutRegistro.Name = "txt_rutRegistro";
            this.txt_rutRegistro.Size = new System.Drawing.Size(234, 20);
            this.txt_rutRegistro.TabIndex = 0;
            this.txt_rutRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rutRegistro_KeyPress);
            // 
            // txt_ConstrasenaRegistro
            // 
            this.txt_ConstrasenaRegistro.Location = new System.Drawing.Point(21, 144);
            this.txt_ConstrasenaRegistro.Name = "txt_ConstrasenaRegistro";
            this.txt_ConstrasenaRegistro.PasswordChar = '*';
            this.txt_ConstrasenaRegistro.Size = new System.Drawing.Size(234, 20);
            this.txt_ConstrasenaRegistro.TabIndex = 2;
            // 
            // txt_CorreoRegistro
            // 
            this.txt_CorreoRegistro.Location = new System.Drawing.Point(21, 199);
            this.txt_CorreoRegistro.Name = "txt_CorreoRegistro";
            this.txt_CorreoRegistro.Size = new System.Drawing.Size(234, 20);
            this.txt_CorreoRegistro.TabIndex = 3;
            // 
            // cmBox_CargoRegistro
            // 
            this.cmBox_CargoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox_CargoRegistro.FormattingEnabled = true;
            this.cmBox_CargoRegistro.Location = new System.Drawing.Point(21, 254);
            this.cmBox_CargoRegistro.Name = "cmBox_CargoRegistro";
            this.cmBox_CargoRegistro.Size = new System.Drawing.Size(234, 21);
            this.cmBox_CargoRegistro.TabIndex = 4;
            // 
            // txt_telefonoRegistro
            // 
            this.txt_telefonoRegistro.Location = new System.Drawing.Point(21, 305);
            this.txt_telefonoRegistro.Name = "txt_telefonoRegistro";
            this.txt_telefonoRegistro.Size = new System.Drawing.Size(234, 20);
            this.txt_telefonoRegistro.TabIndex = 5;
            this.txt_telefonoRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefonoRegistro_KeyPress);
            // 
            // btn_Guardar_Nuevo
            // 
            this.btn_Guardar_Nuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar_Nuevo.Location = new System.Drawing.Point(54, 343);
            this.btn_Guardar_Nuevo.Name = "btn_Guardar_Nuevo";
            this.btn_Guardar_Nuevo.Size = new System.Drawing.Size(69, 26);
            this.btn_Guardar_Nuevo.TabIndex = 5;
            this.btn_Guardar_Nuevo.Text = "Guardar";
            this.btn_Guardar_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Guardar_Nuevo.Click += new System.EventHandler(this.btn_Guardar_Nuevo_Click);
            // 
            // btn_LimpiarRegistro
            // 
            this.btn_LimpiarRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimpiarRegistro.Location = new System.Drawing.Point(149, 343);
            this.btn_LimpiarRegistro.Name = "btn_LimpiarRegistro";
            this.btn_LimpiarRegistro.Size = new System.Drawing.Size(66, 26);
            this.btn_LimpiarRegistro.TabIndex = 6;
            this.btn_LimpiarRegistro.Text = "Limpiar";
            this.btn_LimpiarRegistro.UseVisualStyleBackColor = true;
            this.btn_LimpiarRegistro.Click += new System.EventHandler(this.btn_LimpiarRegistro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_NomApRegistro);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_Volver);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_ConstrasenaRegistro);
            this.panel1.Controls.Add(this.btn_LimpiarRegistro);
            this.panel1.Controls.Add(this.btn_Guardar_Nuevo);
            this.panel1.Controls.Add(this.txt_rutRegistro);
            this.panel1.Controls.Add(this.txt_CorreoRegistro);
            this.panel1.Controls.Add(this.txt_telefonoRegistro);
            this.panel1.Controls.Add(this.cmBox_CargoRegistro);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 414);
            this.panel1.TabIndex = 7;
            // 
            // txt_NomApRegistro
            // 
            this.txt_NomApRegistro.Location = new System.Drawing.Point(21, 91);
            this.txt_NomApRegistro.Name = "txt_NomApRegistro";
            this.txt_NomApRegistro.Size = new System.Drawing.Size(235, 20);
            this.txt_NomApRegistro.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "RUT";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(104, 375);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(67, 28);
            this.btn_Volver.TabIndex = 13;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "*Opcional*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Número de teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Correo electrónico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombres y apellidos";
            // 
            // Registrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 436);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Registrar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rutRegistro;
        private System.Windows.Forms.TextBox txt_ConstrasenaRegistro;
        private System.Windows.Forms.TextBox txt_CorreoRegistro;
        private System.Windows.Forms.ComboBox cmBox_CargoRegistro;
        private System.Windows.Forms.TextBox txt_telefonoRegistro;
        private System.Windows.Forms.Button btn_Guardar_Nuevo;
        private System.Windows.Forms.Button btn_LimpiarRegistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.TextBox txt_NomApRegistro;
        private System.Windows.Forms.Label label7;
    }
}