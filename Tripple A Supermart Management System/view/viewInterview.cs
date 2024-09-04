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
    public partial class viewInterview : Form
    {
        public viewInterview()
        {
            InitializeComponent();
        }

        private void btn_Search_Interview_Click(object sender, EventArgs e)
        {
            int InterviewID = Convert.ToInt32(txtInterviewId.Text);


            // Validate User ID
            if (InterviewID <= 0)
            {
                MessageBox.Show("Please enter a valid Interview ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CInterview showInterviews = new CInterview();

           
            DataTable interviewDetails = showInterviews.viewInterview(InterviewID);

          
            dgvInterview.DataSource = interviewDetails;
        }

        private void picHrManager_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
