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
    public partial class assignCustomerService : Form
    {
        public assignCustomerService()
        {
            InitializeComponent();
            DisplayNextServiceId();
        }
        private void DisplayNextServiceId()
        {
            try
            {
                int nextServiceId = model.CustomerService.GetNextCustomerServiceId();
                txt_Customer_ServiceId.Text = nextServiceId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Search_Customer_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            string mobile = txtMobile.Text;
            string customerName = txtCustomerName.Text;

            // Validate input
            if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Please enter a mobile number to search for a customer.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CCustomerService showCustomer = new CCustomerService();
            DataTable customerDetails = showCustomer.getCustomerDetails(mobile);

            if (customerDetails.Rows.Count > 0)
            {
                DataRow row = customerDetails.Rows[0];

                // Update the fields with the retrieved data
                txtCustomerId.Text = row["customerId"].ToString();
                txtCustomerName.Text = row["customerName"].ToString();
                txtMobile.Text = row["mobile"].ToString(); // Assuming "mobile" is a column in your DataTable
            }
            else
            {
                MessageBox.Show("No customer found with the provided Mobile Number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear or reset the fields if no customer is found
                txtCustomerId.Text = "";
                txtCustomerName.Text = "";
            }
        }

        private void btn_Assign_Service_Click(object sender, EventArgs e)
        {

            // Validate input
            if (string.IsNullOrEmpty(txt_Customer_ServiceId.Text) ||
                string.IsNullOrEmpty(txtCustomerId.Text) ||
                string.IsNullOrEmpty(txtCustomerName.Text) ||
                cmbType.SelectedItem == null ||
                string.IsNullOrEmpty(txtFeedback.Text) ||
                string.IsNullOrEmpty(txtMobile.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate date
            if (dtpResponseTime.Value < DateTime.Now)
            {
                MessageBox.Show("Response time cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate mobile number
            if (!IsValidMobileNumber(txtMobile.Text))
            {
                MessageBox.Show("Invalid mobile number. Please enter a valid 10-digit mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate customer ID
            if (!IsValidCustomerId(txtCustomerId.Text))
            {
                MessageBox.Show("Invalid customer ID. Please enter a valid customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //int HealthInsuranceID = Convert.ToInt32(txt_health_InsuranceId.Text);
            int CustomerServiceId = Convert.ToInt32(txt_Customer_ServiceId.Text);
            string customerId = txtCustomerId.Text;
            string customerName = txtCustomerName.Text;
            string Type = cmbType.SelectedItem.ToString();
          
            DateTime responseTime = dtpResponseTime.Value;
           
            string feedback = txtFeedback.Text;
            
            string mobile = txtMobile.Text;

     
            CCustomerService newService = new CCustomerService();
            newService.sendCustomerService(customerId, customerName, Type, responseTime, feedback, mobile);

            // Clear the fields
            txt_Customer_ServiceId.Text = string.Empty;
            txtCustomerId.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            cmbType.SelectedItem = null;
            dtpResponseTime.Value = DateTime.Now; // Set the response time to the current time
            txtFeedback.Text = string.Empty;
            txtMobile.Text = string.Empty;
        }
        private bool IsValidMobileNumber(string mobileNumber)
        {
            // Check if the mobile number is a 10-digit number
            if (mobileNumber.Length != 10 || !mobileNumber.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        private bool IsValidCustomerId(string customerId)
        {
            // Check if the customer ID is a valid integer
            if (!int.TryParse(customerId, out _))
            {
                return false;
            }
            return true;
        }

        private void picSupervisor_Click(object sender, EventArgs e)
        {
            supervisorDash back = new supervisorDash();
            back.Show();
            this.Hide();
        }
    }
}
