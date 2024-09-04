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


            if (employeeId == null)
            {
                MessageBox.Show("Please enter valid Employee Id to be process", "Invalid Employee Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeController viewEmployeeDetails = new EmployeeController();
                DataTable employeeDetails = viewEmployeeDetails.viewEmployee(employeeId);
                dgvEmployee.DataSource = employeeDetails;
            }
        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
