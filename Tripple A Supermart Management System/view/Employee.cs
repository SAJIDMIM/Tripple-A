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
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Employee : Form
    {
        private CEmployee _employeeController;

      
        


        public Employee()
        {
            InitializeComponent();
            _employeeController = new CEmployee();
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
            float salary = float.Parse(txt_Salary.Text);
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
            string employeeId = txt_Employee_Id.Text; // Assuming txtEmployeeId is the input field for the ID
            
            if (!string.IsNullOrEmpty(employeeId))
            {
                EmployeeController employeeController = new EmployeeController();
                MEmployee employee = employeeController.LoadEmployeeData(employeeId);


               
            }

        }

        }
       

}

    


