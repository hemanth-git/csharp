using System.Diagnostics;
using System;
using MainExam.Util;
using System.Windows.Forms;
using MainExam.Classes;
using ValidationsLib;
using MainExam.DBUtils;
using System.Data;
namespace MainExam
{
	
	public partial class ReviewACollegeForm : Form
	{
		public ReviewACollegeForm()
		{
			InitializeComponent();
		}
		void ReviewACollegeFormLoad(object sender, EventArgs e)
		{
			try {
				SQLConnector objSQL = new SQLConnector();
	            objSQL.OpenConnection();
	            Debug.WriteLine(objSQL.Query = "SELECT * FROM master_ddl where select_name='rating' ;");
	            DataTable dt= new DataTable();
	            dt = objSQL.ExecuteReadQuery();
	            cmbRating.DataSource=dt;
	            
            	cmbRating.DisplayMember="option_name";
            	cmbRating.ValueMember="option_name";
            	Debug.WriteLine(objSQL.Query = "SELECT college_name FROM colleges ;");
	            dt = objSQL.ExecuteReadQuery();
	            cmbCollegeList.DataSource=dt;
	           	Debug.WriteLine(dt);
	            cmbCollegeList.DisplayMember="option_name";
            	cmbCollegeList.ValueMember="option_name";
	            
				
			}
			catch (Exception ex) {
				LogCat.LogCatMsg (ex.Message);// log cat to write exception to a file will be available in bin folder
			
			}
		}
		public bool validatefields()
		{
			
			if(!MyValidations.ValidateString(txtComments.Text))
			   {
				return false;
			   }
			if(!MyValidations.ValidateString(txtEmail.Text))
			   {
				return false;
			   }
			
			return true;
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			try {
			if(validatefields())
				{
					Reviews objReview= new Reviews();
					objReview.CollegeName=cmbCollegeList.SelectedValue.ToString();
					objReview.Rating=int.Parse(cmbRating.SelectedValue.ToString());
					objReview.Comments=txtComments.Text;
					objReview.EMail=txtEmail.Text;
					objReview.AddAReview();
					this.Hide();
					MainForm objMain = new MainForm();
					objMain.Show();
					
				}
				else{
					MessageBox.Show("Invalid inputs given");
				}
			}
			catch (Exception ex) {
				LogCat.LogCatMsg (ex.Message);// log cat to write exception to a file will be available in bin folder
			
			}
		}
		}
		
	
}
