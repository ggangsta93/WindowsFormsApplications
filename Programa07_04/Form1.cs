using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa07_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //OpenFileDialog Sólo obtiene el nombre del archivo y la ruta
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Aquí va el codigo para abrir y leer el archivo
                lblAbrir.Text = openFileDialog1.FileName;
                // FileNames;  obtiene un arreglo con multiples archivos seleccionados

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Aquí va el codigo para salvar
                lblSalvar.Text = saveFileDialog1.FileName;
            }
        }
    }
}
