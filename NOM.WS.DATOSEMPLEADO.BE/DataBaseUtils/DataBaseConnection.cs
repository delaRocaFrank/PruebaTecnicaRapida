using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NOM.WS.DATOSEMPLEADO.BE.DataBaseUtils
{
    public class DataBaseConnection
    {

        private MySql.Data.MySqlClient.MySqlConnection conn;

        public DataBaseConnection()
        {
            string ConnectionString = "server=127.0.0.1;uid=root;pwd=Fradeing1991;database=TEST";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {

            }
        }

        public DataSet getColaborador()
        {
            string Query = "Select * from COLABORADOR";
            MySql.Data.MySqlClient.MySqlDataAdapter DA = new MySql.Data.MySqlClient.MySqlDataAdapter(Query, conn);
            DataSet myDataSet = new DataSet();

            DA.Fill(myDataSet, "Colaborador");

            return myDataSet;
        }
    }
}
