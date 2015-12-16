/*
 * Created by SharpDevelop.
 * User: Syed
 * Date: 12/14/2015
 * Time: 9:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MainExam
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvColleges;
		private System.Windows.Forms.DataGridViewTextBoxColumn collegeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn email;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn avgReview;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReview;
		private System.Windows.Forms.Button btnAddCollege;
		private System.Windows.Forms.Button btnViewCollege;
		private System.Windows.Forms.Button btnEditCollege;
		private System.Windows.Forms.Button btnDelete;
		
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
			this.dgvColleges = new System.Windows.Forms.DataGridView();
			this.collegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.avgReview = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReview = new System.Windows.Forms.Button();
			this.btnAddCollege = new System.Windows.Forms.Button();
			this.btnViewCollege = new System.Windows.Forms.Button();
			this.btnEditCollege = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvColleges)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvColleges
			// 
			this.dgvColleges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvColleges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.collegeName,
			this.Column1,
			this.email,
			this.phoneNumber,
			this.avgReview});
			this.dgvColleges.Location = new System.Drawing.Point(48, 135);
			this.dgvColleges.Name = "dgvColleges";
			this.dgvColleges.Size = new System.Drawing.Size(642, 235);
			this.dgvColleges.TabIndex = 0;
			this.dgvColleges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCollegesCellContentClick);
			// 
			// collegeName
			// 
			this.collegeName.DataPropertyName = "CollegeName";
			this.collegeName.HeaderText = "Name";
			this.collegeName.Name = "collegeName";
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "CollegeAddress";
			this.Column1.HeaderText = "Address";
			this.Column1.Name = "Column1";
			// 
			// email
			// 
			this.email.DataPropertyName = "CollegeEmail";
			this.email.HeaderText = "Email";
			this.email.Name = "email";
			// 
			// phoneNumber
			// 
			this.phoneNumber.DataPropertyName = "CollegePhone";
			this.phoneNumber.HeaderText = "Phone Number";
			this.phoneNumber.Name = "phoneNumber";
			// 
			// avgReview
			// 
			this.avgReview.DataPropertyName = "Avg";
			this.avgReview.HeaderText = "Average Review(out of 5)";
			this.avgReview.Name = "avgReview";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(297, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "List of Colleges";
			// 
			// btnReview
			// 
			this.btnReview.Location = new System.Drawing.Point(114, 63);
			this.btnReview.Name = "btnReview";
			this.btnReview.Size = new System.Drawing.Size(75, 23);
			this.btnReview.TabIndex = 2;
			this.btnReview.Text = "Review a college";
			this.btnReview.UseVisualStyleBackColor = true;
			this.btnReview.Click += new System.EventHandler(this.BtnReviewClick);
			// 
			// btnAddCollege
			// 
			this.btnAddCollege.Location = new System.Drawing.Point(578, 63);
			this.btnAddCollege.Name = "btnAddCollege";
			this.btnAddCollege.Size = new System.Drawing.Size(112, 23);
			this.btnAddCollege.TabIndex = 3;
			this.btnAddCollege.Text = "Add a college";
			this.btnAddCollege.UseVisualStyleBackColor = true;
			this.btnAddCollege.Click += new System.EventHandler(this.BtnAddCollegeClick);
			// 
			// btnViewCollege
			// 
			this.btnViewCollege.Location = new System.Drawing.Point(727, 188);
			this.btnViewCollege.Name = "btnViewCollege";
			this.btnViewCollege.Size = new System.Drawing.Size(75, 23);
			this.btnViewCollege.TabIndex = 4;
			this.btnViewCollege.Text = "View";
			this.btnViewCollege.UseVisualStyleBackColor = true;
			this.btnViewCollege.Click += new System.EventHandler(this.BtnViewCollegeClick);
			// 
			// btnEditCollege
			// 
			this.btnEditCollege.Location = new System.Drawing.Point(727, 242);
			this.btnEditCollege.Name = "btnEditCollege";
			this.btnEditCollege.Size = new System.Drawing.Size(75, 23);
			this.btnEditCollege.TabIndex = 5;
			this.btnEditCollege.Text = "Edit";
			this.btnEditCollege.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(727, 292);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 466);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEditCollege);
			this.Controls.Add(this.btnViewCollege);
			this.Controls.Add(this.btnAddCollege);
			this.Controls.Add(this.btnReview);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvColleges);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "MainExam";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvColleges)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
