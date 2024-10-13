namespace ProyectoFinal
{
    partial class ModificarStock
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
            this.txt_Nuevo_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Nueve_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_Guardar_Modificacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Nuevo_Nombre
            // 
            this.txt_Nuevo_Nombre.Location = new System.Drawing.Point(29, 37);
            this.txt_Nuevo_Nombre.Name = "txt_Nuevo_Nombre";
            this.txt_Nuevo_Nombre.Size = new System.Drawing.Size(164, 20);
            this.txt_Nuevo_Nombre.TabIndex = 0;
            // 
            // txt_Nueve_Cantidad
            // 
            this.txt_Nueve_Cantidad.Location = new System.Drawing.Point(29, 96);
            this.txt_Nueve_Cantidad.Name = "txt_Nueve_Cantidad";
            this.txt_Nueve_Cantidad.Size = new System.Drawing.Size(164, 20);
            this.txt_Nueve_Cantidad.TabIndex = 1;
            // 
            // btn_Guardar_Modificacion
            // 
            this.btn_Guardar_Modificacion.Location = new System.Drawing.Point(41, 145);
            this.btn_Guardar_Modificacion.Name = "btn_Guardar_Modificacion";
            this.btn_Guardar_Modificacion.Size = new System.Drawing.Size(134, 32);
            this.btn_Guardar_Modificacion.TabIndex = 3;
            this.btn_Guardar_Modificacion.Text = "Guardar";
            this.btn_Guardar_Modificacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // ModificarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Guardar_Modificacion);
            this.Controls.Add(this.txt_Nueve_Cantidad);
            this.Controls.Add(this.txt_Nuevo_Nombre);
            this.Name = "ModificarStock";
            this.Text = "ModificarStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nuevo_Nombre;
        private System.Windows.Forms.TextBox txt_Nueve_Cantidad;
        private System.Windows.Forms.Button btn_Guardar_Modificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}