using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa10_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Console.Beep(100,200);

            if (((Button)sender).Name == "btnUno")
                MessageBox.Show("Es el boton Uno");

            if (((Button)sender).Name == "btnDos")
                lblMensaje.Text = "Es el boton Dos";

            if (((Button)sender).Name == "btnTres")
            {
                lblMensaje.Text = ((Button)sender).Text;
                ((Button)sender).Text = "Oprimido";
            }
        }
    }
}
