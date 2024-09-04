using System.Windows.Forms;
using System;
using Tripple_A_Supermart_Management_System.controller;
using System.Data;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class ScheduleInterview : Form
    {
        public ScheduleInterview()
        {
            InitializeComponent();
            DisplayNextInterviewId();
        }
        private void DisplayNextInterviewId()
        {
            try
            {
                int nextInterviewId = model.Interview.GetNextInterviewId();
                txt_Interview_Id.Text = nextInterviewId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Schedule_Interview_Click(object sender, System.EventArgs e)
        {
            
            string employeeId = txt_Employee_Id.Text;
            string firstName = txt_First_Name.Text;
            string lastName = txt_Last_Name.Text;
            DateTime Date = dtp_Schedule_Date.Value;
            DateTime endDate = dtpendDate.Value;
            string Location = txt_Location.Text;
            string Type = cmb_Type.SelectedItem.ToString();
            string Status = cmb_Status_Interview.SelectedItem.ToString();
            string scheduleEmail = txtScheduleEmail.Text;

            
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(employeeId) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(Location) ||
                string.IsNullOrWhiteSpace(Type) ||
                string.IsNullOrWhiteSpace(scheduleEmail))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any required field is empty
            }

            CInterview newInterview = new CInterview();
            newInterview.scheduleInterview(employeeId, firstName, lastName, Date,endDate,Location, Type, Status, scheduleEmail);

            // Clear all fields
            txt_Interview_Id.Text = string.Empty;
            txt_Employee_Id.Text = string.Empty;
            txt_First_Name.Text = string.Empty;
            txt_Last_Name.Text = string.Empty;
            dtp_Schedule_Date.Value = DateTime.Now;
            dtpendDate.Value = DateTime.Now;
            txt_Location.Text = string.Empty;
            cmb_Type.SelectedIndex = -1;
            cmb_Status_Interview.SelectedIndex = -1;
            txtScheduleEmail.Text = string.Empty;

        }

        private void txt_Employee_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Employee_Click(object sender, EventArgs e)
        {
            string employeeId = txt_Employee_Id.Text.Trim();


            // Validate Employee ID
            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Please enter a valid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

      
            CInterview employee = new CInterview();

            // Call the method to retrieve and display employee details.
            DataTable employeeDetails = employee.viewEmployee(employeeId);

            if (employeeDetails.Rows.Count > 0)
            {
                // Display employee details
                txt_First_Name.Text = employeeDetails.Rows[0]["firstName"].ToString();
                txt_Last_Name.Text = employeeDetails.Rows[0]["lastName"].ToString();
               
            }
            else
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic_Hr_Dashboard_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }

        private void cmb_Status_Interview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
