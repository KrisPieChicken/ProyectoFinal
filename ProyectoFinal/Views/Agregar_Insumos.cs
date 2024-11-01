using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Agregar_Insumos : Form
    {
        public Agregar_Insumos()
        {
            InitializeComponent();
        }

        private void txt_Cantidad_Minima_KeyPress(object sender, KeyPressEventArgs e) // Permite sólo números
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e) // Permite sólo números
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_GuardarInsumos_Click(object sender, EventArgs e)
        {
            if (txt_Cantidad.Text == "" || txt_NombreInsumo.Text == "" || txt_Cantidad_Minima.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
            }
        }
    }
}
