namespace ProyectoFinal.Views
{
    partial class Ver_Solicitud
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dato1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aceptar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Rechazar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dato1,
            this.Dato2,
            this.Dato3,
            this.Aceptar,
            this.Rechazar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // Dato1
            // 
            this.Dato1.HeaderText = "Dato1";
            this.Dato1.Name = "Dato1";
            // 
            // Dato2
            // 
            this.Dato2.HeaderText = "Dato2";
            this.Dato2.Name = "Dato2";
            // 
            // Dato3
            // 
            this.Dato3.HeaderText = "Dato3";
            this.Dato3.Name = "Dato3";
            // 
            // Aceptar
            // 
            this.Aceptar.HeaderText = "Aceptar";
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Text = "";
            // 
            // Rechazar
            // 
            this.Rechazar.HeaderText = "Rechazar";
            this.Rechazar.Name = "Rechazar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insumos solicitados";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(592, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(70, 32);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Ver_Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 254);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ver_Solicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitudes de insumos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dato3;
        private System.Windows.Forms.DataGridViewButtonColumn Aceptar;
        private System.Windows.Forms.DataGridViewButtonColumn Rechazar;
        private System.Windows.Forms.Button btnVolver;
    }
}