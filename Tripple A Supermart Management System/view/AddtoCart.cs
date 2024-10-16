﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class AddtoCart : Form
    {
        public AddtoCart()
        {
            InitializeComponent();
            DisplayNextCartId();

        }
        private void DisplayNextCartId()
        {
            try
            {
                int nextCartId = model.AddtoCart.GetNextCartId();
                txt_Cart_Id.Text = nextCartId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddtoCart_Load(object sender, EventArgs e)
        {

        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
            // Only proceed when there is text in the Order ID field
            if (!string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                string orderId = txtOrderId.Text.Trim(); // Trim whitespace

                // Wait until at least 2 characters are entered before checking the order
                if (orderId.Length >= 2) // Example: Start fetching data when length is 2 or more
                {
                    try
                    {
                        CAddtoCart newOrder = new CAddtoCart();
                        DataTable orderDetails = newOrder.viewOrder(orderId);

                        if (orderDetails.Rows.Count > 0)
                        {
                            DataRow row = orderDetails.Rows[0];

                            // Populate fields with retrieved data
                            txtCustName.Text = row["customerName"].ToString();
                            txtPN.Text = row["productName"].ToString();
                            txtIN.Text = row["itemName"].ToString();
                            txtQty.Text = row["Quantity"].ToString();
                            txtUnitPrice.Text = row["unitprice"].ToString();
                            txtDiscount.Text = row["discount"].ToString();
                            txtTax.Text = row["tax"].ToString();
                            txtTotal.Text = row["totalprice"].ToString();

                            // Handle DateTime parsing
                            if (DateTime.TryParse(row["payDate"].ToString(), out DateTime payDate))
                            {
                                dtpPayDate.Value = payDate;
                            }

                            cmbPayMethod.Text = row["paymentMethod"].ToString();
                            txtStockName.Text = row["stockName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No order found with the provided Order ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields(); // Clear fields if no order found
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("An error occurred while retrieving the order details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields(); // Clear fields in case of an error
                    }
                }
                else
                {
                    // If the entered text is less than 2 characters, simply clear the fields and do not show an error
                    ClearFields();
                }
            }
            else
            {
                // Clear fields if the Order ID textbox is empty
                ClearFields();
            }


        }
        private void ClearFields()
        {
            txtCustName.Clear();
            txtPN.Clear();
            txtIN.Clear();
            txtQty.Clear();
            txtUnitPrice.Clear();
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            dtpPayDate.Value = DateTime.Now; // Reset to current date
            cmbPayMethod.SelectedIndex = -1; // Reset payment method
            txtStockName.Clear();
        }

        private void btn_Make_Payment_Click(object sender, EventArgs e)
        {

            string customerName = txtCustName.Text;
            string productName = txtPN.Text;
            string itemName = txtIN.Text;
            int Quantity = int.Parse(txtQty.Text);
            double unitprice = double.Parse(txtUnitPrice.Text);
            double discount = double.Parse(txtDiscount.Text);
            double tax = double.Parse(txtTax.Text);
            double totalprice = double.Parse(txtTotal.Text);
            DateTime payDate = dtpPayDate.Value;
            string paymentMethod;
            if (cmbPayMethod.SelectedItem != null)
            {
                paymentMethod = cmbPayMethod.SelectedItem.ToString();
            }
            else
            {
                // Handle the case where SelectedItem is null
                paymentMethod = string.Empty; // or some other default value
            }
            string stockName = txtStockName.Text;
            string orderId = txtOrderId.Text;

            CAddtoCart newCart = new CAddtoCart();
            newCart.addtoCart(customerName, productName, itemName, Quantity, unitprice, discount, tax, totalprice, payDate, paymentMethod, stockName, orderId);
            ClearFields();




        }
        private void CalculateTotalPrice()
        {
            if (!string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(txtUnitPrice.Text) && !string.IsNullOrEmpty(txtDiscount.Text))
            {
                int quantity = int.Parse(txtQty.Text);
                double unitPrice = double.Parse(txtUnitPrice.Text);
                double discountPercentage = double.Parse(txtDiscount.Text);
                double taxRate = 0.3; // Fixed tax rate value

                double totalPrice = quantity * unitPrice;
                double discountAmount = totalPrice * (discountPercentage / 100);
                double taxableAmount = totalPrice - discountAmount;
                double taxAmount = taxableAmount * (taxRate / 100);
                double finalPrice = taxableAmount + taxAmount;

                // Round off to 2 decimal places
                finalPrice = Math.Round(finalPrice, 2);

                // Display the final price as a string with 2 decimal points
                txtTotal.Text = finalPrice.ToString("F2");
            }
            else
            {
                txtTotal.Text = "";
            }
        }
        private void picUpdateCart_Click(object sender, EventArgs e)
        {

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

        private void btn_Issue_Receipt_Click(object sender, EventArgs e)
        {

        }

        private void btn_Issue_Receipt_Click_1(object sender, EventArgs e)
        {

            // 1. Retrieve Order Data
            string orderId = txtOrderId.Text.Trim(); // Trim for safety
            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.", "Invalid Order Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CAddtoCart cart = new CAddtoCart();

            // 2. Fetch Receipt Data
            DataTable receiptData;
            try
            {
                receiptData = cart.GetReceiptData(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving receipt data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if any data was retrieved
            if (receiptData == null || receiptData.Rows.Count == 0)
            {
                MessageBox.Show("No data found for the provided Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Format Receipt Content (Example using RichTextBox)
            RichTextBox receiptText = new RichTextBox();
            receiptText.Font = new Font("Courier New", 10);
            receiptText.Text = "Order Receipt\n\n";

            try
            {
                DataRow row = receiptData.Rows[0];
                receiptText.Text += $"Order ID: {row["orderId"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Customer Name: {row["CustomerName"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Product Name: {row["ProductName"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Item Name: {row["ItemName"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Quantity: {row["Quantity"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Unit Price: {row["UnitPrice"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Discount: {row["Discount"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Tax: {row["Tax"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Total Price: {row["TotalPrice"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Pay Date: {row["PayDate"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Payment Method: {row["PaymentMethod"]}\n"; // Adjust field names if needed
                receiptText.Text += $"Stock Name: {row["StockName"]}\n"; // Adjust field names if needed
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while formatting the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Print the Receipt
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, args) =>
            {
                // Draw the receipt content from the RichTextBox
                args.Graphics.DrawString(receiptText.Text, receiptText.Font,
                                          Brushes.Black, new PointF(10, 10));
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            // Open the print dialog and check the user's response
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while printing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pic_Cash_Dash_Click(object sender, EventArgs e)
        {
            cashierDash back = new cashierDash();
            back.Show();
            this.Hide();
        }

        private void btn_Generate_Customer_Bill_Click(object sender, EventArgs e)
        {
            // 1. Retrieve Order Data
            string orderId = txtOrderId.Text.Trim(); // Trim for safety
            if (string.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.", "Invalid Order ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CAddtoCart cart = new CAddtoCart();

            // 2. Fetch Bill Data
            DataTable billData;
            try
            {
                billData = cart.GetReceiptData(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving bill data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if any data was retrieved
            if (billData == null || billData.Rows.Count == 0)
            {
                MessageBox.Show("No data found for the provided Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Format Bill Content
            RichTextBox billText = new RichTextBox();
            billText.Font = new Font("Courier New", 10);
            billText.Text = "------------------------------------------------------------------------------\n";
            billText.Text += "           CUSTOMER BILL           \n";
            billText.Text += "-----------------------------------------------------------------------------\n";
            billText.Text += "Order Details\n";
            billText.Text += "-----------------------------------------------------------------------------\n";

            try
            {
                DataRow row = billData.Rows[0];

                billText.Text += $"Order ID: {row["orderId"]}\n"; // Adjust field names if needed
                billText.Text += $"Customer Name: {row["CustomerName"]}\n"; // Adjust field names if needed
                billText.Text += $"Date: {row["PayDate"]}\n"; // Adjust field names if needed
                billText.Text += $"Payment Method: {row["PaymentMethod"]}\n"; // Adjust field names if needed
                billText.Text += "--------------------------------------------------------------------------\n";

                // Add item details in a structured way
                billText.Text += "Items Purchased:\n";
                billText.Text += "--------------------------------------------------------------------------\n";
                billText.Text += $"{"Item Name",-20} {"Quantity",-10} {"Unit Price",-10} {"Total Price",-10}\n";
                billText.Text += "--------------------------------------------------------------------------\n";

                // You may need to loop through billData if there are multiple items
                foreach (DataRow itemRow in billData.Rows)
                {
                    string itemName = itemRow["ItemName"].ToString();
                    int quantity = Convert.ToInt32(itemRow["Quantity"]);
                    decimal unitPrice = Convert.ToDecimal(itemRow["UnitPrice"]);
                    decimal totalPrice = quantity * unitPrice; // Calculate total price for this item

                    billText.Text += $"{itemName,-20} {quantity,-10} {unitPrice,-10:C} {totalPrice,-10:C}\n"; // Adjust field names if needed
                }

                billText.Text += "---------------------------------------------------------------------------\n";
                billText.Text += $"Discount: {row["Discount"]:C}\n"; // Adjust field names if needed
                billText.Text += $"Tax: {row["Tax"]:C}\n"; // Adjust field names if needed
                billText.Text += $"Grand Total: {row["TotalPrice"]:C}\n"; // Adjust field names if needed
                billText.Text += "---------------------------------------------------------------------------\n";
                billText.Text += "Thank you for shopping with us!\n";
                billText.Text += "---------------------------------------------------------------------------\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while formatting the bill: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Print the Bill
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, args) =>
            {
                // Draw the bill content from the RichTextBox
                args.Graphics.DrawString(billText.Text, billText.Font, Brushes.Black, new PointF(10, 10));
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            // Open the print dialog and check the user's response
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to print the bill. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

