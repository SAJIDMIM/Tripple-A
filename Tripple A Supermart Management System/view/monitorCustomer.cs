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
    public partial class monitorCustomer : Form
    {
        public monitorCustomer()
        {
            InitializeComponent();
        }

        private void monitorCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            string customerId = txt_Cus_Id.Text;
            string customerName = txtCusName.Text;
            DateTime DoB = dtpDoB.Value;
            string Gender;
            if (rbMale.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            string Email = txtEmail.Text;
            string City = txtCity.Text;
            string Street = txtStreet.Text;
            int PoastalCode = int.Parse(txtPoastalCode.Text);
            string mobile = txtMobile.Text;
            string Type = cmbType.SelectedItem.ToString();

            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(customerId) || string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Street) || string.IsNullOrWhiteSpace(txtPoastalCode.Text) || string.IsNullOrWhiteSpace(mobile) || string.IsNullOrWhiteSpace(Type))
            {
                MessageBox.Show("All fields are required", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if postal code is a valid number
            if (!int.TryParse(txtPoastalCode.Text, out PoastalCode))
            {
                MessageBox.Show("Invalid postal code", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CCustomer newCustomer = new CCustomer();
            newCustomer.addCustomer(customerId, customerName, DoB, Gender, Email, City, Street, PoastalCode, mobile, Type);
            clearAllFields();




        }

        private void btn_Update_Customer_Click(object sender, EventArgs e)
        {
            string customerId = txt_Cus_Id.Text;
            string customerName = txtCusName.Text;
            DateTime DoB = dtpDoB.Value;
            string Gender;
            if (rbMale.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            string Email = txtEmail.Text;
            string City = txtCity.Text;
            string Street = txtStreet.Text;
            int PoastalCode = int.Parse(txtPoastalCode.Text);
            string mobile = txtMobile.Text;
            string Type = cmbType.SelectedItem.ToString();


            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(customerId) || string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(City) || string.IsNullOrWhiteSpace(Street) || string.IsNullOrWhiteSpace(txtPoastalCode.Text) || string.IsNullOrWhiteSpace(mobile) || string.IsNullOrWhiteSpace(Type))
            {
                MessageBox.Show("All fields are required", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if postal code is a valid number
            if (!int.TryParse(txtPoastalCode.Text, out PoastalCode))
            {
                MessageBox.Show("Invalid postal code", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CCustomer newCustomer = new CCustomer();
            newCustomer.editCustomer(customerId, customerName, DoB, Gender, Email, City, Street, PoastalCode, mobile, Type);
            clearAllFields();

        }

        private void btn_Delete_Customer_Click(object sender, EventArgs e)
        {

            string mobile = txtMobile.Text;

            // Check if mobile number is filled
            if (string.IsNullOrWhiteSpace(mobile))
            {
                MessageBox.Show("Mobile number is required", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if mobile number is valid (assuming it's a unique identifier)
            if (!IsValidCustomerId(mobile))
            {
                MessageBox.Show("Invalid mobile number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CCustomer newCustomer = new CCustomer();
            newCustomer.removeCustomer(mobile);
            clearAllFields();

        }
        
      
        private void clearAllFields()
        {
            txt_Cus_Id.Text = "";
            txtCusName.Text = "";
            dtpDoB.Value = DateTime.Now;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtEmail.Text = "";
            txtCity.Text = "";
            txtStreet.Text = "";
            txtPoastalCode.Text = "";
            txtMobile.Text = "";
            cmbType.SelectedIndex = -1;
        }
        private bool IsValidCustomerId(string deliveryId)
        {
            // Implement your ID validation logic here
            // For example:
            return deliveryId.Length == 10; // Assuming the ID should have a length of 10 characters
        }
        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                string mobile = txtMobile.Text;

                // Check if the ID is valid (e.g. it has a certain length or format)
                if (IsValidCustomerId(mobile))
                {
                    CCustomer newCustomer = new CCustomer();
                    DataTable customerDetails = newCustomer.viewCustomers(mobile);

                    if (customerDetails.Rows.Count > 0)
                    {
                        DataRow row = customerDetails.Rows[0];

                        // Update the fields with the retrieved data
                        txt_Cus_Id.Text = row["customerId"].ToString();
                        txtCusName.Text = row["customerName"].ToString();
                        dtpDoB.Value = Convert.ToDateTime(row["DoB"]);
                        if (row["Gender"].ToString() == "Male")
                        {
                            rbMale.Checked = true;
                        }
                        else
                        {
                            rbFemale.Checked = true;
                        }
                        txtEmail.Text = row["Email"].ToString();
                        txtCity.Text = row["City"].ToString();
                        txtStreet.Text = row["Street"].ToString();
                        txtPoastalCode.Text = row["PostalCode"].ToString();
                        cmbType.SelectedItem = row["Type"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided Mobile Number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearAllFields();
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
                clearAllFields();
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
