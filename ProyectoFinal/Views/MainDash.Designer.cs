namespace ProyectoFinal
{
    partial class MainDash_Bodeguero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDash_Bodeguero));
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Celular = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visializarGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayorStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menorStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grillaStockInsumos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaStockInsumos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("fotoPerfil.InitialImage")));
            this.fotoPerfil.Location = new System.Drawing.Point(12, 12);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(194, 217);
            this.fotoPerfil.TabIndex = 2;
            this.fotoPerfil.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(15, 457);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 40);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Celular);
            this.groupBox1.Controls.Add(this.lbl_Correo);
            this.groupBox1.Controls.Add(this.lbl_Cargo);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "xxxxxxxxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "granjefe@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "El Gran Jefe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "KrisPieChicken";
            // 
            // lbl_Celular
            // 
            this.lbl_Celular.AutoSize = true;
            this.lbl_Celular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Celular.Location = new System.Drawing.Point(18, 163);
            this.lbl_Celular.Name = "lbl_Celular";
            this.lbl_Celular.Size = new System.Drawing.Size(58, 17);
            this.lbl_Celular.TabIndex = 12;
            this.lbl_Celular.Text = "Teléfono:";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(27, 125);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(49, 17);
            this.lbl_Correo.TabIndex = 11;
            this.lbl_Correo.Text = "Correo:";
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cargo.Location = new System.Drawing.Point(31, 79);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(45, 17);
            this.lbl_Cargo.TabIndex = 10;
            this.lbl_Cargo.Text = "Cargo:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(19, 34);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(57, 17);
            this.lbl_Nombre.TabIndex = 9;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem,
            this.solicitudesToolStripMenuItem1,
            this.usuariosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visializarGeneralToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.visualizarToolStripMenuItem.Text = "Insumos";
            // 
            // visializarGeneralToolStripMenuItem
            // 
            this.visializarGeneralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem,
            this.mayorStockToolStripMenuItem,
            this.menorStockToolStripMenuItem,
            this.porIDToolStripMenuItem});
            this.visializarGeneralToolStripMenuItem.Name = "visializarGeneralToolStripMenuItem";
            this.visializarGeneralToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.visializarGeneralToolStripMenuItem.Text = "Ordenar por";
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.aZToolStripMenuItem.Text = "A - Z";
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.zAToolStripMenuItem.Text = "Z - A";
            // 
            // mayorStockToolStripMenuItem
            // 
            this.mayorStockToolStripMenuItem.Name = "mayorStockToolStripMenuItem";
            this.mayorStockToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.mayorStockToolStripMenuItem.Text = "Mayor stock";
            // 
            // menorStockToolStripMenuItem
            // 
            this.menorStockToolStripMenuItem.Name = "menorStockToolStripMenuItem";
            this.menorStockToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.menorStockToolStripMenuItem.Text = "Menor stock";
            // 
            // porIDToolStripMenuItem
            // 
            this.porIDToolStripMenuItem.Name = "porIDToolStripMenuItem";
            this.porIDToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.porIDToolStripMenuItem.Text = "Por ID";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click_1);
            // 
            // solicitudesToolStripMenuItem1
            // 
            this.solicitudesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insumosToolStripMenuItem1,
            this.usuariosToolStripMenuItem2});
            this.solicitudesToolStripMenuItem1.Name = "solicitudesToolStripMenuItem1";
            this.solicitudesToolStripMenuItem1.Size = new System.Drawing.Size(97, 25);
            this.solicitudesToolStripMenuItem1.Text = "Solicitudes";
            // 
            // insumosToolStripMenuItem1
            // 
            this.insumosToolStripMenuItem1.Name = "insumosToolStripMenuItem1";
            this.insumosToolStripMenuItem1.Size = new System.Drawing.Size(222, 26);
            this.insumosToolStripMenuItem1.Text = "Insumos";
            this.insumosToolStripMenuItem1.Click += new System.EventHandler(this.insumosToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem2
            // 
            this.usuariosToolStripMenuItem2.Name = "usuariosToolStripMenuItem2";
            this.usuariosToolStripMenuItem2.Size = new System.Drawing.Size(222, 26);
            this.usuariosToolStripMenuItem2.Text = "Registro de usuarios";
            this.usuariosToolStripMenuItem2.Click += new System.EventHandler(this.usuariosToolStripMenuItem2_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarPorToolStripMenuItem});
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(83, 25);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // ordenarPorToolStripMenuItem
            // 
            this.ordenarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem1,
            this.zAToolStripMenuItem1,
            this.porIDToolStripMenuItem1});
            this.ordenarPorToolStripMenuItem.Name = "ordenarPorToolStripMenuItem";
            this.ordenarPorToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.ordenarPorToolStripMenuItem.Text = "Ordenar por";
            // 
            // aZToolStripMenuItem1
            // 
            this.aZToolStripMenuItem1.Name = "aZToolStripMenuItem1";
            this.aZToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.aZToolStripMenuItem1.Text = "A - Z";
            // 
            // zAToolStripMenuItem1
            // 
            this.zAToolStripMenuItem1.Name = "zAToolStripMenuItem1";
            this.zAToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.zAToolStripMenuItem1.Text = "Z - A";
            // 
            // porIDToolStripMenuItem1
            // 
            this.porIDToolStripMenuItem1.Name = "porIDToolStripMenuItem1";
            this.porIDToolStripMenuItem1.Size = new System.Drawing.Size(122, 26);
            this.porIDToolStripMenuItem1.Text = "Por ID";
            // 
            // grillaStockInsumos
            // 
            this.grillaStockInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaStockInsumos.Location = new System.Drawing.Point(0, 32);
            this.grillaStockInsumos.Name = "grillaStockInsumos";
            this.grillaStockInsumos.Size = new System.Drawing.Size(629, 465);
            this.grillaStockInsumos.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grillaStockInsumos);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(220, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 497);
            this.panel2.TabIndex = 1;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(104, 197);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(99, 22);
            this.btnCargarImagen.TabIndex = 5;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // MainDash_Bodeguero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 521);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.fotoPerfil);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainDash_Bodeguero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal (Bodeguero)";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaStockInsumos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox fotoPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Celular;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visializarGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mayorStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menorStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porIDToolStripMenuItem1;
        private System.Windows.Forms.DataGridView grillaStockInsumos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCargarImagen;
    }
}

