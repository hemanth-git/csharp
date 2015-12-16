/*
 * Created by SharpDevelop.
 * User: Hemanth Sai
 * Date: 12/12/2015
 * Time: 3:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MockTest
{
	/// <summary>
	/// Description of UpdatePopUp.
	/// </summary>
	public partial class UpdatePopUp : Form
	{
		public UpdatePopUp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnBackClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm objMain = new MainForm();
			objMain.Show();
		}
		void BtnUpdateClick(object sender, EventArgs e)
		{
			string strToUpdateId=txtStudentId.Text;
			
		}
	}
}
