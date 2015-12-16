/*
 * Created by SharpDevelop.
 * User: Hemanth Sai
 * Date: 12/12/2015
 * Time: 3:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MockTest
{
	partial class UpdatePopUp
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtStudentId;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnUpdate;
		
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
			this.txtStudentId = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(155, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "StudentId";
			// 
			// txtStudentId
			// 
			this.txtStudentId.Location = new System.Drawing.Point(261, 71);
			this.txtStudentId.Name = "txtStudentId";
			this.txtStudentId.Size = new System.Drawing.Size(159, 20);
			this.txtStudentId.TabIndex = 1;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(133, 132);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(100, 29);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "< Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(293, 132);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(114, 29);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// UpdatePopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 288);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.txtStudentId);
			this.Controls.Add(this.label1);
			this.Name = "UpdatePopUp";
			this.Text = "UpdatePopUp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
