/*
 * Created by SharpDevelop.
 * User: Hemanth Sai
 * Date: 12/12/2015
 * Time: 3:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MockTest.Classes;
namespace MockTest
{
	/// <summary>
	/// Description of DeletePop.
	/// </summary>
	public partial class DeletePop : Form
	{
		public DeletePop()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		MainForm objMain = new MainForm();
		void BtnBackClick(object sender, EventArgs e)
		{
			this.Hide();
			
			objMain.Show();
		}
		void BtnDeleteClick(object sender, EventArgs e)
		{
			string studentid=txtStudentId.Text;
			PersonalDetails ObjTable= new PersonalDetails();
			int result=ObjTable.DeleteADetail(studentid);
			if(result>0)
			{
				MessageBox.Show("Delete performed successfully");
				
			}
			else{
				MessageBox.Show("Delete not performed");
			}
			
			objMain.Show();
		}
	}
}
