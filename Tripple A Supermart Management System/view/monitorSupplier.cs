using System;
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
    public partial class monitorSupplier : Form
    {
        public monitorSupplier()
        {
            InitializeComponent();
        }

        private void btn_Add_Supplier_Click(object sender, EventArgs e)
        {
            string supplierId = txt_Supplier_Id.Text;

            // Check if supplier ID is empty or null
            if (string.IsNullOrWhiteSpace(supplierId))
            {
                MessageBox.Show("Please enter a valid Supplier ID", "Invalid Supplier ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string supplierName = txt_Supplier_Name.Text;
            string mobile = txt_Supplier_Contact.Text;
            string company = txt_Supplier_Company.Text;
            string productType = cmbProductType.SelectedItem?.ToString();
            string payTerm = txtPayTerms.Text;
            string comment = txtComment.Text;

            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(supplierName) || string.IsNullOrWhiteSpace(mobile) || string.IsNullOrWhiteSpace(company) || string.IsNullOrWhiteSpace(productType) || string.IsNullOrWhiteSpace(payTerm) || string.IsNullOrWhiteSpace(comment))
            {
                MessageBox.Show("Please fill in all required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if mobile number is a valid phone number
            if (!Regex.IsMatch(mobile, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime deliverySchedule = dtpDelSchedule.Value;

            CSupplier newSupplier = new CSupplier();
            newSupplier.addSupplierDetails(supplierId, supplierName, mobile, company, productType, deliverySchedule, payTerm, comment);

            // Clear or reset the fields
            txt_Supplier_Name.Text = "";
            cmbProductType.SelectedIndex = -1; // Reset the combobox
            txt_Supplier_Contact.Text = "";
            txt_Supplier_Company.Text = "";
            dtpDelSchedule.Value = DateTime.Now; // Reset the date time picker
            txtPayTerms.Text = "";
            txtComment.Text = "";
        }
        
        private void btn_Update_Supplier_Click(object sender, EventArgs e)
        {
            string supplierId = txt_Supplier_Id.Text;

            // Check if supplier ID is empty or null
            if (string.IsNullOrWhiteSpace(supplierId))
            {
                MessageBox.Show("Please enter a valid Supplier ID", "Invalid Supplier ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string supplierName = txt_Supplier_Name.Text;
            string mobile = txt_Supplier_Contact.Text;
            string company = txt_Supplier_Company.Text;
            string productType = cmbProductType.SelectedItem?.ToString();
            string payTerm = txtPayTerms.Text;
            string comment = txtComment.Text;

            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(supplierName) || string.IsNullOrWhiteSpace(mobile) || string.IsNullOrWhiteSpace(company) || string.IsNullOrWhiteSpace(productType) || string.IsNullOrWhiteSpace(payTerm) || string.IsNullOrWhiteSpace(comment))
            {
                MessageBox.Show("Please fill in all required fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if mobile number is a valid phone number
            if (!Regex.IsMatch(mobile, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime deliverySchedule = dtpDelSchedule.Value;

            // Check if supplier ID exists before updating
            CSupplier newSupplier = new CSupplier();
            if (supplierId == null)
            {
                MessageBox.Show("Supplier ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newSupplier.updateSupplierDetails(supplierId, supplierName, mobile, company, productType, deliverySchedule, payTerm, comment);

            // Clear or reset the fields
            txt_Supplier_Name.Text = "";
            cmbProductType.SelectedIndex = -1; // Reset the combobox
            txt_Supplier_Contact.Text = "";
            txt_Supplier_Company.Text = "";
            dtpDelSchedule.Value = DateTime.Now; // Reset the date time picker
            txtPayTerms.Text = "";
            txtComment.Text = "";
        }

        private void btn_Delete_Supplier_Click(object sender, EventArgs e)
        {
            string supplierId = txt_Supplier_Id.Text;

            // Check if supplier ID is empty or null
            if (string.IsNullOrWhiteSpace(supplierId))
            {
                MessageBox.Show("Please enter a valid Supplier ID", "Invalid Supplier ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CSupplier newSupplier = new CSupplier();

            // Check if supplier ID exists before deleting
            if (supplierId == null)
            {
                MessageBox.Show("Supplier ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newSupplier.deleteSupplierDetails(supplierId);

            // Clear or reset the fields
            txt_Supplier_Name.Text = "";
            cmbProductType.SelectedIndex = -1; // Reset the combobox
            txt_Supplier_Contact.Text = "";
            txt_Supplier_Company.Text = "";
            dtpDelSchedule.Value = DateTime.Now; // Reset the date time picker
            txtPayTerms.Text = "";
            txtComment.Text = "";
        }

        private void txt_Supplier_Id_TextChanged(object sender, EventArgs e)
        {
            if (txt_Supplier_Id.Text != "")
            {
                string supplierId = txt_Supplier_Id.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidSupplierId(supplierId))
                {
                    CSupplier newSupplier = new CSupplier();
                    DataTable supplierDetails = newSupplier.viewSupplier(supplierId);

                    if (supplierDetails.Rows.Count > 0)
                    {
                        DataRow row = supplierDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txt_Supplier_Name.Text = row["supplierName"].ToString();
                        txt_Supplier_Contact.Text = row["mobile"].ToString();
                        txt_Supplier_Company.Text = row["company"].ToString();

                        // Assuming cmbProductType has items matching the product types in your database
                        if (cmbProductType.Items.Contains(row["productType"].ToString()))
                        {
                            cmbProductType.SelectedItem = row["productType"].ToString();
                        }
                        else
                        {
                            cmbProductType.SelectedIndex = -1; // or set to a default value
                        }

                        dtpDelSchedule.Value = Convert.ToDateTime(row["deliverySchedule"]);
                        txtPayTerms.Text = row["payTerm"].ToString();
                        txtComment.Text = row["comment"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No supplier found with the provided Supplier ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear or reset the fields if no supplier is found
                        txt_Supplier_Name.Text = "";
                        cmbProductType.SelectedIndex = -1; // Reset the combobox
                        txt_Supplier_Contact.Text = "";
                        txt_Supplier_Company.Text = "";
                        dtpDelSchedule.Value = DateTime.Now; // Reset the date time picker
                        txtPayTerms.Text = "";
                        txtComment.Text = "";
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
                txt_Supplier_Name.Text = "";
                cmbProductType.SelectedIndex = -1; // Reset the combobox
                txt_Supplier_Contact.Text = "";
                txt_Supplier_Company.Text = "";
                dtpDelSchedule.Value = DateTime.Now; // Reset the date time picker
                txtPayTerms.Text = "";
                txtComment.Text = "";
            }
        }
        private bool IsValidSupplierId(string supplierId)
        {
            // Implement your ID validation logic here
            // For example:
            return supplierId.Length == 2; // Assuming the ID should have a length of 10 characters
        }

        private void btn_Clear_Supplier_Click(object sender, EventArgs e)
        {
            // Clear or reset the fields if the text box is empty
            txt_Supplier_Name.Text = "";
            cmbProductType.SelectedIndex = -1; // Reset the combobox
            txt_Supplier_Contact.Text = "";
            txt_Supplier_Company.Text = "";
            dtpDelSchedule.Value = DateTime.Now; // Reset the date time picker
            txtPayTerms.Text = "";
            txtComment.Text = "";
        }

        private void picGoBackSaleDash_Click(object sender, EventArgs e)
        {
            SaleDash back = new SaleDash();
            back.Show();
            this.Hide();
        }
    }

}
