/*
 * Created by SharpDevelop.
 * User: Syed
 * Date: 12/14/2015
 * Time: 10:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MainExam
{
	partial class AddACollegeForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCollegeName;
		private System.Windows.Forms.TextBox txtCollegeEmail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCollegePhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox txtCollegeAddress;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		
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
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtCollegeName = new System.Windows.Forms.TextBox();
			this.txtCollegeEmail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCollegePhone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCollegeAddress = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(157, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name*";
			// 
			// txtCollegeName
			// 
			this.txtCollegeName.Location = new System.Drawing.Point(284, 95);
			this.txtCollegeName.Name = "txtCollegeName";
			this.txtCollegeName.Size = new System.Drawing.Size(100, 20);
			this.txtCollegeName.TabIndex = 1;
			// 
			// txtCollegeEmail
			// 
			this.txtCollegeEmail.Location = new System.Drawing.Point(284, 143);
			this.txtCollegeEmail.Name = "txtCollegeEmail";
			this.txtCollegeEmail.Size = new System.Drawing.Size(100, 20);
			this.txtCollegeEmail.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(157, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Email*";
			// 
			// txtCollegePhone
			// 
			this.txtCollegePhone.Location = new System.Drawing.Point(284, 196);
			this.txtCollegePhone.Name = "txtCollegePhone";
			this.txtCollegePhone.Size = new System.Drawing.Size(100, 20);
			this.txtCollegePhone.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(157, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Phone*";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(157, 243);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Address*";
			// 
			// txtCollegeAddress
			// 
			this.txtCollegeAddress.Location = new System.Drawing.Point(284, 243);
			this.txtCollegeAddress.Name = "txtCollegeAddress";
			this.txtCollegeAddress.Size = new System.Drawing.Size(157, 44);
			this.txtCollegeAddress.TabIndex = 7;
			this.txtCollegeAddress.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(203, 326);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(334, 326);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// AddACollegeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 390);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtCollegeAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCollegePhone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCollegeEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCollegeName);
			this.Controls.Add(this.label1);
			this.Name = "AddACollegeForm";
			this.Text = "AddACollegeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
