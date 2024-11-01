using ProyectoFinal.Views;
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
    public partial class MainDash_Bodeguero : Form
    {
        public MainDash_Bodeguero()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Agregar_Insumos irAgregar = new Agregar_Insumos();
            irAgregar.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VerSolicitudesRegistro verSolicitudesRegistro = new VerSolicitudesRegistro();
            verSolicitudesRegistro.Show();

        }

        private void insumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Solicitud_Insumos solicirud_insumo = new Solicitud_Insumos();
            solicirud_insumo.Show();
        }
    }
}