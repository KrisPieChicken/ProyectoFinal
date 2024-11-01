using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Views
{
    public partial class Solicitud_Insumos : Form
    {
        public Solicitud_Insumos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) // Permite sólo números
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtBuscarInsumo.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
            }
        }
    }
}
