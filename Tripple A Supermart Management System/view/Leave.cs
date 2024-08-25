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
    public partial class CLeave : Form
    {
        private MLeave _mLeave;
       // private CEmployee _cLeave;

        public CLeave()
        {
            InitializeComponent();
            _mLeave = new MLeave();


            //_cLeave = new CEmployee();
            //txt_leaveId.Text = _cLeave.getleaveRequest().ToString();// Corrected method call to get leave request ID

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

            CLeave cleave = new CLeave();
            //cleave.addLeaveRequest(employeeId, userType, firstName, lastName, leaveType, reason, leaveStartDate, leaveEndDate);
            if (leaveStartDate == leaveEndDate)
            {
                MessageBox.Show("End date cannot be same as the start date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Validation Passed", "Valid Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }

        public void cmbuserType_SelectedIndexChanged(object sender, EventArgs e)
        {

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
