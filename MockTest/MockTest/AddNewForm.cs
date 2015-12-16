using MockTest.Classes;
using MockTest.DBUtils;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
namespace MockTest
{
	/// <summary>
	/// Description of AddNewForm.
	/// </summary>
	public partial class AddNewForm : Form
	{
		public AddNewForm()
		{
			InitializeComponent();
		}
		MainForm objMain = new MainForm();
		void AddNewFormLoad(object sender, EventArgs e)
		{
			SQLConnector objSQL = new SQLConnector();
            objSQL.OpenConnection();
            objSQL.Query = "SELECT * FROM master_ddl Where select_name='country';";
            DataTable dt= new DataTable();
            dt = objSQL.ExecuteReadQuery();
            cmbCountry.DataSource=dt;
            cmbCountry.DisplayMember="option_name";
            cmbCountry.ValueMember="value_name";
            objSQL.Query = "SELECT * FROM master_ddl Where select_name='state';";
            dt = objSQL.ExecuteReadQuery();
            cmbState.DataSource=dt;
            cmbState.DisplayMember="option_name";
            cmbState.ValueMember="value_name";
            objSQL.Query = "SELECT * FROM master_ddl Where select_name='languages';";
            dt = objSQL.ExecuteReadQuery();
            cmbLanguage.DataSource=dt;
            cmbLanguage.DisplayMember="option_name";
            cmbLanguage.ValueMember="value_name";
            
            objSQL.Query = "SELECT * FROM courses ;";
            dt = objSQL.ExecuteReadQuery();
            cmbTermsOne.DataSource=dt;
            cmbTermsOne.DisplayMember="course_name";
            cmbTermsOne.ValueMember="course_name";
            
            cmbTermsTwo.DataSource=dt;
            cmbTermsTwo.DisplayMember="option_name";
            cmbTermsTwo.ValueMember="course_name";
            
            cmbTermsThree.DataSource=dt;
            cmbTermsThree.DisplayMember="option_name";
            cmbTermsThree.ValueMember="course_name";
            objSQL.CloseConnection();
		}
		void BtnBackClick(object sender, EventArgs e)
		{
			this.Hide();
			
			objMain.Show();
		}
		void BtnCreateClick(object sender, EventArgs e)
		{
			
			PersonalDetails pdAdd = new PersonalDetails();
			pdAdd.Student_name=txtStudentName.Text;
			pdAdd.Email=txtEmail.Text;
			
			pdAdd.Date_of_birth=dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
			pdAdd.Nationality=txtNationality.Text;
			pdAdd.Languages=cmbLanguage.SelectedValue.ToString();
			pdAdd.Country=cmbCountry.SelectedValue.ToString();
			pdAdd.State=cmbState.SelectedValue.ToString();
			pdAdd.AddDetailsToDb();
			MessageBox.Show("Candiate details registered successfully");
			this.Hide();
			objMain.Show();
			//dictAdd.Add("",txtCity.Text);
			
//			Dictionary<string, string> dictEducationOne = new Dictionary<string, string>();
//			dictEducationOne.Add("term_name",cmbTermsOne.SelectedValue.ToString());
//			dictEducationOne.Add("course_name",txtCourseOne.Text);
//			dictEducationOne.Add("university_name",txtUniversityOne.Text);
//			dictEducationOne.Add("percentage",txtPercentageOne.Text);
//
//			Dictionary<string, string> dictEducationTwo = new Dictionary<string, string>();
//			dictEducationTwo.Add("term_name",cmbTermsTwo.SelectedValue.ToString());
//			dictEducationTwo.Add("course_name",txtCourseTwo.Text);
//			dictEducationTwo.Add("university_name",txtUniversityTwo.Text);
//			dictEducationTwo.Add("percentage",txtPercentageTwo.Text);
//			
//			
//			Dictionary<string, string> dictEducationThree = new Dictionary<string, string>();
//			dictEducationThree.Add("term_name",cmbTermsThree.SelectedValue.ToString());
//			dictEducationThree.Add("course_name",txtCourseThree.Text);
//			dictEducationThree.Add("university_name",txtUniversityThree.Text);
//			dictEducationThree.Add("percentage",txtPercentageThree.Text);
			
			
			
		}
		
		
		
		
	}
}
