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
    public partial class placeCustomerOrder : Form
    {
        public placeCustomerOrder()
        {
            InitializeComponent();
            txtTax.Text = "0.3"; // Set the tax rate to 0.3%
            txtTax.ReadOnly = true; // Make the textbox read-only
        }

        private void txtCustId_TextChanged(object sender, EventArgs e)
        {
            if (txtCustId.Text != "")
            {
                string mobile = txtCustId.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidCustomerId(mobile))
                {
                    CCustomerOrder newCustomer = new CCustomerOrder();
                    DataTable customerDetails = newCustomer.viewCustomer(mobile);

                    if (customerDetails.Rows.Count > 0)
                    {
                        DataRow row = customerDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txtCustName.Text = row["customerName"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided Mobile Number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCustName.Clear();
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
                txtCustName.Clear();

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
        private bool IsValidItemId(string deliveryId)
        {
            // Implement your ID validation logic here
            // For example:
            return deliveryId.Length == 3; // Assuming the ID should have a length of 10 characters
        }
        private bool IsValidStockId(string deliveryId)
        {
            // Implement your ID validation logic here
            // For example:
            return deliveryId.Length == 5; // Assuming the ID should have a length of 10 characters
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            if (txtProductId.Text != "")
            {
                string productId = txtProductId.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidProductId(productId))
                {
                    CCustomerOrder newProduct = new CCustomerOrder();
                    DataTable productDetails = newProduct.getProduct(productId);

                    if (productDetails.Rows.Count > 0)
                    {
                        DataRow row = productDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txtProductName.Text = row["productName"].ToString();


                    }
                    else
                    {
                        MessageBox.Show("No product found with the provided Product ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear or reset the fields if no product is found
                        txtProductName.Text = "";

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


            }
        }

        private void txtItemId_TextChanged(object sender, EventArgs e)
        {

        }
        private void CalculateTotalPrice()
        {
            if (txtQty.Text != "" && txtUnitPrice.Text != "" && txtDiscount.Text != "")
            {
                int quantity = int.Parse(txtQty.Text);
                double unitPrice = double.Parse(txtUnitPrice.Text);
                double discountPercentage = double.Parse(txtDiscount.Text);
                double taxRate = 0.3; // Use the fixed tax rate value

                double totalPrice = quantity * unitPrice;
                double discountAmount = totalPrice * (discountPercentage / 100);
                double taxableAmount = totalPrice - discountAmount;
                double taxAmount = taxableAmount * (taxRate / 100);
                double finalPrice = taxableAmount + taxAmount;

                txtTotalAmount.Text = finalPrice.ToString();
            }
            else
            {
                txtTotalAmount.Text = "";
            }
        }

        private void btn_Place_Customer_Order_Click(object sender, EventArgs e)
        {
            string orderId = txt_Order_Id.Text;
            string mobile = txtCustId.Text;
            string customerName = txtCustName.Text;
            string productId = txtProductId.Text;
            string productName = txtProductName.Text;
            string itemId = txtItemId.Text;
            string itemName = txtItemName.Text;
            int Quantity = int.Parse(txtQty.Text);
            double unitprice = double.Parse(txtUnitPrice.Text);
            double discount = double.Parse(txtDiscount.Text);
            double tax = double.Parse(txtTax.Text);
            double totalprice = double.Parse(txtTotalAmount.Text);
            string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();
            DateTime payDate = dtpPayDate.Value;
            string status = cmbPaymentStatus.SelectedItem.ToString();
            string stockId = txt_Stock_Id.Text;
            string stockName = txt_Stock_Name.Text;

            CCustomerOrder newOrder = new CCustomerOrder();
            newOrder.placeOrder(orderId, mobile, customerName, productId, productName, itemId, itemName, Quantity, unitprice, discount, tax, totalprice, paymentMethod, payDate, status,stockId,stockName);

            // Clear the fields
            txt_Order_Id.Text = string.Empty;
            txtCustId.Text = string.Empty;
            txtCustName.Text = string.Empty;
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtItemId.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            
            txtTotalAmount.Text = string.Empty;
            cmbPaymentMethod.SelectedItem = null;
            dtpPayDate.Value = DateTime.Now;
            cmbPaymentStatus.SelectedItem = null;
            txt_Stock_Id.Text = string.Empty;
            txt_Stock_Name.Text = string.Empty;
        }

        private void btn_Cancel_Customer_Order_Click(object sender, EventArgs e)
        {

            DialogResult closeResult = MessageBox.Show("Are you sure want to cancel this Order", "Order Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void Btn_Searchitem_Click(object sender, EventArgs e)
        {
            if (txtItemId.Text != "")
            {
                string itemId = txtItemId.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                try

                {
                    CCustomerOrder newItem = new CCustomerOrder();
                    DataTable itemDetails = newItem.getItem(itemId);

                    if (itemDetails.Rows.Count > 0)
                    {
                        DataRow row = itemDetails.Rows[0];
                        txtItemName.Text = row["itemName"].ToString();
                        txtQty.Text = row["Quantity"].ToString();
                        txtUnitPrice.Text = row["unitprice"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No item found with the provided Item ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItemName.Text = "";
                        txtQty.Text = "";
                        txtUnitPrice.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Stock_Id_TextChanged(object sender, EventArgs e)
        {
            if (txt_Stock_Id.Text.Length >= 4) // adjust this value to the length of your stock ID
            {
                string stockId = txt_Stock_Id.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                try
                {
                    CCustomerOrder newStock = new CCustomerOrder();
                    DataTable stockDetails = newStock.viewStock(stockId);

                    if (stockDetails.Rows.Count > 0)
                    {
                        DataRow row = stockDetails.Rows[0];
                        txt_Stock_Name.Text = row["stockName"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Stock found with the provided Stock ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Stock_Name.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                txt_Stock_Name.Text = "";
            }
        }

        private void txt_Stock_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
