using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LOTTERY.Logica
{
    class CCRUDProducto
    {
        public bool crearProducto(CProducto pProducto)
        {
            //Serializamos el objeto
            BinaryFormatter formateador = new BinaryFormatter();
            //Se crea el Stream
            Stream miStream = new FileStream(""+pProducto.AtrCodigo+".aut", FileMode.Create, FileAccess.Write, FileShare.None);
            //Serializamos
            formateador.Serialize(miStream, pProducto);
            //Cerramos el stream
            miStream.Close();  
            
            return true;
        }

        public bool modificarProducto(CProducto pProducto)
        {
            if(pProducto != null)
            {
                //Serializamos el objeto
                BinaryFormatter formateador = new BinaryFormatter();
                //Se crea el Stream
                Stream miStream = new FileStream("" + pProducto.AtrCodigo + ".aut", FileMode.Open, FileAccess.Write, FileShare.None);
                //Serializamos
                formateador.Serialize(miStream, pProducto);
                //Cerramos el stream
                miStream.Close();
                return true;
            }
            else{
                return false;
            }

        }

        public CProducto obtenerProducto(string pCodigo)
        {
            ArrayList productos = new ArrayList();
            
            
            if(File.Exists("" + pCodigo + ".aut"))
            {
                //Deserializamos el objeto
                BinaryFormatter formateador = new BinaryFormatter();
                //Se crea el Stream
                Stream miStream = new FileStream("" + pCodigo + ".aut", FileMode.Open, FileAccess.Read, FileShare.None);
                //Deserializamos
                CProducto cProducto = (CProducto)formateador.Deserialize(miStream);
                //Cerramos el stream
                miStream.Close();
                return cProducto;
            }
            else
            {
                return null;
            }
        }

       



    }
}
