using System;
using System.Data;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class ViewLeaveRequest : Form
    {
        public ViewLeaveRequest()
        {
            InitializeComponent();
        }

        private void btn_Search_Sale_Click(object sender, EventArgs e)
        {
            int leaveRequestId;

            // Check if the leave request ID is a valid integer
            if (!int.TryParse(txt_Leave_Id.Text, out leaveRequestId))
            {
                MessageBox.Show("Please enter a valid leave request ID.", "Invalid Leave Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (leaveRequestId <= 0)
            {
                MessageBox.Show("Please enter a valid leave request ID to be processed", "Invalid Leave Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CLeave viewLeaveDetails = new CLeave();
            DataTable leaveDetails = viewLeaveDetails.getLeave(leaveRequestId);

            if (leaveDetails == null)
            {
                MessageBox.Show("Leave request ID not found. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvLeave.DataSource = leaveDetails;




        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
