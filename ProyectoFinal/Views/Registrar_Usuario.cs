using ProyectoFinal.Datos;
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

        private bool ValidarCorreo(string correo)
        {
            // Verifica si el correo contiene el formato correcto y termina en @gmail.com
            return correo.EndsWith("@gmail.com") && correo.IndexOf('@') > 0; // Asegura que haya al menos un carácter antes del '@'
        }


        private void btn_LimpiarRegistro_Click(object sender, EventArgs e)
        {
            txt_NomApRegistro.Text = ""; txt_rutRegistro.Text = ""; txt_ConstrasenaRegistro.Text = ""; txt_CorreoRegistro.Text = ""; txt_telefonoRegistro.Text = ""; cmBox_CargoRegistro.Text = "Seleccione un cargo"; 
        }

        private void btn_Guardar_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos obligatorios
                if (txt_rutRegistro.Text == "" || txt_NomApRegistro.Text == "" || txt_ConstrasenaRegistro.Text == "" || txt_CorreoRegistro.Text == "")
                {
                    MessageBox.Show("Los campos obligatorios no deben estar vacíos");
                    return;
                }
                else if (cmBox_CargoRegistro.Text == "Seleccione un cargo")
                {
                    MessageBox.Show("Debe seleccionar un cargo");
                    return;
                }

                // Validar el formato del correo electrónico
                if (!ValidarCorreo(txt_CorreoRegistro.Text))
                {
                    MessageBox.Show("El correo electrónico debe tener el formato '@gmail.com'");
                    return;
                }

                if (txt_rutRegistro.Text.Length < 9)
                {
                    MessageBox.Show("El RUT debe tener al menos 9 dígitos.");
                    return;
                }

                using (BD_InventarioEntities1 bd = new BD_InventarioEntities1())
                {
                    int rut = Convert.ToInt32(txt_rutRegistro.Text);

                    // Asigna el valor de teléfono según si el campo está vacío o contiene un número válido
                    int telefono = 0; // Valor predeterminado si el campo está vacío
                    if (!string.IsNullOrWhiteSpace(txt_telefonoRegistro.Text))
                    {
                        if (!int.TryParse(txt_telefonoRegistro.Text, out telefono))
                        {
                            MessageBox.Show("El número de teléfono debe ser un valor numérico.");
                            return;
                        }
                    }

                    var usuario = bd.Usuarios.FirstOrDefault(x => x.ID_Usuario == rut);

                    // Verifica si el usuario ya existe
                    if (usuario != null)
                    {
                        MessageBox.Show("El usuario ya existe");
                        return;
                    }
                    else
                    {
                        // Crea un nuevo usuario
                        Usuario user = new Usuario
                        {
                            ID_Usuario = rut,                            
                            NombreCompleto = txt_NomApRegistro.Text,
                            Contrasena = txt_ConstrasenaRegistro.Text,
                            Correo = txt_CorreoRegistro.Text,
                            Cargo = cmBox_CargoRegistro.Text,
                            Numero_Tele = telefono  // Almacena el valor de teléfono                    
                        };

                        bd.Usuarios.Add(user);
                        bd.SaveChanges();

                        MessageBox.Show("Usuario registrado con éxito");

                        // Redirige a la pantalla de inicio de sesión
                        Login irInicioSesion = new Login();
                        irInicioSesion.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception er)
            {
                //print error to console
                Console.WriteLine(er.Message);
                MessageBox.Show("Error inesperado " + er.Message);
            }
        }

    }
}