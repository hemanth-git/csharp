
using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
namespace MockTest.DBUtils
{
	/// <summary>
	/// Description of SQLConnector.
	/// </summary>
	public class SQLConnector
	{
		public SQLConnector()
		{
			this.ConnectionString = "Server=127.0.0.1;Port=3306;Database=university;Uid=root;Pwd=root;";
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

        public int ExecuteWriteQuery()
        {
            if (MySQLCon != null && MySQLCon.State == ConnectionState.Open)
            {
                MySqlCommand mySqlComm = new MySqlCommand(Query, MySQLCon);
                return mySqlComm.ExecuteNonQuery();
            }
            return 0;
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
