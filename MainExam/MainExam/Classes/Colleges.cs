using MainExam.DBUtils;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MainExam.Util;

namespace MainExam.Classes
{
	/// <summary>
	/// Description of Colleges.
	/// </summary>
	public class Colleges
	{
		public string CollegeName { get; set; }
		public string CollegeEmail { get; set; }
		public string CollegePhone { get; set; }
		public string CollegeAddress { get; set; }
		public int Avg { get; set; }
		
		public Colleges()
		{
			
		}
		public void addCollege()
		{
			try {
				SQLConnector objSQL = new SQLConnector();
				objSQL.OpenConnection();
				objSQL.Query =string.Format("Insert into colleges (college_name,college_email,college_phone,college_address)values ('{0}','{1}','{2}','{3}');"
				                  ,this.CollegeName,this.CollegeEmail,this.CollegePhone,this.CollegeAddress);
				objSQL.ExecuteWriteQuery();
            	objSQL.CloseConnection();
			} 
			catch (Exception e) {
				LogCat.LogCatMsg (e.Message);// log cat to write exception to a file will be available in bin folder
			
			}
		}
		public void deleteCollege(string collegeName)
		{
			
		}
		public int calculateAverage(string strCollegeName)
		{
			try {
				SQLConnector objSQL = new SQLConnector();
				objSQL.OpenConnection();
				Debug.WriteLine(strCollegeName);
				objSQL.Query =string.Format("select AVG('rating') as 'avg_rating' from reviews where college_name='{0}'; ",strCollegeName);
				DataTable dt= objSQL.ExecuteReadQuery();
				objSQL.CloseConnection();
				Debug.WriteLine((dt.Rows[0]["avg_rating"]).ToString());
				return int.Parse((dt.Rows[0]["avg_rating"]).ToString());
			} 
			catch (Exception e) {
				LogCat.LogCatMsg (e.Message);// log cat to write exception to a file will be available in bin folder
				return 0;
			}	
		}
		public DataTable displayColleges()
		{
			try {
				SQLConnector objSQL = new SQLConnector();
				objSQL.OpenConnection();
				 objSQL.Query = "SELECT * FROM colleges;";
				 DataTable dt = objSQL.ExecuteReadQuery();
				 objSQL.CloseConnection();
				 return dt;
			}
			catch (Exception e) {
				LogCat.LogCatMsg (e.Message);// log cat to write exception to a file will be available in bin folder
				return null;
			}	
				 
		}
		public DataTable displayViewCollege(string currentCollegeName)
		{
			try {
				SQLConnector objSQL = new SQLConnector();
				objSQL.OpenConnection();
				objSQL.Query = string.Format("SELECT * FROM colleges where college_name='{0}';",currentCollegeName);
				DataTable dt = objSQL.ExecuteReadQuery();
				objSQL.CloseConnection();
				return dt;
			} 
			catch (Exception e) {
				LogCat.LogCatMsg (e.Message);// log cat to write exception to a file will be available in bin folder
				return null;
			}
		}
	}
}
