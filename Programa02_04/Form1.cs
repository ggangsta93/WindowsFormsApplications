using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_04
{
    public partial class Form1 : Form
    {
        Form2 miForma2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForma2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = miForma2.ShowDialog();
            if (resultado == DialogResult.OK)//Si el usuario cierra la ventana y si este da Ok
            {
                lblMensaje.Text = miForma2.Mensaje;
                lblContenido.Text = miForma2.Contenido;
            }
            if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("No ejecutaste la operacion");
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = miForma2.Mensaje;
            lblContenido.Text = miForma2.Contenido;
        }
    }
}
