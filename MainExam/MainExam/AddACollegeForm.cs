
using System;
using MainExam.Classes;
using System.Drawing;
using System.Windows.Forms;
using ValidationsLib;
namespace MainExam
{
	
	public partial class AddACollegeForm : Form
	{
		public AddACollegeForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			if(validatefields())
			{
				Colleges objCollege = new Colleges();
				objCollege.CollegeName=txtCollegeName.Text;
				objCollege.CollegeEmail=txtCollegeEmail.Text;
				objCollege.CollegePhone=txtCollegePhone.Text;
				objCollege.CollegeAddress=txtCollegeAddress.Text;
				objCollege.addCollege();
				this.Hide();
				MainForm objMain = new MainForm();
				objMain.Show();
			}
			else{
				MessageBox.Show("Invalid inputs given");
			}
		}
		public bool validatefields()
		{
			if(!MyValidations.ValidateString(txtCollegeName.Text))
			   {
				return false;
			   }
			if(!MyValidations.ValidateString(txtCollegeEmail.Text))
			   {
				return false;
			   }
			if(!MyValidations.ValidateString(txtCollegePhone.Text))
			   {
				return false;
			   }
			if(!MyValidations.ValidateString(txtCollegeAddress.Text))
			   {
				return false;
			   }
			return true;
		}
	}
}
