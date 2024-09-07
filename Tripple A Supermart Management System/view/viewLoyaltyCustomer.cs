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
    public partial class viewLoyaltyCustomer : Form
    {
        public viewLoyaltyCustomer()
        {
            InitializeComponent();
        }

        private void btn_Search_Loyalty_Customer_Click(object sender, EventArgs e)
        {
            string mobile = txtMobile.Text;

            CCustomer viewNormalDetails = new CCustomer();
            // Clear the DataGridView before processing
            dgvLoyaltyCustomers.DataSource = null;
            dgvLoyaltyCustomers.Rows.Clear();


            // Check if the customer is a normal customer
            DataTable normalDetails = viewNormalDetails.viewNormalCustomer(mobile, "Normal");

            if (normalDetails.Rows.Count > 0)
            {
                // Show message if mobile belongs to a normal customer
                MessageBox.Show("The mobile number belongs to a Normal customer.", "Normal Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if it's a loyalty customer
                DataTable loyaltyDetails = viewNormalDetails.viewNormalCustomer(mobile, "Loyalty");

                if (loyaltyDetails.Rows.Count > 0)
                {
                    // Bind loyalty customer data to DataGridView
                    dgvLoyaltyCustomers.DataSource = loyaltyDetails;
                }
                else
                {
                    // No customer found
                    MessageBox.Show("No customer found with the provided mobile number.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void picGoBackGeneralManager_Click(object sender, EventArgs e)
        {
            GeneralDash back = new GeneralDash();
            back.Show();
            this.Hide();
        }
    }
}
