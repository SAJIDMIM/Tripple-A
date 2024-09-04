using System;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class HRManager : Form
    {
        public object EmployeeReport { get; private set; }

        public HRManager()
        {
            InitializeComponent();
        }

        private void picGoBackDir_Click(object sender, EventArgs e)
        {
            Login back = new Login();
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
            LeaveRequest newLeave = new LeaveRequest();
            newLeave.Show();
            this.Hide();
        }

        private void scheduleEmployeeInterviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleInterview newInterview = new ScheduleInterview();
            newInterview.Show();
            this.Hide();
        }

        private void leaveRequestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewLeaveRequest showLeaves = new ViewLeaveRequest();
            showLeaves.Show();
            this.Hide();
        }

        private void healthInsuranceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewHealthInsurance showHealth = new viewHealthInsurance();
            showHealth.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();

            
        }

        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewEmployeeInformation showEmployee = new viewEmployeeInformation();
            showEmployee.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void monthlyEmployeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlyEmployee showEmployee = new MonthlyEmployee();
            showEmployee.Show();
            this.Hide();
        }

        private void scheduleInterviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewInterview show = new viewInterview();
            show.Show();
            this.Hide();
        }
    }
}
