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

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class HRManager : Form
    {
        public HRManager()
        {
            InitializeComponent();
        }

        private void picGoBackDir_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }

        private void postJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Job postJob = new Job();
            postJob.Show();
            this.Hide();
        }

        private void postJobToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewPostJob viewJobs = new viewPostJob();
            viewJobs.Show();
            this.Hide();
        }

        private void retirementPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetirementPlan newRetire = new RetirementPlan();
            newRetire.Show();
            this.Hide();
        }

        private void healthInsuranceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HealthInsurance newHealth = new HealthInsurance();
            newHealth.Show();
            this.Hide();
        }

        private void monitorEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            newEmployee.Show();
            this.Hide();
        }

        private void retirementPlanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewRetirementPlan retireDetails = new viewRetirementPlan();
            retireDetails.Show();
            this.Hide();
        }

        private void leaveRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void leaveRequestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form2 newLeave = new Form2();
                newLeave.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void scheduleEmployeeInterviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newLeave = new Form2();
            newLeave.Show();
            this.Hide();
        }
    }
}
