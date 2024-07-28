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
    public partial class Employee : Form
    {
        private EmployeeController _employeeController;
        public Employee()
        {
            InitializeComponent();
            _employeeController = new EmployeeController();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            
              
                
                    string employeeId = txt_Employee_Id.Text;
                    string firstName = txt_First_Name.Text;
                    string lastName = txt_Last_Name.Text;
                    string empType = cmb_UserType.SelectedItem.ToString();
                    string position = cmbPosition.SelectedItem.ToString();
                    string department = cmbDepartment.SelectedItem.ToString();
                    DateTime dateJoined = dtp_Date_Join.Value;
                    float salary = float.Parse(txt_Salary.Text);
                    string retirement = cmbRetirement.SelectedItem.ToString();

                    _employeeController.addEmployee(employeeId, firstName, lastName, empType, position, department, dateJoined, salary, retirement);

               
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
    }
}

