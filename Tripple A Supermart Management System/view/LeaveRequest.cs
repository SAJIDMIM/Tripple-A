using System;
using System.Data;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class LeaveRequest : Form
    {
        public LeaveRequest()
        {
            InitializeComponent();
            DisplayNexteaveId();
        }
        private void DisplayNexteaveId()
        {
            try
            {
                int nextLeaveId = model.Leave.GetNextLeaveId();
                txt_leaveId.Text = nextLeaveId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }

        private void pic_back_login_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }

        private void btn_Search_Leave_Click(object sender, EventArgs e)
        {

            string employeeId = txt_employeeId.Text;

            CLeave viewEmployee = new CLeave();
            DataTable employeeDetails = viewEmployee.getEmployee(employeeId);
            if (employeeDetails.Rows.Count > 0)
            {
                string empType = employeeDetails.Rows[0]["empType"].ToString();
                foreach (object item in cmbuserType.Items)
                {
                    if (item.ToString() == empType)
                    {
                        cmbuserType.SelectedItem = item;
                        break;
                    }
                }
                txtFirstname.Text = employeeDetails.Rows[0]["firstName"].ToString();
                txtLastname.Text = employeeDetails.Rows[0]["lastName"].ToString();
            }
            else
            {
                MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddLeave_Click(object sender, EventArgs e)
        {
            string employeeId = txt_employeeId.Text;
            string userType = cmbuserType.SelectedItem.ToString();
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            DateTime leaveStartDate = dtpleaveStartDate.Value;
            DateTime leaveEndDate = dtpLeaveEndDate.Value;
            string leaveType = cmbLeaveType.SelectedItem.ToString();
            string reason = txtReason.Text;

            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(employeeId) ||
                string.IsNullOrWhiteSpace(userType) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(leaveType) ||
                string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any required field is empty
            }

            CLeave newLeave = new CLeave();
            newLeave.addLeaveRequest(employeeId, userType, firstName, lastName,leaveType,reason,leaveStartDate,leaveEndDate);


        }
    }
}
