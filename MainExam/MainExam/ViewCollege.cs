using System.Data;
using MainExam.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainExam
{
	
	public partial class ViewCollege : Form
	{
		public ViewCollege()
		{
			InitializeComponent();
		}
		Colleges objColleges;
		public void displayCurrentCollege(string currentCollegeName)
		{
			objColleges = new Colleges();
			DataTable dt= objColleges.displayViewCollege(currentCollegeName); 
             objColleges.CollegeName = dt.Rows[0]["college_name"].ToString();
             objColleges.CollegeEmail = dt.Rows[0]["college_email"].ToString();
             objColleges.CollegePhone = dt.Rows[0]["college_phone"].ToString();
             objColleges.CollegeAddress = dt.Rows[0]["college_address"].ToString();
             objColleges.Avg=objColleges.calculateAverage(dt.Rows[0]["college_name"].ToString());
		}
		void ViewCollegeLoad(object sender, EventArgs e)
		{
			lblCollegeNameDisplay.Text=objColleges.CollegeName;
			lblCollegeMailDisplay.Text=objColleges.CollegeEmail;
			lblCollegePhoneDisplay.Text=objColleges.CollegePhone;
			lblCollegeAddressDisplay.Text=objColleges.CollegeAddress;
			lblCollegeRatingDisplay.Text=objColleges.Avg.ToString();
		}
	}
}
