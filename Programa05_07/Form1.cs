﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_07
{
    public partial class Form1 : Form
    {
        private int indice;
        public Form1()
        {
            InitializeComponent();
            indice = 0;

        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            if (indice > 7)
                indice = 0;
            
            indice++;
            lblFoto.ImageIndex = indice;

            pcbimagen.Image = imglFotos.Images[indice];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcbimagen.Image = imglFotos.Images[0];
        }
    }
}
