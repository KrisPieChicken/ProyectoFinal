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
            //try
            //{
            //    if (txtBuscarInsumo.Text == "" || txtCantidad.Text == "")
            //    {
            //        MessageBox.Show("Los campos no pueden estar vacíos");
            //    }

            //    // Crear una instancia de la base de datos
            //    using (BD_InventarioEntities1 bd = new BD_InventarioEntities1())
            //    {
            //        // Verificar si el insumo ya existe
            //        var insumoExistente = bd.Insumos.FirstOrDefault(i => i.Nombre_Insumo.Equals(txtBuscarInsumo.Text, StringComparison.OrdinalIgnoreCase));

            //        if (insumoExistente != null)
            //        {
            //            MessageBox.Show("El insumo ya existe en la base de datos.");
            //            return;
            //        }

            //        // Crear un nuevo insumo
            //        Insumo nuevoInsumo = new Insumo
            //        {
            //            Nombre_Insumo = txtBuscarInsumo.Text,
            //            Cantidad = txtCantidad.Text
            //        };

            //        // Agregar el nuevo insumo a la base de datos
            //        bd.Insumos.Add(nuevoInsumo);
            //        bd.SaveChanges();

            //        MessageBox.Show("Insumo agregado exitosamente.");
            //    }
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show("Error inesperado " + er.Message);
            //}
        }
    }
}
