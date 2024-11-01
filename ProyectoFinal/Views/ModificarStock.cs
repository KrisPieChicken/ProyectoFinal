﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProyectoFinal
{
    public partial class ModificarStock : Form
    {
        public ModificarStock()
        {
            InitializeComponent();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) // Permite sólo números
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Guardar_Modificacion_Click(object sender, EventArgs e)
        {
            if (txt_Nuevo_Nombre.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
            }
        }
    }
}
