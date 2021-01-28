using LOTTERY.Datos;
using LOTTERY.Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LOTTERY
{
    public partial class Devolucion : Form
    {
        CDato datos = new CDato();
        CCRUDProducto CrudProducto = new CCRUDProducto();
        CProducto objProducto = null;
        public Devolucion()
        {
            InitializeComponent();
            txtDevCodigo.Select();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtDevCodigo_Leave(object sender, EventArgs e)
        {
            uint[] valores = new uint[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            objProducto = CrudProducto.obtenerProducto(txtDevCodigo.Text);
            txtDevFrsxBillete.Text = objProducto.AtrFracciones.ToString();
            DataTable miTable = datos.loadData();
            //MessageBox.Show(miTable.Rows[0][0].ToString()+" "+ miTable.Rows[0][1].ToString()+" "+ miTable.Rows[0][2].ToString());

            foreach (DataRow row in miTable.Rows)
            {
                valores[0] = valores[0] + Convert.ToUInt32(row[4]);
                if (Convert.ToInt32(row[4]) == 1)
                    valores[1] = valores[1] + 1;
                if (Convert.ToInt32(row[4]) == 2)
                    valores[2] = valores[2] + 1;
                if (Convert.ToInt32(row[4]) == 3)
                    valores[3] = valores[3] + 1;
                if (Convert.ToInt32(row[4]) == 4)
                    valores[4] = valores[4] + 1;
                if (Convert.ToInt32(row[4]) == 5)
                    valores[5] = valores[5] + 1;
                if (Convert.ToInt32(row[4]) == 6)
                    valores[6] = valores[6] + 1;
                if (Convert.ToInt32(row[4]) > 6)
                    valores[7] = valores[7] + 1;    
            }

            txtTotal.Text = valores[0].ToString();
            txtUno.Text = valores[1].ToString();
            txtDos.Text = valores[2].ToString();
            txtTres.Text = valores[3].ToString();
            txtCuatro.Text = valores[4].ToString();
            txtCinco.Text = valores[5].ToString();
            txtSeis.Text = valores[6].ToString();
            txtOtros.Text = valores[7].ToString();
        }

        private void txtBarras_TextChanged(object sender, EventArgs e)
       
        {
            if(txtBarras.Text.Length == objProducto.AtrLongitud)
            {
                txtDevNumero.Text = obtenerCadena(txtBarras.Text, objProducto.AtrComNumeracion, objProducto.AtrCifNumeracion);
                txtDevSerie.Text = obtenerCadena(txtBarras.Text, objProducto.AtrComSerie, objProducto.AtrCifSerie);
                txtDevFraccion.Text = obtenerCadena(txtBarras.Text, objProducto.AtrComFraccion, objProducto.AtrCifFraccion);
                lsbLectura.Items.Add(txtDevNumero.Text+" "+ txtDevSerie.Text+" "+ txtDevFraccion.Text);
                datos.add("1", txtDevNumero.Text.ToString(), txtDevSerie.Text.ToString(), txtDevFraccion.Text.ToString(), "1","Jimena","Jueves");
                txtBarras.Text = "";
            }

        }
                          
        public string obtenerCadena(string cadena, int com, int cif)
        {

            
            if (cadena.Length == 20)
            {
                return cadena.Substring(com-1, cif);
            }
            else
            {
                return "ERROR";
            }
        }
        private void txtDevPaquete_Leave(object sender, EventArgs e)
        {
            txtBarras.Select();
        }
    }
}


