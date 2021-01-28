using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa07_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
                new DateTime(2019,2,23),
                new DateTime(2019,12,31),
                DateTime.Today.AddDays(5)//A partir de la fecha actual 5 días en adelante la pone en negrita

            };
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            DateTime inicio = monthCalendar1.SelectionStart;
            DateTime final = monthCalendar1.SelectionEnd;

            lblInicio.Text = inicio.ToString();
            lblFinal.Text = final.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblSeleccion.Text = monthCalendar1.SelectionRange.ToString();
        }
    }
}
