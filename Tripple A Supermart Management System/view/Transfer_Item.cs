﻿using System;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Transfer_Item : Form
    {
        public Transfer_Item()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Transfer_Item_Click(object sender, EventArgs e)
        {
            string itemId = txt_itemId.Text;
            string itemName = txt_Item_Name.Text;
            string Description = txt_Description.Text;
            int Quantity = int.Parse(txt_Quantity.Text);
            string Category = cmbItemCategory.SelectedItem.ToString();
            string recipientEmail = txtEmail.Text; // Get email from UI element.



            // Validate input before calling the transferItem method
            if (string.IsNullOrEmpty(itemId) || string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(recipientEmail))
            {
                MessageBox.Show("Item ID, Item Name, and Recipient Email are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assuming sendItems is your ItemController instance
            CItem sendItems = new CItem();

            // Call transferItem
            bool isTransferred = sendItems.transferItem(itemId, itemName, Description, Quantity, Category, recipientEmail);

            if (isTransferred)
            {
                MessageBox.Show("Item successfully transferred!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to transfer item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            sendItems.transferItem(itemId, itemName, Description, Quantity, Category, recipientEmail);




        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            AdminDashboard goBack = new AdminDashboard();
            goBack.Show();
            this.Hide();
        }
    }
}
