using System;
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
            int leaveRequestId = Convert.ToInt32(txt_Sale_Id.Text);
            CLeave viewLeaveDetails = new CLeave();

            // DataTable accountDetails = viewLeaveDetails.viewLeaveRequest(leaveRequestId);


        }
    }
}
