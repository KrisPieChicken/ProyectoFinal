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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Registrar_Usuario irRegistrar = new Registrar_Usuario();
            irRegistrar.Show();
            this.Hide();
        }

        private void txt_UsuarioLogin_KeyPress(object sender, KeyPressEventArgs e) // Permite sólo números
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {

            if (txt_UsuarioLogin.Text == "" || txt_ContrasenaLogin.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return;
            }

            try
            {
                int rutUsuario = int.Parse(txt_UsuarioLogin.Text);
                string contrasenaUsuario = txt_ContrasenaLogin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
