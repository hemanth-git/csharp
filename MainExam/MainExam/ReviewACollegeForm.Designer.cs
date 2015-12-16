/*
 * Created by SharpDevelop.
 * User: Syed
 * Date: 12/14/2015
 * Time: 10:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MainExam
{
	partial class ReviewACollegeForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCollegeList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbRating;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox txtComments;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnViewColleges;
		
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
			this.cmbCollegeList = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbRating = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtComments = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnViewColleges = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(149, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select the college*";
			// 
			// cmbCollegeList
			// 
			this.cmbCollegeList.FormattingEnabled = true;
			this.cmbCollegeList.Location = new System.Drawing.Point(291, 87);
			this.cmbCollegeList.Name = "cmbCollegeList";
			this.cmbCollegeList.Size = new System.Drawing.Size(121, 21);
			this.cmbCollegeList.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(149, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Rating (1-5)*";
			// 
			// cmbRating
			// 
			this.cmbRating.FormattingEnabled = true;
			this.cmbRating.Location = new System.Drawing.Point(291, 128);
			this.cmbRating.Name = "cmbRating";
			this.cmbRating.Size = new System.Drawing.Size(121, 21);
			this.cmbRating.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(149, 177);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Email*";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(291, 179);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(121, 20);
			this.txtEmail.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(149, 226);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Comments*";
			// 
			// txtComments
			// 
			this.txtComments.Location = new System.Drawing.Point(291, 223);
			this.txtComments.Name = "txtComments";
			this.txtComments.Size = new System.Drawing.Size(159, 50);
			this.txtComments.TabIndex = 7;
			this.txtComments.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(165, 308);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(282, 307);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnViewColleges
			// 
			this.btnViewColleges.Location = new System.Drawing.Point(396, 306);
			this.btnViewColleges.Name = "btnViewColleges";
			this.btnViewColleges.Size = new System.Drawing.Size(97, 23);
			this.btnViewColleges.TabIndex = 10;
			this.btnViewColleges.Text = "View Colleges";
			this.btnViewColleges.UseVisualStyleBackColor = true;
			// 
			// ReviewACollegeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 412);
			this.Controls.Add(this.btnViewColleges);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtComments);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbRating);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbCollegeList);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "ReviewACollegeForm";
			this.Text = "Review College";
			this.Load += new System.EventHandler(this.ReviewACollegeFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
