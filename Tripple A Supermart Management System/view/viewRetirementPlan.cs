using System;
using System.Data;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class viewRetirementPlan : Form
    {
        public viewRetirementPlan()
        {
            InitializeComponent();
        }

        private void btn_Search_Retirement_Click(object sender, EventArgs e)
        {
            string retirementId = txtRetireId.Text;

            if (string.IsNullOrWhiteSpace(retirementId))
            {
                MessageBox.Show("Please enter a valid retirement ID to be processed", "Invalid Retirement Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CRetirementPlan viewRetireDetails = new CRetirementPlan();
            DataTable retireDetails = viewRetireDetails.viewretirementPlan(retirementId);

            if (retireDetails == null || retireDetails.Rows.Count == 0)
            {
                MessageBox.Show("Retirement ID not found. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvRetire.DataSource = retireDetails;

        }

        private void picHrManagerDash_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
