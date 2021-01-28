using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa02_03
{
    public partial class Form1 : Form
    {
        Form2 miForma2 = new Form2("Saludos");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            miForma2.Comentario = txtMensaje.Text;
            //Mostramos la forma
            miForma2.Show();           
        }

        private void btnEnvio2_Click(object sender, EventArgs e)
        {
            miForma2.Comentario = txtMensaje.Text;
        }
    }
}
