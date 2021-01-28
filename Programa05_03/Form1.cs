using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_03
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Agregamos primero un nuevo renglon
            int n = dtgvProductos.Rows.Add();

            //Ponemos la información
            dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;

            //Limpiamos los textBoxes
            txtCodigo.Text="";
            txtNombre.Text="";
            txtPrecio.Text="";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvProductos.Rows.RemoveAt(n);
            }
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //primer parametro: quien generó el evento
            //segundo parametro: informacion que se genera con el evento
            //Tener cuidado con modificar el indice -1 <- indice del encabezado
            n = e.RowIndex;

            if (n!= -1)
            {
                lblInformacion.Text = (string)dtgvProductos.Rows[n].Cells[1].Value;
            }
        }
    }
}
