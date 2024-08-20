using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Search_Account_Click(object sender, EventArgs e)
        {
            int userId =  Convert.ToInt32(txtUserId.Text);


            // Validate User ID
            if (userId <= 0)
            {
                MessageBox.Show("Please enter a valid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of the CAccount class.
            CAccount viewAccountDetails = new CAccount();

           
            // Call the viewAccount method to retrieve and display account details.
            DataTable accountDetails = viewAccountDetails.viewAccount(userId);

            // Now you need to populate the DataGridView with the accountDetails data
            dgvAccountDetails.DataSource = accountDetails; // Assuming you have a DataGridView named guna2DataGridView1
        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            AdminDashboard goback = new AdminDashboard();
            goback.Show();
            this.Hide();
        }
    }
}

