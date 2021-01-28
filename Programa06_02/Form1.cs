using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            //DateTime fecha = new DateTime(2010,5,23);
            DateTime fecha = DateTime.Today.AddDays(57);
            string formato = "MMM ddd yyyy d, HH -> mm ";
            //lblFecha.Text = fecha.Month.ToString();
            //lblFecha.Text = DateTime.DaysInMonth(2016, 2).ToString(formato);//Saber cuantos dias tiene un mes, para saber cuando es año bisiesto por ejemplo.
            lblFecha.Text = fecha.ToString(formato);
        
        }
    }
}
