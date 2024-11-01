namespace ProyectoFinal
{
    partial class Agregar_Insumos
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
            this.txt_NombreInsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_GuardarInsumos = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cantidad_Minima = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Insumo";
            // 
            // txt_NombreInsumo
            // 
            this.txt_NombreInsumo.Location = new System.Drawing.Point(19, 32);
            this.txt_NombreInsumo.Name = "txt_NombreInsumo";
            this.txt_NombreInsumo.Size = new System.Drawing.Size(201, 20);
            this.txt_NombreInsumo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(19, 82);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(201, 20);
            this.txt_Cantidad.TabIndex = 3;
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_Minima_KeyPress);
            // 
            // btn_GuardarInsumos
            // 
            this.btn_GuardarInsumos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarInsumos.Location = new System.Drawing.Point(19, 178);
            this.btn_GuardarInsumos.Name = "btn_GuardarInsumos";
            this.btn_GuardarInsumos.Size = new System.Drawing.Size(95, 27);
            this.btn_GuardarInsumos.TabIndex = 4;
            this.btn_GuardarInsumos.Text = "Guardar";
            this.btn_GuardarInsumos.UseVisualStyleBackColor = true;
            this.btn_GuardarInsumos.Click += new System.EventHandler(this.btn_GuardarInsumos_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(129, 178);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(91, 27);
            this.btn_Volver.TabIndex = 14;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad mínima para notificar";
            // 
            // txt_Cantidad_Minima
            // 
            this.txt_Cantidad_Minima.Location = new System.Drawing.Point(19, 140);
            this.txt_Cantidad_Minima.Name = "txt_Cantidad_Minima";
            this.txt_Cantidad_Minima.Size = new System.Drawing.Size(201, 20);
            this.txt_Cantidad_Minima.TabIndex = 16;
            this.txt_Cantidad_Minima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_Minima_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Cantidad_Minima);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Volver);
            this.panel1.Controls.Add(this.btn_GuardarInsumos);
            this.panel1.Controls.Add(this.txt_Cantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_NombreInsumo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 214);
            this.panel1.TabIndex = 2;
            // 
            // Agregar_Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 239);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Agregar_Insumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar insumos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NombreInsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button btn_GuardarInsumos;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cantidad_Minima;
        private System.Windows.Forms.Panel panel1;
    }
}