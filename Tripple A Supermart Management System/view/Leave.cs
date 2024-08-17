using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.model;
using Tripple_A_Supermart_Management_System.controller;


namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Leave : Form
    {
        private MLeave _mLeave;
        private CEmployee _cLeave;

        public Leave()
        {
            InitializeComponent();
            _mLeave = new MLeave();


            _cLeave = new CEmployee();
            txt_leaveId.Text = _cLeave.getleaveRequest().ToString();// Corrected method call to get leave request ID

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_leaveId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddLeave_Click(object sender, EventArgs e)
        {
            //calling the control class
            int leaveRequestId = Convert.ToInt32(txt_leaveId.Text);
            string employeeId = txt_employeeId.Text;
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string userType = cmbuserType.SelectedItem.ToString();
            DateTime leaveStartDate = dtpleaveStartDate.Value;
            DateTime leaveEndDate = dtpLeaveEndDate.Value;
            string leaveType = cmbLeaveType.SelectedItem.ToString();
            string reason = txtReason.Text;

            if (string.IsNullOrWhiteSpace(leaveType) || string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any field is empty
            }

            CEmployee cleave = new CEmployee();
            cleave.addLeaveRequest(employeeId, userType, firstName, lastName, leaveType, reason, leaveStartDate, leaveEndDate);
            if (leaveStartDate == leaveEndDate)
            {
                MessageBox.Show("End date cannot be same as the start date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Validation Passed", "Valid Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }

        public  void cmbuserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the text boxes initially
            txt_employeeId.Text = string.Empty;
            txtFirstname.Text = string.Empty;
            txtLastname.Text = string.Empty;

            try
            {
                // Check if an item is selected in the combo box
                if (cmbuserType.SelectedItem != null)
                {
                    // Get the selected user type as string
                    string userType = cmbuserType.SelectedItem.ToString();

                    // Ensure _cLeave is not null
                    if (_cLeave != null)
                    {
                        
                        // Retrieve the list of employees of the selected type using CLeave instance
                        List<model.Employees> employees = _cLeave.GetEmployeesByUserType(userType);

                        // If employees are found, populate the first employee's details into text boxes
                        if (employees != null && employees.Count > 0)
                        {
                            model.Employees employee = employees[0];
                            txt_employeeId.Text = employee.EmployeeId;
                            txtFirstname.Text = employee.FirstName;
                            txtLastname.Text = employee.LastName;
                        }
                    }
                    else
                    {
                        // Log or handle the case where _cLeave is null
                        MessageBox.Show("Error: _cLeave instance is not initialized.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //clear all the fields
            txt_leaveId.Clear();
            txt_employeeId.Clear();
            cmbuserType.SelectedIndex = -1;
            txtFirstname.Clear();
            txtLastname.Clear();
            dtpLeaveEndDate.CustomFormat = "";
            cmbLeaveType.SelectedIndex = -1;
            txtReason.Clear();
           
        }

        private void pic_back_login_Click(object sender, EventArgs e)
        {
           
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            string text = txtReason.Text;
            if(text.Length >10)
            {
                MessageBox.Show("Length is too high.Please check it and try again later", "Invalid Reason", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpLeaveEndDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbLeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
