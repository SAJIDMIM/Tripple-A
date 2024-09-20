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
    public partial class monitorProduct : Form
    {
        public monitorProduct()
        {
            InitializeComponent();
            // Attach the event listener
            cmbProductType.SelectedIndexChanged += cmbProductType_SelectedIndexChanged;
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            string productId = txt_Product_Id.Text;
            string productName = txt_Product_Name.Text;
            string category = cmbProductType.SelectedItem.ToString();
            int Quantity = int.Parse(txtQty.Text);
            string Description = txtDescription.Text;
            double price = double.Parse(txtPrice.Text);

            CProduct newProduct = new CProduct();
            newProduct.addProduct(productId, productName, category, Quantity, Description, price);
            // Clear or reset the fields if the text box is empty
            txt_Product_Name.Text = "";
            cmbProductType.SelectedIndex = -1; // Reset the combobox
            txtQty.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";


        }

        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            string productId = txt_Product_Id.Text;
            string productName = txt_Product_Name.Text;
            string category = cmbProductType.SelectedItem.ToString();
            int Quantity = int.Parse(txtQty.Text);
            string Description = txtDescription.Text;
            double price = double.Parse(txtPrice.Text);

            CProduct newProduct = new CProduct();
            newProduct.updateProduct(productId, productName, category, Quantity, Description, price);
            // Clear or reset the fields if the text box is empty
            txt_Product_Name.Text = "";
            cmbProductType.SelectedIndex = -1; // Reset the combobox
            txtQty.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }

        private void btn_Delete_Product_Click(object sender, EventArgs e)
        {
            string productId = txt_Product_Id.Text;
            

            CProduct newProduct = new CProduct();
            newProduct.removeProduct(productId);
            // Clear or reset the fields if the text box is empty
            txt_Product_Name.Text = "";
            cmbProductType.SelectedIndex = -1; // Reset the combobox
            txtQty.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }

        private void btn_Search_Product_Click(object sender, EventArgs e)
        {
            if (txt_Product_Id.Text != "")
            {
                string ProductId = txt_Product_Id.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidProductId(ProductId))
                {
                    CProduct newProduct = new CProduct();
                    DataTable productDetails = newProduct.viewProduct(ProductId);

                    if (productDetails.Rows.Count > 0)
                    {
                        DataRow row = productDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txt_Product_Name.Text = row["productName"].ToString();

                        // Assuming cmbProductType has items matching the categories in your database
                        if (cmbProductType.Items.Contains(row["category"].ToString()))
                        {
                            cmbProductType.SelectedItem = row["category"].ToString();
                        }
                        else
                        {
                            cmbProductType.SelectedIndex = -1; // or set to a default value
                        }

                        txtQty.Text = row["quantity"].ToString();
                        txtDescription.Text = row["description"].ToString();
                        txtPrice.Text = row["price"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No product found with the provided Product ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear or reset the fields if no product is found
                        txt_Product_Name.Text = "";
                        cmbProductType.SelectedIndex = -1; // Reset the combobox
                        txtQty.Text = "";
                        txtDescription.Text = "";
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
                txt_Product_Name.Text = "";
                cmbProductType.SelectedIndex = -1; // Reset the combobox
                txtQty.Text = "";
                txtDescription.Text = "";
                txtPrice.Text = "";
            }
            
        }

        private bool IsValidProductId(string productId)
        {
            // Implement your product ID validation logic here
            return true;
        }

        private void btn_Clear_Product_Click(object sender, EventArgs e)
        {
            // Clear or reset the fields if the text box is empty
            txt_Product_Name.Text = "";
            cmbProductType.SelectedIndex = -1; // Reset the combobox
            txtQty.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if quantity is not empty
            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                int quantity;
                // Check if quantity is a valid number
                if (int.TryParse(txtQty.Text, out quantity))
                {
                    // Calculate price based on selected product type
                    double unitPrice = 0.00;
                    if (cmbProductType.SelectedItem != null)
                    {
                        string selectedProductType = cmbProductType.SelectedItem.ToString();
                        if (selectedProductType == "Fruits")
                        {
                            unitPrice = 100.00;
                        }
                        else if (selectedProductType == "Vegetables")
                        {
                            unitPrice = 50.00;
                        }
                        else if (selectedProductType == "Electronics")
                        {
                            unitPrice = 500.00;
                        }
                        // Add similar logic for other product types if needed
                    }
                   
                    // Add similar logic for other product types if needed

                    // Update price textbox
                    double totalCost = quantity * unitPrice;
                    txtPrice.Text = totalCost.ToString("F2"); // Format as currency with 2 decimal places
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid quantity.", "Invalid Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Text = ""; // Clear price textbox if quantity is not a valid number
                }
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
