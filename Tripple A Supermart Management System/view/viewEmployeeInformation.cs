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
    public partial class viewEmployeeInformation : Form
    {
        public viewEmployeeInformation()
        {
            InitializeComponent();
        }

        private void btn_Search_Employee_Click(object sender, EventArgs e)
        {
            string employeeId = txt_Employee_Id.Text;

            if (string.IsNullOrWhiteSpace(employeeId))
            {
                MessageBox.Show("Please enter a valid employee ID to be processed", "Invalid Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeController viewEmployeeDetails = new EmployeeController();
            DataTable employeeDetails = viewEmployeeDetails.viewEmployee(employeeId);

            if (employeeDetails == null || employeeDetails.Rows.Count == 0)
            {
                MessageBox.Show("Employee ID not found. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvEmployee.DataSource = employeeDetails;
        }
    

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
