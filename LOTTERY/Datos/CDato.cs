using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace LOTTERY.Datos
{
    class CDato
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        //set connection
        private void setConnection()
        {
            sql_con = new SQLiteConnection("Data Source=db.db; Version=3; New=False; Compress=True");
        }

        //Set executequery
        private void ExecuteQuery(string pQuery)
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = pQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }


        //set loadDB
        public DataTable loadData()
        {
            setConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from tblDevol";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            sql_con.Close();
            return DT;
        }

       //add
       public void add(String pPaq, String pNum, String pSer, String pFrac, String pTira, String pUser, String pFecha)
       {
            string Query = "insert into tblDevol (paquete, numero, serie, fraccion,tira, users, fecha)values('"+pPaq+"', '"+pNum+"', '"+pSer+"', '"+pFrac+"','"+pTira+"','"+pUser+"','"+pFecha+"')";
            
            ExecuteQuery(Query);
        }

        //Edit
        public void update(String pPaq, String pNum, String pSer, String pFrac, String pTira, String pUser, String pFecha)
        {
            //Sentencia incompleta para filtrar
            string Query = "update tblDevol set paquete="+pPaq+", numero="+pNum+", serie="+pSer+", fraccion="+pFrac+",tira="+pTira+", user="+pUser+", fecha="+pFecha+") where paquete="+pPaq+")";
            ExecuteQuery(Query);
        }

        //Delete
        public void delete(String pPaq, String pNum, String pSer, String pFrac, String pTira, String pUser, String pFecha)
        {
            string Query = "delete from tblDevol where paquete = "+pPaq+" AND numero = "+pNum+" AND serie = "+pSer+" AND fraccion = "+pFrac;
            ExecuteQuery(Query);
        }

    }
}
