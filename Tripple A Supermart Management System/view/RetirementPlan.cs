using System;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class RetirementPlan : Form
    {
        public RetirementPlan()
        {
            InitializeComponent();
            DisplayNextRetirementId();
        }
        private void DisplayNextRetirementId()
        {
            try
            {
                string nextRetirementId = model.RetirementPlan.GetNextRetirementId();
                txt_Retirement_Plan.Text = nextRetirementId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Retire_Click(object sender, EventArgs e)
        {
            string retirementId = txt_Retirement_Plan.Text;
            string employeeId = txt_Employee_Id.Text;
            string employeeFirstName = txt_Employee_First_Name.Text;
            string employeeLastName = txt_Employee_Last_Name.Text;
            string position = txt_Employee_Position.Text;
            string retireType = cmb_Retire_Type.Text;
            DateTime dateJoined = dtp_Joined_Date.Value;
            DateTime expectedRetireDate = dtp_expected_Retire.Value;
            string contribution = cmb_Contribution.Text;


            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(retirementId) ||
                string.IsNullOrWhiteSpace(employeeId) ||
                string.IsNullOrWhiteSpace(employeeFirstName) ||
                string.IsNullOrWhiteSpace(employeeLastName) ||
                string.IsNullOrWhiteSpace(position) ||
                string.IsNullOrWhiteSpace(retireType) ||
                string.IsNullOrWhiteSpace(contribution))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any required field is empty
            }

            CRetirementPlan newRetire = new CRetirementPlan();
            newRetire.addretireEmployee(retirementId, employeeId, employeeFirstName, employeeLastName, position, retireType, dateJoined, expectedRetireDate, contribution);

            // Clear the fields after recording
            ClearFields();
            DisplayNextRetirementId();


        }

        private void ClearFields()
        {
            txt_Employee_Id.Text = "";
            txt_Employee_First_Name.Text = "";
            txt_Employee_Last_Name.Text = "";
            txt_Employee_Position.Text = "";
            cmb_Retire_Type.SelectedIndex = -1;
            dtp_Joined_Date.Value = DateTime.Now;
            dtp_expected_Retire.Value = DateTime.Now;
            cmb_Contribution.SelectedIndex = -1;
        }

        private void txt_Employee_Id_Leave(object sender, EventArgs e)
        {

        }

        private void txt_Employee_Id_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Employee_Id.Text))
            {
                var details = model.RetirementPlan.GetEmployeeDetails(txt_Employee_Id.Text);
                txt_Employee_First_Name.Text = details.Item1;
                txt_Employee_Last_Name.Text = details.Item2;
                txt_Employee_Position.Text = details.Item3;


                // Ensure the DateJoined value is within the valid range of the DateTimePicker control
                DateTime dateJoined = details.Item4;
                if (dateJoined >= dtp_Joined_Date.MinDate && dateJoined <= dtp_Joined_Date.MaxDate)
                {
                    dtp_Joined_Date.Value = dateJoined;
                }

            }
        }

        private void pic_Hr_Dashboard_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }

        private void btn_Search_Employee_Click(object sender, EventArgs e)
        {

        }
    }
}


