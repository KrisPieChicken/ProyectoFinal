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
    public partial class MainTeck : Form
    {
        public MainTeck()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void solicitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solicitud_Insumos solicitud_insumos = new Solicitud_Insumos();
            solicitud_insumos.Show();
        }
    }
}
