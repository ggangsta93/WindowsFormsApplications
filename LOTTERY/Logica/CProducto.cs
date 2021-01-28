using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTTERY.Logica
{
    [Serializable]
    class CProducto
    {
        private string atrCodigo = "";
        private string atrNombre = "";
        private string atrURL = "";
        //Configuración Código de barras
        private byte atrLongitud = 0;
        private byte atrComNumeracion = 0;
        private byte atrCifNumeracion = 0;
        private byte atrComSerie = 0;
        private byte atrCifSerie = 0;
        private byte atrComFraccion = 0;
        private byte atrCifFraccion;
        private byte atrComSorteo = 0;
        private byte atrCifSorteo = 0;
        private byte atrComProducto = 0;
        private byte atrCifProducto = 0;
        //Plan de premios
        private uint atrEmision = 0;
        private ushort atrSerie = 0;
        private byte atrFracciones = 0;
        private uint atrNumeroInicia = 0;
        private uint atrSerieInicia = 0;

        public string AtrCodigo { get => atrCodigo; set => atrCodigo = value; }
        public string AtrNombre { get => atrNombre; set => atrNombre = value; }
        public string AtrURL { get => atrURL; set => atrURL = value; }
        public byte AtrLongitud { get => atrLongitud; set => atrLongitud = value; }
        public byte AtrComNumeracion { get => atrComNumeracion; set => atrComNumeracion = value; }
        public byte AtrCifNumeracion { get => atrCifNumeracion; set => atrCifNumeracion = value; }
        public byte AtrComSerie { get => atrComSerie; set => atrComSerie = value; }
        public byte AtrCifSerie { get => atrCifSerie; set => atrCifSerie = value; }
        public byte AtrComFraccion { get => atrComFraccion; set => atrComFraccion = value; }
        public byte AtrCifFraccion { get => atrCifFraccion; set => atrCifFraccion = value; }
        public byte AtrComSorteo { get => atrComSorteo; set => atrComSorteo = value; }
        public byte AtrCifSorteo { get => atrCifSorteo; set => atrCifSorteo = value; }
        public byte AtrComProducto { get => atrComProducto; set => atrComProducto = value; }
        public byte AtrCifProducto { get => atrCifProducto; set => atrCifProducto = value; }
        public uint AtrEmision { get => atrEmision; set => atrEmision = value; }
        public ushort AtrSerie { get => atrSerie; set => atrSerie = value; }
        public byte AtrFracciones { get => atrFracciones; set => atrFracciones = value; }
        public uint AtrNumeroInicia { get => atrNumeroInicia; set => atrNumeroInicia = value; }
        public uint AtrSerieInicia { get => atrSerieInicia; set => atrSerieInicia = value; }

        public override string ToString()
        {

        return "PRODUCTO\n" +
               "Codigo: "+atrCodigo+" Nombre: "+atrNombre+"\n "+
               "URL: "+atrURL+"\n "+
               "Longitud: "+atrLongitud+"\n "+
               "Numeracion   Comienzo:"+atrComNumeracion+" Cifras:"+atrCifNumeracion+"\n"+
               "Serie        Comienzo:" + atrComSerie + " Cifras:" + atrCifSerie + "\n"+
               "Fraccion     Comienzo:" + atrComFraccion + " Cifras:" + atrCifFraccion + "\n"+
               "Sorteo       Comienzo:" + atrComSorteo + " Cifras:" + atrCifSorteo + "\n"+
               "Producto     Comienzo:" + atrComProducto + " Cifras:" + atrCifProducto + "\n"+
               "Emision: " + atrEmision + " Numero Inicia:" + AtrNumeroInicia + "\n" +
               "Series: " + AtrSerie + " Serie Inicia:" + atrSerieInicia + "\n" +
               "Fracciones: " + atrFracciones+"\n";

        }
    }
}
