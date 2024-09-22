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
    public partial class creaSale : Form
    {
        public creaSale()
        {
            InitializeComponent();
            DisplayNextSaleId();
        }
        private void DisplayNextSaleId()
        {
            try
            {
                int nextSaleId = model.Sale.GetNextSaleId();
                txt_Sale_Id.Text = nextSaleId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_Product_Id_TextChanged(object sender, EventArgs e)
        {
            if (txt_Product_Id.Text != "")
            {
                string productId = txt_Product_Id.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidProductId(productId))
                {
                    CSale newProduct = new CSale();
                    DataTable productDetails = newProduct.getProduct(productId);

                    if (productDetails.Rows.Count > 0)
                    {
                        DataRow row = productDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txtProdName.Text = row["productName"].ToString();
                        txtPrice.Text = row["price"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No product found with the provided Product ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear or reset the fields if no product is found
                        txtProdName.Text = "";
                        txtPrice.Text = "";
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
                txtProdName.Text = "";
                txtPrice.Text = "";
                
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

        private void txtCusId_TextChanged(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                string customerId = txtMobile.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidCustomerId(customerId))
                {
                    CSale newCustomer = new CSale();
                    DataTable customerDetails = newCustomer.viewCustomer(customerId);

                    if (customerDetails.Rows.Count > 0)
                    {
                        DataRow row = customerDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txtCusName.Text = row["customerName"].ToString();
                        

                    }
                    else
                    {
                        MessageBox.Show("No customer found with the Mobile Number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCusName.Clear();
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
                txtCusName.Clear();

            }
        }
        private void CalculateTotalPrice()
        {
            if (txtQty.Text != "" && txtPrice.Text != "" && txtDiscount.Text != "")
            {
                int quantity = int.Parse(txtQty.Text);
                double unitPrice = double.Parse(txtPrice.Text);
                double discountPercentage = double.Parse(txtDiscount.Text);

                double totalPrice = quantity * unitPrice;
                double discountAmount = totalPrice * (discountPercentage / 100);
                double finalPrice = totalPrice - discountAmount;

                txtTotalPrice.Text = finalPrice.ToString();
            }
            else
            {
                txtTotalPrice.Text = "";
            }
        }
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void btn_Add_Sale_Click(object sender, EventArgs e)
        {
            // Get the values from the UI controls
            int saleId;
            if (!int.TryParse(txt_Sale_Id.Text, out saleId))
            {
                MessageBox.Show("Invalid sale ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productId = txt_Product_Id.Text;
            if (string.IsNullOrEmpty(productId))
            {
                MessageBox.Show("Product ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productName = txtProdName.Text;
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Product name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price;
            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity;
            if (!int.TryParse(txtQty.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime saleStartDate = dtpStartSale.Value;
            DateTime saleEndDate = dtpEndDate.Value; // assume dtpEndSale is the correct control

            double totalPrice;
            if (!double.TryParse(txtTotalPrice.Text, out totalPrice))
            {
                MessageBox.Show("Invalid total price. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double discount;
            if (!double.TryParse(txtDiscount.Text, out discount))
            {
                MessageBox.Show("Invalid discount. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string payMethod = cmbPayMethod.SelectedItem.ToString();
            if (string.IsNullOrEmpty(payMethod))
            {
                MessageBox.Show("Pay method is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mobile = txtMobile.Text;
            if (string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Mobile number is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName = txtCusName.Text;
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer name is required.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            // Check if all fields are required
            if (string.IsNullOrEmpty(txt_Sale_Id.Text) ||
                string.IsNullOrEmpty(txt_Product_Id.Text) ||
                string.IsNullOrEmpty(txtProdName.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtQty.Text) ||
                string.IsNullOrEmpty(txtTotalPrice.Text) ||
                string.IsNullOrEmpty(txtDiscount.Text) ||
                string.IsNullOrEmpty(cmbPayMethod.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(txtMobile.Text) ||
                string.IsNullOrEmpty(txtCusName.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.");
                return;
            }

            CSale newSale = new CSale();
            newSale.createSale(productId,productName,price,quantity,saleStartDate,saleEndDate,totalPrice,discount,payMethod,mobile,customerName);

            txt_Sale_Id.Text = "";
            txt_Product_Id.Text = "";
            txtProdName.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            dtpStartSale.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtTotalPrice.Text = "";
            txtDiscount.Text = "";
            cmbPayMethod.SelectedIndex = -1;
            txtMobile.Text = "";
            txtCusName.Text = "";

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void btn_Cancel_Sale_Click(object sender, EventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you sure want to cancel this sale", "Sale Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(closeResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void pic_Sale_Dash_Click(object sender, EventArgs e)
        {
            SaleDash back = new SaleDash();
            back.Show();
            this.Hide();
        }
    }
}
