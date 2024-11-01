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
    public partial class Registrar_Usuario : Form
    {
        public Registrar_Usuario()
        {
            InitializeComponent();
            cmBox_CargoRegistro.Items.Add("Seleccione un cargo");
            cmBox_CargoRegistro.Items.Add("Bodeguero");
            cmBox_CargoRegistro.Items.Add("Técnico");
            cmBox_CargoRegistro.Items.Add("Invitado");
            cmBox_CargoRegistro.SelectedIndex = 0;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Login irInicioSesion = new Login();
            irInicioSesion.Show();
            this.Hide();
        }

        private void txt_rutRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_telefonoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_LimpiarRegistro_Click(object sender, EventArgs e)
        {
            txt_NomApRegistro.Text = ""; txt_rutRegistro.Text = ""; txt_ConstrasenaRegistro.Text = ""; txt_CorreoRegistro.Text = ""; txt_telefonoRegistro.Text = ""; cmBox_CargoRegistro.Text = "Seleccione un cargo"; 
        }

        private void btn_Guardar_Nuevo_Click(object sender, EventArgs e)
        {
            if (txt_rutRegistro.Text == "" || txt_NomApRegistro.Text == "" || txt_ConstrasenaRegistro.Text == "" || txt_CorreoRegistro.Text == "" || txt_telefonoRegistro.Text == "")
            {
                MessageBox.Show("Los campos obligatorios no deben estar vacíos");
                return;

            }else if (cmBox_CargoRegistro.Text == "Seleccione un cargo")
            {
                MessageBox.Show("Debe seleccionar un cargo");
            }
        }
    }
}
