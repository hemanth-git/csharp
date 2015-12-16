
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MockTest
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void BtnAddNewClick(object sender, EventArgs e)
		{
			this.Hide();
			AddNewForm objAddNew = new AddNewForm();
			objAddNew.Show();
		}
		void BtnUpdateClick(object sender, EventArgs e)
		{
			this.Hide();
			UpdatePopUp upPop = new UpdatePopUp();
			upPop.Show();
		}
		void BtnDeleteClick(object sender, EventArgs e)
		{
			this.Hide();
			DeletePop del =new DeletePop();
			del.Show();
		}
		
	}
}
