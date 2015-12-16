using SqlConnector.Classes;
using SqlConnector.DBUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlConnector
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLConnector objSQL = new SQLConnector();
            objSQL.OpenConnection();
            objSQL.Query = "SELECT * FROM contacts;";
            DataTable dt = objSQL.ExecuteReadQuery();            
            objSQL.CloseConnection();
            List<Contact> lstContact = new List<Contact>();
            Contact objContact = new Contact();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                objContact = new Contact();
                objContact.FirstName = dt.Rows[i]["first_name"].ToString();
                objContact.LastName = dt.Rows[i]["last_name"].ToString();
                objContact.Designation = dt.Rows[i]["designation"].ToString();
                objContact.Age = dt.Rows[i]["age"].ToString();
                lstContact.Add(objContact);
            }
            dgvContact.AutoGenerateColumns = false;
            dgvContact.DataSource = lstContact;
        }

        private void dgvContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex
        }
		void BtnInsertClick(object sender, EventArgs e)
		{
			 this.Visible=false;
			 InsertDetails insertFrm = new InsertDetails();
			 insertFrm.Show();
		}
    }
}
