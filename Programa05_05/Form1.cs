﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionamos elementos
            lstFrutas.Items.Add("Uva");
            lstFrutas.Items.Add("Guanabana");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstFrutas.Items.Add(txtFruta.Text);
            txtFruta.Text = string.Empty;// == ""
        }

        private void lstFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFrutas.SelectedIndex != -1)
            {
                lblSeleccion.Text = (string)lstFrutas.Items[lstFrutas.SelectedIndex];
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = lstFrutas.SelectedIndex;
            if(indice != -1)
            {
                lstFrutas.Items.RemoveAt(indice);
            }
        }
    }
}
