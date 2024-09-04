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
            int leaveRequestId = Convert.ToInt32(txt_Leave_Id.Text);
          

            if (leaveRequestId <=0)
            {
                MessageBox.Show("Please enter valid Leave Id to be process", "Invalid Leave Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CLeave viewLeaveDetails = new CLeave();
                DataTable leaveDetails = viewLeaveDetails.getLeave(leaveRequestId);
                dgvLeaveRequest.DataSource = leaveDetails;
            }



        }
    }
}
