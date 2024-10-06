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
    public partial class approvePurchaseOrder : Form
    {
        public approvePurchaseOrder()
        {
            InitializeComponent();
        }

        private void approvePurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Approve_Order_Click(object sender, EventArgs e)
        {
            // Check if the order ID is empty
            if (string.IsNullOrWhiteSpace(txtOrderd.Text))
            {
                MessageBox.Show("Please enter a valid order ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string orderId = txtOrderd.Text;
            string status = cmbApproveStatus.SelectedItem.ToString();
            CCustomerOrder approval = new CCustomerOrder();
            approval.approvePurchaseOrder(orderId, status);


        }

        private void btn_Cancel_Order_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you really want to cancel this approval for given {orderId}", "Invalid Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picGoBackJuniorManger_Click(object sender, EventArgs e)
        {
            juniorManagerDash back = new juniorManagerDash();
            back.Show();
            this.Hide();

        }
        private bool IsValidOrderId(string orderId)
        {
            // Implement your ID validation logic here
            // For example:
            return orderId.Length == 2; // Assuming the ID should have a length of 10 characters
        }

        private void txtOrderd_TextChanged(object sender, EventArgs e)
        {
            if (txtOrderd.Text != "")
            {
                string orderId = txtOrderd.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidOrderId(orderId))
                {
                    CCustomerOrder newOrder = new CCustomerOrder();
                    DataTable orderDetails = newOrder.getOrder(orderId);

                    if (orderDetails.Rows.Count > 0)
                    {
                        DataRow row = orderDetails.Rows[0];


                        string status = row["status"].ToString();

                        // Check if the status is in the combobox items
                        if (cmbApproveStatus.Items.Contains(status))
                        {
                            cmbApproveStatus.SelectedItem = status;
                        }
                        else
                        {
                            // If the status is not in the combobox items, add it
                            cmbApproveStatus.Items.Add(status);
                            cmbApproveStatus.SelectedItem = status;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No order found with the provided Order ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear or reset the fields if no product is found

                        cmbApproveStatus.SelectedItem = null;
                    }
                }
                else
                {
                    // Do nothing, the ID is not valid
                }

            }
        }
    }
}

