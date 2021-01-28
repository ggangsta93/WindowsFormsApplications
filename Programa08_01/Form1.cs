using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirNotepad_Click(object sender, EventArgs e)
        {
            //Nos permitimos recibir eventos del notepad
            prcNotepad.EnableRaisingEvents = true;

            //Arracamos el proceso
            prcNotepad.Start();

            lblEstado.Text = "Arrancando...";
        }

        private void btnCerrarNotepad_Click(object sender, EventArgs e)
        {
            prcNotepad.Kill();
        }

        private void prcNotepad_Exited(object sender, EventArgs e)
        {
            //Este evento sucede cuando se cierra el proceso
            lblEstado.Text = "Notepad Cerrado";

            notifyIcon1.ShowBalloonTip(100,"Qué pasa mi perrro.","Notepad Cerrado",ToolTipIcon.Error);
                
            //Se recomienda que para cada aplicacion vaya su controlProcess es lo mejor 
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostramos la forma
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Escondemos la forma
            this.Hide();
        }
    }
}
