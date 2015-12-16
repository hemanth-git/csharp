
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowCalc.Utils;

namespace WindowCalc
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		bool flag= true;
		bool dotClick = true;
		private void Calc_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0";
            }
        }
		private void BtnNumberClick(object sender, EventArgs e){
			if(flag){
			
				if (txtDisplay.Text.Length == 15)
				{
					MessageBox.Show("Reached maximum number of digits supported", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (string.IsNullOrEmpty(txtDisplay.Text) || string.Equals(txtDisplay.Text, "0"))
				{
					txtDisplay.Text = ((Button)sender).Text;
				}
				else{
					txtDisplay.Text += ((Button)sender).Text;
				}
				
			}
			else{
				txtDisplay.Text = ((Button)sender).Text;
				flag=true;
			}
		}
		private void BtnOperatorClick(object sender, EventArgs e){
			string value=txtDisplay.Text;
			Double number;
			if(Double.TryParse(value, out number)){
				OperationsArt.setOperandOne(txtDisplay.Text);
			}
			else{
				OperationsArt.setOperandOne("0");
				txtDisplay.Text="0";
			}
						 
			OperationsArt.Operator= ((Button)sender).Text;
			txtDisplay.Clear();
			if (string.IsNullOrEmpty(txtDisplay.Text)){
			    	txtDisplay.Text = "0";
			    }
			dotClick=true;
		}
		private void BtnEqualClick(object sender, EventArgs e){
			OperationsArt.setOperandTwo(txtDisplay.Text);
			
			if(!string.IsNullOrEmpty(OperationsArt.Operator) ){
				OperationsArt.performOperation();
				txtDisplay.Text=OperationsArt.OperandOne.ToString();
			}
			flag=false;
			dotClick=true;
		}
		private void BtnClearClick(object sender, EventArgs e){
			OperationsArt.OperandOne=0;
			OperationsArt.OperandTwo=0;
			OperationsArt.Operator="+";
			txtDisplay.Text="0";
			
		}
		private void BtnClearCE(object sender, EventArgs e){
			txtDisplay.Text="0";
		}
		private void BtnDotClick(object sender, EventArgs e){
			if(dotClick){
				if(flag){
					txtDisplay.Text += ((Button)sender).Text;
				}
				else{
					txtDisplay.Text = ((Button)sender).Text;
					flag=true;
				}
				dotClick=false;
			}
		}
	}
}
