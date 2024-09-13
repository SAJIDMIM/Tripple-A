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
    public partial class BankAccount : Form
    {
        public BankAccount()
        {
            InitializeComponent();
        }

        private void btn_Add_Bank_Account_Click(object sender, EventArgs e)
        {
             string accountNumber = txt_accountNumber.Text;
             string accountType = cmbAccType.SelectedItem.ToString();
             double salary = double.Parse(txtEmpSalary.Text);
             string employeeId= txtEmployeeId.Text;
             string employeeName = txtEmpName.Text;
             string bankName = txtBankName.Text;
             string branch = cmbBranch.SelectedItem.ToString();
             DateTime openingDate = dtpOpeningDate.Value;
             string accountStatus = cmbAccountStatus.SelectedItem.ToString();

            // Validate input fields
            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                MessageBox.Show("Account number is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(accountType))
            {
                MessageBox.Show("Account type is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(employeeId))
            {
                MessageBox.Show("Employee ID is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(employeeName))
            {
                MessageBox.Show("Employee name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(bankName))
            {
                MessageBox.Show("Bank name is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(branch))
            {
                MessageBox.Show("Branch is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(accountStatus))
            {
                MessageBox.Show("Account status is required.");
                return;
            }

    
            if (!double.TryParse(txtEmpSalary.Text, out salary))
            {
                MessageBox.Show("Invalid salary format.");
                return;
            }


            CBankAccount newBank = new CBankAccount();
            newBank.addBankAccount(accountNumber, accountType, salary, employeeId, employeeName, bankName, branch, openingDate, accountStatus);
    }

        private void btn_Search_Employee_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmployeeId.Text;

            CBankAccount createEmployee = new CBankAccount();
            DataTable employeeDetails = createEmployee.getEmployeeDetails(employeeId);

            if (employeeDetails.Rows.Count > 0)
            {
                DataRow row = employeeDetails.Rows[0];

                // Update the fields with the retrieved data
                txtEmpName.Text = row["employeeName"].ToString();

                txtEmpSalary.Text = row["Salary"].ToString();
            }
            else
            {
                MessageBox.Show("No employee found with the provided Employee ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear or reset the fields if no employee is found
                txtEmpName.Text = ""; // Corrected field name
                txtEmpSalary.Text = ""; // Clear salary field

                // Clear all fields after inserting data
                txt_accountNumber.Text = "";
                cmbAccType.SelectedIndex = -1;
                txtEmpSalary.Text = "";
                txtEmployeeId.Text = "";
                txtEmpName.Text = "";
                txtBankName.Text = "";
                cmbBranch.SelectedIndex = -1;
                dtpOpeningDate.Value = DateTime.Now;
                cmbAccountStatus.SelectedIndex = -1;
            }
        }

        private void picGoAccDash_Click(object sender, EventArgs e)
        {
            accountDash back = new accountDash();
            back.Show();
            this.Hide();
        }
    }
    }

