﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class monitorDelivery : Form
    {
        public monitorDelivery()
        {
            InitializeComponent();
        }

        private void btn_Add_Delivery_Click(object sender, EventArgs e)
        {
            string deliveryId = txt_Delivery_Id.Text;
            if (!string.IsNullOrEmpty(deliveryId))
            {
                string deliveryName = txt_Delivery_Name.Text;
                string contactNumber = txt_Delivery_Contact.Text;
                string deliveryAddress = txt_Delivery_Address.Text;
                string deliveryType = cmbDeliveryType.SelectedItem.ToString();
                string availableStatus = cmbAvailableStatus.SelectedItem.ToString();

                CDelivery newDelivery = new CDelivery();
                newDelivery.addDelivery(deliveryId, deliveryName, contactNumber, deliveryAddress, deliveryType, availableStatus);
                // Clear or reset the fields if the text box is empty
                txt_Delivery_Name.Text = "";
                cmbDeliveryType.SelectedIndex = -1; // Reset the combobox
                txt_Delivery_Contact.Text = "";
                txt_Delivery_Address.Text = "";
                cmbAvailableStatus.SelectedIndex = -1; // Reset the combobox
            }
            else
            {
                MessageBox.Show("Delivery Id is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Delivery_Click(object sender, EventArgs e)
        {
            string deliveryId = txt_Delivery_Id.Text;

            // Check if delivery ID is empty or null
            if (string.IsNullOrWhiteSpace(deliveryId))
            {
                MessageBox.Show("Please enter a valid Delivery ID", "Invalid Delivery ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string deliveryName = txt_Delivery_Name.Text;
            string contactNumber = txt_Delivery_Contact.Text;
            string deliveryAddress = txt_Delivery_Address.Text;

            // Check if required fields are empty or null
            if (string.IsNullOrWhiteSpace(deliveryName) || string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(deliveryAddress))
            {
                MessageBox.Show("Please fill in all required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if contact number is a valid phone number
            if (!Regex.IsMatch(contactNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string deliveryType = cmbDeliveryType.SelectedItem?.ToString();
            string availableStatus = cmbAvailableStatus.SelectedItem?.ToString();

            // Check if delivery type and available status are selected
            if (string.IsNullOrWhiteSpace(deliveryType) || string.IsNullOrWhiteSpace(availableStatus))
            {
                MessageBox.Show("Please select a delivery type and available status", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CDelivery newDelivery = new CDelivery();
            newDelivery.updateDelivery(deliveryId, deliveryName, contactNumber, deliveryAddress, deliveryType, availableStatus);

            // Clear or reset the fields
            txt_Delivery_Name.Text = "";
            cmbDeliveryType.SelectedIndex = -1; // Reset the combobox
            txt_Delivery_Contact.Text = "";
            txt_Delivery_Address.Text = "";
            cmbAvailableStatus.SelectedIndex = -1; // Reset the combobox
        }

        private void btn_Delete_Delivery_Click(object sender, EventArgs e)
        {
            string deliveryId = txt_Delivery_Id.Text;

            // Check if delivery ID is empty or null
            if (string.IsNullOrWhiteSpace(deliveryId))
            {
                MessageBox.Show("Please enter a valid Delivery ID", "Invalid Delivery ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CDelivery newDelivery = new CDelivery();

            // Check if the delivery ID exists before deleting
            if (deliveryId == null)
            {
                MessageBox.Show("Delivery ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newDelivery.deleteDelivery(deliveryId);

            // Clear or reset the fields
            txt_Delivery_Name.Text = "";
            cmbDeliveryType.SelectedIndex = -1; // Reset the combobox
            txt_Delivery_Contact.Text = "";
            txt_Delivery_Address.Text = "";
            cmbAvailableStatus.SelectedIndex = -1; // Reset the combobox
        }

        private void txt_Delivery_Id_TextChanged(object sender, EventArgs e)
        {
            if (txt_Delivery_Id.Text != "")
            {
                string DeliveryId = txt_Delivery_Id.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidDeliveryId(DeliveryId))
                {
                    CDelivery newDelivery = new CDelivery();
                    DataTable deliveryDetails = newDelivery.searchDelivery(DeliveryId);

                    if (deliveryDetails.Rows.Count > 0)
                    {
                        DataRow row = deliveryDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txt_Delivery_Name.Text = row["deliveryName"].ToString();

                        // Assuming cmbDeliveryType has items matching the delivery types in your database
                        if (cmbDeliveryType.Items.Contains(row["deliveryType"].ToString()))
                        {
                            cmbDeliveryType.SelectedItem = row["deliveryType"].ToString();
                        }
                        else
                        {
                            cmbDeliveryType.SelectedIndex = -1; // or set to a default value
                        }

                        txt_Delivery_Contact.Text = row["contactNumber"].ToString();
                        txt_Delivery_Address.Text = row["deliveryAddress"].ToString();

                        // Assuming cmbAvailableStatus has items matching the available statuses in your database
                        if (cmbAvailableStatus.Items.Contains(row["availableStatus"].ToString()))
                        {
                            cmbAvailableStatus.SelectedItem = row["availableStatus"].ToString();
                        }
                        else
                        {
                            cmbAvailableStatus.SelectedIndex = -1; // or set to a default value
                        }
                    }
                    else
                    {
                        MessageBox.Show("No delivery found with the provided Delivery ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear or reset the fields if no delivery is found
                        txt_Delivery_Name.Text = "";
                        cmbDeliveryType.SelectedIndex = -1; // Reset the combobox
                        txt_Delivery_Contact.Text = "";
                        txt_Delivery_Address.Text = "";
                        cmbAvailableStatus.SelectedIndex = -1; // Reset the combobox
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
                txt_Delivery_Name.Text = "";
                cmbDeliveryType.SelectedIndex = -1; // Reset the combobox
                txt_Delivery_Contact.Text = "";
                txt_Delivery_Address.Text = "";
                cmbAvailableStatus.SelectedIndex = -1; // Reset the combobox
            }
        }

        private void btn_Search_Delivery_Click(object sender, EventArgs e)
        {
          
        }
        private bool IsValidDeliveryId(string deliveryId)
        {
            // Implement your ID validation logic here
            // For example:
            return deliveryId.Length == 2; // Assuming the ID should have a length of 10 characters
        }

        private void picGoBackSaleDash_Click(object sender, EventArgs e)
        {
            SaleDash back = new SaleDash();
            back.Show();
            this.Hide();
        }

        private void btn_Clear_Delivery_Click(object sender, EventArgs e)
        {

            // Clear or reset the fields if the text box is empty
            txt_Delivery_Name.Text = "";
            cmbDeliveryType.SelectedIndex = -1; // Reset the combobox
            txt_Delivery_Contact.Text = "";
            txt_Delivery_Address.Text = "";
            cmbAvailableStatus.SelectedIndex = -1; // Reset the combobox
        }
    }
}
