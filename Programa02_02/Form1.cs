﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 miforma2 = new Form2();
            //miforma2.Show();//Lo muestra de la forma no modal "permite trabajar en ambas ventanas"
            miforma2.ShowDialog();//Sólo permite trabajar con una
        }
    }
}
