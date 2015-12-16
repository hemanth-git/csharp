
using System;
using MySql.Data;
using MainExam.DBUtils;
using MainExam.Util;
namespace MainExam.Classes
{
	/// <summary>
	/// Description of Reviews.
	/// </summary>
	public class Reviews
	{
		public string CollegeName { get; set; }
		public int Rating { get; set; }		
		public string EMail { get; set; }
		public string Comments { get; set; }
		public Reviews()
		{
		}
		public void AddAReview()
		{
			try {
				SQLConnector objSQL = new SQLConnector();
				objSQL.OpenConnection();
				objSQL.Query =string.Format("Insert into reviews (college_name,rating,review_name,email)values ('{0}','{1}','{2}','{3}');"
				                  ,this.CollegeName,this.Rating,this.EMail,this.Comments);
				objSQL.ExecuteWriteQuery();
            	objSQL.CloseConnection();
			} 
			catch (Exception e) {
				LogCat.LogCatMsg (e.Message);// log cat to write exception to a file will be available in bin folder
			
			}
			
		}
	}
}
