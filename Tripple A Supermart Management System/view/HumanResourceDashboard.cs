using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class HumanResourceDashboard : Form
    {
        public HumanResourceDashboard()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Job postJob = new Job();
            postJob.Show();
            this.Hide();

        }

        private void leaveRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leave leaveRequest = new Leave();
            leaveRequest.Show();
            this.Hide();
        }

        private void retirementPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetirementPlan newRetire = new RetirementPlan();
            newRetire.Show();
            this.Hide();
        }

        private void employeePerformanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EmployeePerformance employeePerform = new EmployeePerformance();
            employeePerform.Show();
            this.Hide();
        }

        private void scheduleInterviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interview schedule = new Interview();
            schedule.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee manageEmployee = new Employee();
            manageEmployee.Show();
            this.Hide();
        }
    }
}
