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
            // Verificar que los campos no estén vacíos
            if (txt_Cantidad.Text == "" || txt_NombreInsumo.Text == "" || txt_Cantidad_Minima.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return; // Salir del método si los campos están vacíos
            }

            try
            {
                // Crear una instancia de la base de datos
                using (BD_InventarioEntities1 bd = new BD_InventarioEntities1())
                {
                    // Crear un nuevo insumo
                    Insumo nuevoInsumo = new Insumo
                    {
                        Nombre_Insumo = txt_NombreInsumo.Text,
                        Cantidad = int.Parse(txt_Cantidad.Text), // Convertir a entero
                        Cantidad_Minima = int.Parse(txt_Cantidad_Minima.Text) // Convertir a entero
                    };

                    // Agregar el nuevo insumo a la base de datos
                    bd.Insumos.Add(nuevoInsumo);
                    bd.SaveChanges(); // Guardar cambios en la base de datos

                    MessageBox.Show("Insumo guardado exitosamente.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para Cantidad y Cantidad Mínima.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
    }
}