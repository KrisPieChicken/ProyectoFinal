namespace ProyectoFinal.Views
{
    partial class VerSolicitudesRegistro
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
            this.grillaSolicitudesRegistro = new System.Windows.Forms.DataGridView();
            this.Dato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aceptar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Rechazar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSolicitudesRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Solicitudes de registro";
            // 
            // grillaSolicitudesRegistro
            // 
            this.grillaSolicitudesRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSolicitudesRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dato1,
            this.Dato3,
            this.Dato2,
            this.Aceptar,
            this.Rechazar});
            this.grillaSolicitudesRegistro.Location = new System.Drawing.Point(12, 56);
            this.grillaSolicitudesRegistro.Name = "grillaSolicitudesRegistro";
            this.grillaSolicitudesRegistro.Size = new System.Drawing.Size(650, 187);
            this.grillaSolicitudesRegistro.TabIndex = 4;
            // 
            // Dato1
            // 
            this.Dato1.HeaderText = "Dato1";
            this.Dato1.Name = "Dato1";
            // 
            // Dato3
            // 
            this.Dato3.HeaderText = "dato3";
            this.Dato3.Name = "Dato3";
            // 
            // Dato2
            // 
            this.Dato2.HeaderText = "Dato2";
            this.Dato2.Name = "Dato2";
            // 
            // Aceptar
            // 
            this.Aceptar.HeaderText = "Aceptar";
            this.Aceptar.Name = "Aceptar";
            // 
            // Rechazar
            // 
            this.Rechazar.HeaderText = "Rechazar";
            this.Rechazar.Name = "Rechazar";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(592, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(70, 32);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // VerSolicitudesRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 254);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaSolicitudesRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VerSolicitudesRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes de registro";
            ((System.ComponentModel.ISupportInitialize)(this.grillaSolicitudesRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaSolicitudesRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato2;
        private System.Windows.Forms.DataGridViewButtonColumn Aceptar;
        private System.Windows.Forms.DataGridViewButtonColumn Rechazar;
        private System.Windows.Forms.Button btnVolver;
    }
}