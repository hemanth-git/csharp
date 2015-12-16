namespace SqlConnector
{
    partial class Contacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.dgvContact = new System.Windows.Forms.DataGridView();
        	this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.btnInsert = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// dgvContact
        	// 
        	this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.first_name,
			this.last_name,
			this.designation,
			this.age});
        	this.dgvContact.Location = new System.Drawing.Point(73, 12);
        	this.dgvContact.Name = "dgvContact";
        	this.dgvContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgvContact.Size = new System.Drawing.Size(510, 299);
        	this.dgvContact.TabIndex = 0;
        	this.dgvContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContact_CellClick);
        	// 
        	// first_name
        	// 
        	this.first_name.DataPropertyName = "FirstName";
        	this.first_name.HeaderText = "First Name";
        	this.first_name.Name = "first_name";
        	// 
        	// last_name
        	// 
        	this.last_name.DataPropertyName = "LastName";
        	this.last_name.HeaderText = "Last Name";
        	this.last_name.Name = "last_name";
        	// 
        	// designation
        	// 
        	this.designation.DataPropertyName = "designation";
        	this.designation.HeaderText = "Designation";
        	this.designation.Name = "designation";
        	// 
        	// age
        	// 
        	this.age.DataPropertyName = "age";
        	this.age.HeaderText = "Age";
        	this.age.Name = "age";
        	// 
        	// btnInsert
        	// 
        	this.btnInsert.Location = new System.Drawing.Point(183, 338);
        	this.btnInsert.Name = "btnInsert";
        	this.btnInsert.Size = new System.Drawing.Size(121, 35);
        	this.btnInsert.TabIndex = 1;
        	this.btnInsert.Text = "Insert";
        	this.btnInsert.UseVisualStyleBackColor = true;
        	this.btnInsert.Click += new System.EventHandler(this.BtnInsertClick);
        	// 
        	// Contacts
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(682, 420);
        	this.Controls.Add(this.btnInsert);
        	this.Controls.Add(this.dgvContact);
        	this.Name = "Contacts";
        	this.Text = "Contacts";
        	this.Load += new System.EventHandler(this.Form1_Load);
        	((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.Button btnInsert;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn designation;
    }
}

