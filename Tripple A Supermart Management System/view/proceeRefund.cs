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
    public partial class proceeRefund : Form
    {
        public proceeRefund()
        {
            InitializeComponent();
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            if (txtProductId.Text != "")
            {
                string productId = txtProductId.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidProductId(productId))
                {
                    CRefund newProduct = new CRefund();
                    DataTable productDetails = newProduct.getProduct(productId);

                    if (productDetails.Rows.Count > 0)
                    {
                        DataRow row = productDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txtProductName.Text = row["productName"].ToString();
                        txtOriginalPrice.Text = row["price"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No product found with the provided Product ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear or reset the fields if no product is found
                        txtProductName.Text = "";
                        txtOriginalPrice.Text = "";
                    }
                }
                else
                {
                    // Do nothing, the ID is not valid
                }
            }
            else
            {
                // Clear or reset the fields if the text box is empty
                txtProductName.Text = "";
                txtOriginalPrice.Text = "";

            }
        }
        private bool IsValidProductId(string deliveryId)
        {
            // Implement your ID validation logic here
            // For example:
            return deliveryId.Length == 4; // Assuming the ID should have a length of 10 characters
        }
        private bool IsValidCustomerId(string deliveryId)
        {
            // Implement your ID validation logic here
            // For example:
            return deliveryId.Length == 10; // Assuming the ID should have a length of 10 characters
        }

        private void txt_Mobile_TextChanged(object sender, EventArgs e)
        {
            if (txt_Mobile.Text != "")
            {
                string mobile = txt_Mobile.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidCustomerId(mobile))
                {
                    CSale newCustomer = new CSale();
                    DataTable customerDetails = newCustomer.viewCustomer(mobile);

                    if (customerDetails.Rows.Count > 0)
                    {
                        DataRow row = customerDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txt_CustName.Text = row["customerName"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided Mobile Number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_CustName.Clear();
                    }
                }
                else
                {
                    // Do nothing, the ID is not valid
                }
            }
            else
            {
                // Clear or reset the fields if the text box is empty
                txt_CustName.Clear();

            }
        }

        private void btn_Process_Refund_Click(object sender, EventArgs e)
        {
            string refundId = txt_Refund_Id.Text;
            string mobile = txt_Mobile.Text;
            string customerName = txt_CustName.Text;
            string productId = txtProductId.Text;
            string productName = txtProductName.Text;
            DateTime refundDate = dtpRefundDate.Value;
            string Type = cmbType.SelectedItem.ToString();
            double refundAmount = double.Parse(txtRefundAmount.Text);
            double originalPrice = double.Parse(txtOriginalPrice.Text);
            string reason = txtReason.Text;
            string itemCondition = cmbItemCondition.SelectedItem.ToString();

            CRefund newRefund = new CRefund();
            newRefund.processRefund(refundId, mobile, customerName, productId, productName, refundDate, Type, refundAmount, originalPrice, reason, itemCondition);

            // Clear all fields
            txt_Refund_Id.Text = string.Empty;
            txt_Mobile.Text = string.Empty;
            txt_CustName.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            dtpRefundDate.Value = DateTime.Now;
            cmbType.SelectedItem = null;
            txtRefundAmount.Text = string.Empty;
            txtOriginalPrice.Text = string.Empty;
            txtReason.Text = string.Empty;
            cmbItemCondition.SelectedItem = null;
        }

        private void btn_Cancel_Refund_Click(object sender, EventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you sure want to cancel this Refund", "Refund Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void pic_Cash_Dash_Click(object sender, EventArgs e)
        {
            cashierDash back = new cashierDash();
            back.Show();
            this.Hide();
        }
    }
}
