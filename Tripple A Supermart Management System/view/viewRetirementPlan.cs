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

            if (retirementId == null)
            {
                MessageBox.Show("Please enter valid Retirement Id to be process", "Invalid Retirement Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CRetirementPlan viewRetireDetails = new CRetirementPlan();



                DataTable retireDetails = viewRetireDetails.viewretirementPlan(retirementId);


                dgvRetire.DataSource = retireDetails;
            }




        }

        private void picHrManagerDash_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
