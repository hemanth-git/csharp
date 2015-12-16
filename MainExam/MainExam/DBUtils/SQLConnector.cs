
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace MainExam.DBUtils
{
	
	public class SQLConnector
	{
		public SQLConnector()
        {
            this.ConnectionString = "Server=localhost;Port=3306;Database=university;Uid=root;Pwd=root;";
        }

        public string ConnectionString { get; set; }

        public string Query { get; set; }

        private MySqlConnection MySQLCon { get; set; }

        public void OpenConnection()
        {
            if (MySQLCon == null || MySQLCon.State != ConnectionState.Open)
            {
                MySQLCon = new MySqlConnection(ConnectionString);
                MySQLCon.Open();
            }
        }

        public void CloseConnection()
        {
            if (MySQLCon != null && MySQLCon.State != ConnectionState.Closed)
            {
                MySQLCon.Close();
                MySQLCon.Dispose();
            }
        }

        public void ExecuteWriteQuery()
        {
            if (MySQLCon != null && MySQLCon.State == ConnectionState.Open)
            {
                MySqlCommand mySqlComm = new MySqlCommand(Query, MySQLCon);
                mySqlComm.ExecuteNonQuery();
            }
        }

        public DataTable ExecuteReadQuery()
        {
            DataTable dt = new DataTable();
            if (MySQLCon != null && MySQLCon.State == ConnectionState.Open)
            {
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter(Query, MySQLCon);
                mySqlDa.Fill(dt);
            }
           
            return dt;
        }

        ~SQLConnector()
        {
            CloseConnection();
        }
	}
}
