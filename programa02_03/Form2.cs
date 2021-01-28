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
    public partial class Form2 : Form
    {
        private string comentario;
        public Form2(string pMensaje)
        {
            InitializeComponent();//inicializa todos los controles
            lblMensaje.Text = pMensaje;
        }

        public string Comentario
        {
            set
            {
                comentario = value;
                lblComentario.Text = comentario;
            }
        }

    }
}
