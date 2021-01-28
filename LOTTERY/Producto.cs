using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using LOTTERY.Logica;


namespace LOTTERY
{
    public partial class Producto : Form
    {
        CCRUDProducto CrudProducto = new CCRUDProducto();
        CProducto objProducto = null;
        public Producto()
        {
            InitializeComponent();
        }

        private void txtProductoCod_Leave(object sender, EventArgs e)
        {
            objProducto = CrudProducto.obtenerProducto(txtProductoCod.Text);
            if (objProducto != null){
                btnAdicionar.Enabled = false;
                txtProductoCod.Text = objProducto.AtrCodigo.ToString();
                txtProductoNom.Text = objProducto.AtrNombre.ToString();
                txtProductoWebDev.Text = objProducto.AtrURL.ToString();

                txtProductoLon.Text = objProducto.AtrLongitud.ToString();
                txtProductoNumCom.Text = objProducto.AtrComNumeracion.ToString();
                txtProductoNumCif.Text = objProducto.AtrCifNumeracion.ToString();
                txtProductoSerCom.Text = objProducto.AtrComSerie.ToString();
                txtProductoSerCif.Text = objProducto.AtrCifSerie.ToString();
                txtProductoFraCom.Text = objProducto.AtrComFraccion.ToString();
                txtProductoFraCif.Text = objProducto.AtrCifFraccion.ToString();
                txtProductoSorCom.Text = objProducto.AtrComSorteo.ToString();
                txtProductoSorCif.Text = objProducto.AtrCifSorteo.ToString();
                txtProductoProCom.Text = objProducto.AtrComProducto.ToString();
                txtProductoProCif.Text = objProducto.AtrCifProducto.ToString();

                txtProductoEmi.Text = objProducto.AtrEmision.ToString();
                txtProductoSer.Text = objProducto.AtrSerie.ToString();
                txtProductoFracc.Text = objProducto.AtrFracciones.ToString();
                txtProductoNumIni.Text = objProducto.AtrNumeroInicia.ToString();
                txtProductoSerIni.Text = objProducto.AtrSerieInicia.ToString();  
            }
            else
            {
                txtProductoCod.Text = "";
                txtProductoNom.Text = "";
                txtProductoWebDev.Text = "";

                txtProductoLon.Text = "";
                txtProductoNumCom.Text = "";
                txtProductoNumCif.Text = "";
                txtProductoSerCom.Text = "";
                txtProductoSerCif.Text = "";
                txtProductoFraCom.Text = "";
                txtProductoFraCif.Text = "";
                txtProductoSorCom.Text = "";
                txtProductoSorCif.Text = "";
                txtProductoProCom.Text = "";
                txtProductoProCif.Text = "";

                txtProductoEmi.Text = "";
                txtProductoSer.Text = "";
                txtProductoFracc.Text = "";
                txtProductoNumIni.Text = "";
                txtProductoSerIni.Text = "";
                btnAdicionar.Enabled = true;
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            objProducto = new CProducto();
            objProducto.AtrCodigo = txtProductoCod.Text;
            objProducto.AtrNombre = txtProductoNom.Text;
            objProducto.AtrURL = txtProductoWebDev.Text;

            objProducto.AtrLongitud = Convert.ToByte(txtProductoLon.Text);
            objProducto.AtrComNumeracion = Convert.ToByte(txtProductoNumCom.Text);
            objProducto.AtrCifNumeracion = Convert.ToByte(txtProductoNumCif.Text);
            objProducto.AtrComSerie = Convert.ToByte(txtProductoSerCom.Text);
            objProducto.AtrCifSerie = Convert.ToByte(txtProductoSerCif.Text);
            objProducto.AtrComFraccion = Convert.ToByte(txtProductoFraCom.Text);
            objProducto.AtrCifFraccion = Convert.ToByte(txtProductoFraCif.Text);
            objProducto.AtrComSorteo = Convert.ToByte(txtProductoSorCom.Text);
            objProducto.AtrCifSorteo = Convert.ToByte(txtProductoSorCif.Text);
            objProducto.AtrComProducto = Convert.ToByte(txtProductoProCom.Text);
            objProducto.AtrCifProducto = Convert.ToByte(txtProductoProCif.Text);

            objProducto.AtrEmision = Convert.ToUInt32(txtProductoEmi.Text);
            objProducto.AtrSerie = ushort.Parse(txtProductoSer.Text);
            objProducto.AtrFracciones = Convert.ToByte(txtProductoFracc.Text);
            objProducto.AtrNumeroInicia = Convert.ToUInt16(txtProductoNumIni.Text);
            objProducto.AtrSerieInicia = Convert.ToUInt16(txtProductoSerIni.Text);


            if (CrudProducto.crearProducto(objProducto))
            {
                MessageBox.Show("Producto creado.");
            }
            else
            {
                MessageBox.Show("Falló la creación del producto.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objProducto = new CProducto();
            objProducto.AtrCodigo = txtProductoCod.Text;
            objProducto.AtrNombre = txtProductoNom.Text;
            objProducto.AtrURL = txtProductoWebDev.Text;

            objProducto.AtrLongitud = Convert.ToByte(txtProductoLon.Text);
            objProducto.AtrComNumeracion = Convert.ToByte(txtProductoNumCom.Text);
            objProducto.AtrCifNumeracion = Convert.ToByte(txtProductoNumCif.Text);
            objProducto.AtrComSerie = Convert.ToByte(txtProductoSerCom.Text);
            objProducto.AtrCifSerie = Convert.ToByte(txtProductoSerCif.Text);
            objProducto.AtrComFraccion = Convert.ToByte(txtProductoFraCom.Text);
            objProducto.AtrCifFraccion = Convert.ToByte(txtProductoFraCif.Text);
            objProducto.AtrComSorteo = Convert.ToByte(txtProductoSorCom.Text);
            objProducto.AtrCifSorteo = Convert.ToByte(txtProductoSorCif.Text);
            objProducto.AtrComProducto = Convert.ToByte(txtProductoProCom.Text);
            objProducto.AtrCifProducto = Convert.ToByte(txtProductoProCif.Text);

            objProducto.AtrEmision = Convert.ToUInt32(txtProductoEmi.Text);
            objProducto.AtrSerie = ushort.Parse(txtProductoSer.Text);
            objProducto.AtrFracciones = Convert.ToByte(txtProductoFracc.Text);
            objProducto.AtrNumeroInicia = Convert.ToUInt16(txtProductoNumIni.Text);
            objProducto.AtrSerieInicia = Convert.ToUInt16(txtProductoSerIni.Text);

            if (CrudProducto.modificarProducto(objProducto))
            {
                MessageBox.Show("Producto actualizado.");
            }
            else
            {
                MessageBox.Show("Falló la modificación del producto.");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
        }
    }
}
