using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTTERY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto();
            objProducto.ShowDialog();
        }

        private void distribuidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distribuidor objDistribuidor = new Distribuidor();
            objDistribuidor.ShowDialog();
        }

        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucion objDevolucion = new Devolucion();
            objDevolucion.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About objAbout = new About();
            objAbout.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
