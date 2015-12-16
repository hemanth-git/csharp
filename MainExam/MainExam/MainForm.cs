using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Data;
using MainExam.Util;
using System.Windows.Forms;
using MainExam.Classes;
namespace MainExam
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		DataTable dt;
		void MainFormLoad(object sender, EventArgs e)
		{
			try {
				List<Colleges> lstColleges = new List<Colleges>();
	            Colleges objCollege = new Colleges();
	             dt= objCollege.displayColleges();
	            for (int i = 0; i < dt.Rows.Count; i++)
	            {
	                objCollege = new Colleges();
	                objCollege.CollegeName = dt.Rows[i]["college_name"].ToString();
	                objCollege.CollegeEmail = dt.Rows[i]["college_email"].ToString();
	                objCollege.CollegePhone = dt.Rows[i]["college_phone"].ToString();
	                objCollege.CollegeAddress = dt.Rows[i]["college_address"].ToString();
	                Debug.WriteLine(dt.Rows[i]["college_name"].ToString());
	                objCollege.Avg=objCollege.calculateAverage(dt.Rows[i]["college_name"].ToString());
	                lstColleges.Add(objCollege);
	                //Debug.WriteLine(objCollege.ToString());
	                
	            }
	            //dgvColleges.AutoGenerateColumns = false;
	            dgvColleges.DataSource = lstColleges;
			}
			catch (Exception ex) {
				LogCat.LogCatMsg (ex.Message);// log cat to write exception to a file will be available in bin folder
			
			}
			
		}
		void BtnReviewClick(object sender, EventArgs e)
		{
			this.Hide();
			ReviewACollegeForm objReview = new ReviewACollegeForm();
			objReview.Show();
		}
		void BtnAddCollegeClick(object sender, EventArgs e)
		{
			this.Hide();
			AddACollegeForm objAddCollege= new AddACollegeForm();
			objAddCollege.Show();
		}
		int currentRowIndex=0;
		void DgvCollegesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			currentRowIndex=e.RowIndex;
		}
		void BtnViewCollegeClick(object sender, EventArgs e)
		{
			this.Hide();
			ViewCollege objViewCollege =new ViewCollege();
			string strCollegeName=dt.Rows[currentRowIndex]["college_name"].ToString();
			objViewCollege.displayCurrentCollege(strCollegeName);
			objViewCollege.Show();
		}
		
		
	}
}
