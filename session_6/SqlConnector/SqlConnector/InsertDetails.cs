/*
 * Created by SharpDevelop.
 * User: Hemanth Sai
 * Date: 12/11/2015
 * Time: 4:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using SqlConnector.DBUtils;
using SqlConnector.Classes;
using ValidationsLib;

namespace SqlConnector
{
	/// <summary>
	/// Description of InsertDetails.
	/// </summary>
	public partial class InsertDetails : Form
	{
		public InsertDetails()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSubmitClick(object sender, EventArgs e)
		{
			bool flagValid= false;
			if (!MyValidations.ValidateString(txtFirstName.Text)) {	
				MessageBox.Show("Invalid name");
			}
			if(txtFirstName.Text.Length == 15){
			}
			
			Contact newDetails= new Contact();
			string strFname=txtFirstName.Text;
			newDetails.FirstName=txtFirstName.Text;	
			newDetails.LastName=txtLastName.Text;
			newDetails.Age=txtAge.Text;
			newDetails.Designation=txtDesignation.Text;
			SQLConnector objSQL = new SQLConnector();
            objSQL.OpenConnection();
            objSQL.Query = string.Format("Insert into contacts (first_name,last_name,designation,age)values ('{0}','{1}','{2}','{3}');",
                                        newDetails.FirstName,newDetails.LastName,newDetails.Designation,newDetails.Age);
            objSQL.ExecuteWriteQuery();
            objSQL.CloseConnection();
            this.Visible=false;
            
            Contacts contacts = new Contacts();
            contacts.Show();
		}
		void TxtFirstNameTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
