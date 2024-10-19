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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {







            Navigacion();
        }






        private static void Navigacion()
        {
            Agregar_Insumos agregar_Insumos = new Agregar_Insumos();
            agregar_Insumos.Show();
        }
    }
}
