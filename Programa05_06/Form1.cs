﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Image miImagen = Image.FromFile("blanca.jpg");
            picImagen.Image = miImagen;
            picImagen.SizeMode =PictureBoxSizeMode.StretchImage;
        }
    }
}
