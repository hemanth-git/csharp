/*
 * Created by SharpDevelop.
 * User: Hemanth Sai
 * Date: 12/11/2015
 * Time: 4:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SqlConnector
{
	partial class InsertDetails
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		
		
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtDesignation;
		private System.Windows.Forms.Button btnSubmit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		 private void InitializeComponent()
        {
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.txtFirstName = new System.Windows.Forms.TextBox();
        	this.txtLastName = new System.Windows.Forms.TextBox();
        	this.txtAge = new System.Windows.Forms.TextBox();
        	this.txtDesignation = new System.Windows.Forms.TextBox();
        	this.btnSubmit = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(169, 83);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(109, 24);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "First Name";
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(169, 118);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(109, 24);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Last Name";
        	// 
        	// label3
        	// 
        	this.label3.Location = new System.Drawing.Point(169, 153);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(109, 24);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "Age";
        	// 
        	// label4
        	// 
        	this.label4.Location = new System.Drawing.Point(169, 188);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(109, 24);
        	this.label4.TabIndex = 3;
        	this.label4.Text = "Designation";
        	// 
        	// txtFirstName
        	// 
        	this.txtFirstName.Location = new System.Drawing.Point(284, 86);
        	this.txtFirstName.Name = "txtFirstName";
        	this.txtFirstName.Size = new System.Drawing.Size(120, 20);
        	this.txtFirstName.TabIndex = 4;
        	this.txtFirstName.TextChanged += new System.EventHandler(this.TxtFirstNameTextChanged);
        	// 
        	// txtLastName
        	// 
        	this.txtLastName.Location = new System.Drawing.Point(284, 118);
        	this.txtLastName.Name = "txtLastName";
        	this.txtLastName.Size = new System.Drawing.Size(120, 20);
        	this.txtLastName.TabIndex = 5;
        	// 
        	// txtAge
        	// 
        	this.txtAge.Location = new System.Drawing.Point(284, 150);
        	this.txtAge.Name = "txtAge";
        	this.txtAge.Size = new System.Drawing.Size(120, 20);
        	this.txtAge.TabIndex = 6;
        	// 
        	// txtDesignation
        	// 
        	this.txtDesignation.Location = new System.Drawing.Point(284, 188);
        	this.txtDesignation.Name = "txtDesignation";
        	this.txtDesignation.Size = new System.Drawing.Size(120, 20);
        	this.txtDesignation.TabIndex = 7;
        	// 
        	// btnSubmit
        	// 
        	this.btnSubmit.Location = new System.Drawing.Point(247, 271);
        	this.btnSubmit.Name = "btnSubmit";
        	this.btnSubmit.Size = new System.Drawing.Size(131, 23);
        	this.btnSubmit.TabIndex = 8;
        	this.btnSubmit.Text = "Submit";
        	this.btnSubmit.UseVisualStyleBackColor = true;
        	this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
        	// 
        	// InsertDetails
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(671, 470);
        	this.Controls.Add(this.btnSubmit);
        	this.Controls.Add(this.txtDesignation);
        	this.Controls.Add(this.txtAge);
        	this.Controls.Add(this.txtLastName);
        	this.Controls.Add(this.txtFirstName);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Name = "InsertDetails";
        	this.Text = "InsertDetails";
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
	}
}
