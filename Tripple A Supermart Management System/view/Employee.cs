using System;
using System.Data;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Employee : Form
    {
        //private CEmployee _employeeController;





        public Employee()
        {
            InitializeComponent();
            // _employeeController = new CEmployee();
        }
        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {



            string employeeId = txt_Employee_Id.Text;
            string firstName = txt_First_Name.Text;
            string lastName = txt_Last_Name.Text;
            string empType = cmb_UserType.SelectedItem.ToString();
            string actorId = txt_Actor_Id.Text;
            string position = cmbPosition.SelectedItem.ToString();
            string department = cmbDepartment.SelectedItem.ToString();
            DateTime dateJoined = dtp_Date_Join.Value;
            double salary = float.Parse(txt_Salary.Text);
            string retirement = cmbRetirement.SelectedItem.ToString();

            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Employee ID is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate other input fields as needed

            EmployeeController newEmployee = new EmployeeController();
            newEmployee.addEmployee(employeeId, firstName, lastName, empType, actorId, position, department, dateJoined, salary, retirement);

            // Clear the input fields
            txt_Employee_Id.Text = string.Empty;
            txt_First_Name.Text = string.Empty;
            txt_Last_Name.Text = string.Empty;
            cmb_UserType.SelectedItem = null;
            txt_Actor_Id.Text = string.Empty;
            cmbPosition.SelectedItem = null;
            cmbDepartment.SelectedItem = null;
            dtp_Date_Join.Value = DateTime.Now;
            txt_Salary.Text = string.Empty;
            cmbRetirement.SelectedItem = null;








        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txt_Employee_Id.Text))
            {
                MessageBox.Show("Employee ID is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txt_First_Name.Text))
            {
                MessageBox.Show("First name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txt_Last_Name.Text))
            {
                MessageBox.Show("Last name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Add more validation for other fields as needed

            return true;
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Employee_Id_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_Update_Employee_Click(object sender, EventArgs e)
        {

            string employeeId = txt_Employee_Id.Text;
            string firstName = txt_First_Name.Text;
            string lastName = txt_Last_Name.Text;
            string empType = cmb_UserType.SelectedItem.ToString();
            string actorId = txt_Actor_Id.Text;
            string position = cmbPosition.SelectedItem.ToString();
            string department = cmbDepartment.SelectedItem.ToString();
            DateTime dateJoined = dtp_Date_Join.Value;
            double salary = double.Parse(txt_Salary.Text);
            string retirement = cmbRetirement.SelectedItem.ToString();

            EmployeeController updateEmployee = new EmployeeController();
            updateEmployee.editEmployee(employeeId, firstName, lastName, empType, actorId, position, department, dateJoined, salary, retirement);

            // Clear the input fields
            txt_Employee_Id.Text = string.Empty;
            txt_First_Name.Text = string.Empty;
            txt_Last_Name.Text = string.Empty;
            cmb_UserType.SelectedItem = null;
            txt_Actor_Id.Text = string.Empty;
            cmbPosition.SelectedItem = null;
            cmbDepartment.SelectedItem = null;
            dtp_Date_Join.Value = DateTime.Now;
            txt_Salary.Text = string.Empty;
            cmbRetirement.SelectedItem = null;

        }

        private void btn_Delete_Employee_Click(object sender, EventArgs e)
        {
            string employeeId = txt_Employee_Id.Text;
            string firstName = txt_First_Name.Text;
            string lastName = txt_Last_Name.Text;
            string empType = cmb_UserType.SelectedItem.ToString();
            string actorId = txt_Actor_Id.Text;
            string position = cmbPosition.SelectedItem.ToString();
            string department = cmbDepartment.SelectedItem.ToString();
            DateTime dateJoined = dtp_Date_Join.Value;
            double salary = double.Parse(txt_Salary.Text);
            string retirement = cmbRetirement.SelectedItem.ToString();

            EmployeeController updateEmployee = new EmployeeController();
            updateEmployee.deleteEmployee(employeeId);

            // Clear the input fields
            txt_Employee_Id.Text = string.Empty;
            txt_First_Name.Text = string.Empty;
            txt_Last_Name.Text = string.Empty;
            cmb_UserType.SelectedItem = null;
            txt_Actor_Id.Text = string.Empty;
            cmbPosition.SelectedItem = null;
            cmbDepartment.SelectedItem = null;
            dtp_Date_Join.Value = DateTime.Now;
            txt_Salary.Text = string.Empty;
            cmbRetirement.SelectedItem = null;
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

            // Create an instance of the EmployeeController class.
            EmployeeController employeeController = new EmployeeController();

            // Call the method to retrieve and display employee details.
            DataTable employeeDetails = employeeController.viewEmployee(employeeId);

            if (employeeDetails.Rows.Count > 0)
            {
                // Display employee details
                txt_First_Name.Text = employeeDetails.Rows[0]["firstName"].ToString();
                txt_Last_Name.Text = employeeDetails.Rows[0]["lastName"].ToString();
                cmb_UserType.SelectedIndex = cmb_UserType.Items.IndexOf(employeeDetails.Rows[0]["empType"].ToString());
                txt_Actor_Id.Text = employeeDetails.Rows[0]["actorId"].ToString();
                cmbPosition.SelectedIndex = cmbPosition.Items.IndexOf(employeeDetails.Rows[0]["position"].ToString());
                cmbDepartment.SelectedIndex = cmbDepartment.Items.IndexOf(employeeDetails.Rows[0]["department"].ToString());
                dtp_Date_Join.Value = Convert.ToDateTime(employeeDetails.Rows[0]["dateJoined"]);
                txt_Salary.Text = employeeDetails.Rows[0]["salary"].ToString();
                cmbRetirement.SelectedIndex = cmbRetirement.Items.IndexOf(employeeDetails.Rows[0]["retirement"].ToString());
            }
            else
            {
                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Employee_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            txt_Employee_Id.Text = string.Empty;
            txt_First_Name.Text = string.Empty;
            txt_Last_Name.Text = string.Empty;
            cmb_UserType.SelectedItem = null;
            txt_Actor_Id.Text = string.Empty;
            cmbPosition.SelectedItem = null;
            cmbDepartment.SelectedItem = null;
            dtp_Date_Join.Value = DateTime.Now;
            txt_Salary.Text = string.Empty;
            cmbRetirement.SelectedItem = null;
        }
    }
}




