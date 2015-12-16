/*
 * Created by SharpDevelop.
 * User: Syed
 * Date: 12/14/2015
 * Time: 10:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MainExam
{
	partial class ViewCollege
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCollegeNameDisplay;
		private System.Windows.Forms.Label lblCollegeMailDisplay;
		private System.Windows.Forms.Label lblCollegePhoneDisplay;
		private System.Windows.Forms.Label lblCollegeRatingDisplay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblCollegeAddressDisplay;
		
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
			this.lblCollegeNameDisplay = new System.Windows.Forms.Label();
			this.lblCollegeMailDisplay = new System.Windows.Forms.Label();
			this.lblCollegePhoneDisplay = new System.Windows.Forms.Label();
			this.lblCollegeRatingDisplay = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblCollegeAddressDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(445, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Viewing a college";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCollegeNameDisplay
			// 
			this.lblCollegeNameDisplay.AutoSize = true;
			this.lblCollegeNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCollegeNameDisplay.Location = new System.Drawing.Point(300, 120);
			this.lblCollegeNameDisplay.Name = "lblCollegeNameDisplay";
			this.lblCollegeNameDisplay.Size = new System.Drawing.Size(169, 29);
			this.lblCollegeNameDisplay.TabIndex = 1;
			this.lblCollegeNameDisplay.Text = "College Name";
			this.lblCollegeNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCollegeMailDisplay
			// 
			this.lblCollegeMailDisplay.AutoSize = true;
			this.lblCollegeMailDisplay.Location = new System.Drawing.Point(334, 180);
			this.lblCollegeMailDisplay.Name = "lblCollegeMailDisplay";
			this.lblCollegeMailDisplay.Size = new System.Drawing.Size(62, 13);
			this.lblCollegeMailDisplay.TabIndex = 2;
			this.lblCollegeMailDisplay.Text = "college mail";
			this.lblCollegeMailDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCollegePhoneDisplay
			// 
			this.lblCollegePhoneDisplay.AutoSize = true;
			this.lblCollegePhoneDisplay.Location = new System.Drawing.Point(334, 223);
			this.lblCollegePhoneDisplay.Name = "lblCollegePhoneDisplay";
			this.lblCollegePhoneDisplay.Size = new System.Drawing.Size(74, 13);
			this.lblCollegePhoneDisplay.TabIndex = 3;
			this.lblCollegePhoneDisplay.Text = "college phone";
			this.lblCollegePhoneDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCollegeRatingDisplay
			// 
			this.lblCollegeRatingDisplay.AutoSize = true;
			this.lblCollegeRatingDisplay.Location = new System.Drawing.Point(334, 267);
			this.lblCollegeRatingDisplay.Name = "lblCollegeRatingDisplay";
			this.lblCollegeRatingDisplay.Size = new System.Drawing.Size(70, 13);
			this.lblCollegeRatingDisplay.TabIndex = 4;
			this.lblCollegeRatingDisplay.Text = "college rating";
			this.lblCollegeRatingDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(319, 309);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 2);
			this.label2.TabIndex = 5;
			// 
			// lblCollegeAddressDisplay
			// 
			this.lblCollegeAddressDisplay.AutoSize = true;
			this.lblCollegeAddressDisplay.Location = new System.Drawing.Point(334, 359);
			this.lblCollegeAddressDisplay.Name = "lblCollegeAddressDisplay";
			this.lblCollegeAddressDisplay.Size = new System.Drawing.Size(81, 13);
			this.lblCollegeAddressDisplay.TabIndex = 6;
			this.lblCollegeAddressDisplay.Text = "college address";
			this.lblCollegeAddressDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ViewCollege
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 462);
			this.Controls.Add(this.lblCollegeAddressDisplay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblCollegeRatingDisplay);
			this.Controls.Add(this.lblCollegePhoneDisplay);
			this.Controls.Add(this.lblCollegeMailDisplay);
			this.Controls.Add(this.lblCollegeNameDisplay);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "ViewCollege";
			this.Text = "ViewCollege";
			this.Load += new System.EventHandler(this.ViewCollegeLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
