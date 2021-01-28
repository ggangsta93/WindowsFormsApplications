using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa08_05
{
    public partial class Form1 : Form
    {
        private Form2 forma2;
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarVentana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma2 == null)
            {
                forma2 = new Form2();
                forma2.MdiParent = this;
                forma2.FormClosed += new FormClosedEventHandler(CerrarForma2);
                forma2.Show();
            }
            else
            {
                forma2.Activate();
            }
        }

        void CerrarForma2(object sender, FormClosedEventArgs e)
        {
            forma2 = null;
        }

        private void adicionarVentana2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 otraForma = new Form3();
            otraForma.MdiParent = this;
            otraForma.Show();
        }
    }
}
