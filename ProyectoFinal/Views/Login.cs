using ProyectoFinal.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            try
            {
                if (string.IsNullOrWhiteSpace(txt_UsuarioLogin.Text) || string.IsNullOrWhiteSpace(txt_ContrasenaLogin.Text))
                {
                    MessageBox.Show("Los campos obligatorios no deben estar vacíos");
                    return;
                }

                int userId;
                if (!int.TryParse(txt_UsuarioLogin.Text, out userId))
                {
                    MessageBox.Show("ID de usuario no válido");
                    return;
                }

                using (BD_InventarioEntities1 bd = new BD_InventarioEntities1())
                {
                    var usuario = bd.Usuarios.FirstOrDefault(u => u.ID_Usuario == userId);

                    if (usuario != null && usuario.Contrasena == txt_ContrasenaLogin.Text)
                    {
                        string cargo = usuario.Cargo;
                        if (cargo == "Bodeguero")
                        {
                            MainDash_Bodeguero irBodeguero = new MainDash_Bodeguero();
                            irBodeguero.Show();
                            this.Hide();
                        }
                        else if (cargo == "Técnico")
                        {
                            MainTeck irTecnico = new MainTeck();
                            irTecnico.Show();
                            this.Hide();
                        }
                        else if (cargo == "Invitado")
                        {
                            UsuarioComun irInvitado = new UsuarioComun();
                            irInvitado.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}
