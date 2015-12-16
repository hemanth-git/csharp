using MySql.Data;
using MockTest.DBUtils;
using System;
using System.Collections.Generic;
namespace MockTest.Classes
{
	/// <summary>
	/// Description of PersonalDetails.
	/// </summary>
	public class PersonalDetails
	{
		public string Student_name { get; set; }
		public string Email { get; set; }
		public string Date_of_birth { get; set; }
		public string Nationality { get; set; }
		public string Country { get; set; }
		public string Languages { get; set; }
		public string State { get; set; }
		
		public object Property { get; set; }
		public void AddDetailsToDb()
		{
			SQLConnector objSQL = new SQLConnector();
			objSQL.OpenConnection();
			objSQL.Query = string.Format("Insert into personal_info (student_name,email,date_of_birth,nationality,languages,country,state)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",
                                        this.Student_name,this.Email,this.Date_of_birth,this.Nationality,this.Languages,this.Country,this.State);
			objSQL.ExecuteWriteQuery();
			objSQL.CloseConnection();
		}
		public int DeleteADetail(string studentId)
		{
			int intStudentId=int.Parse(studentId);
			SQLConnector objSQL = new SQLConnector();
			objSQL.OpenConnection();
			objSQL.Query=string.Format("delete from personal_info where student_id ={0}",intStudentId);
			int result =objSQL.ExecuteWriteQuery();
			return result;
		}
	}
}
