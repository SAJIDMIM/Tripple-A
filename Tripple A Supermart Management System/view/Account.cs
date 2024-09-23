using System;
using System.Data;
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
            int userId;

            // Validate User ID
            if (!int.TryParse(txtUserId.Text, out userId) || userId <= 0)
            {
                MessageBox.Show("Please enter a valid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvAccountDetails.DataSource = null; // Clear the DataGridView
                return;
            }

            // Create an instance of the CAccount class.
            CAccount viewAccountDetails = new CAccount();

            // Call the viewAccount method to retrieve and display account details.
            DataTable accountDetails = viewAccountDetails.viewAccount(userId);

            if (accountDetails != null && accountDetails.Rows.Count > 0)
            {
                // Populate the DataGridView with the accountDetails data
                dgvAccountDetails.DataSource = accountDetails;
                txtUserId.Clear();
            }
            else
            {
                MessageBox.Show("No account details found for the given User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvAccountDetails.DataSource = null; // Clear the DataGridView
            }
        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            AdminDashboard goback = new AdminDashboard();
            goback.Show();
            this.Hide();
        }
    }
}

