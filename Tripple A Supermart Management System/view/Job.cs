using System;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Job : Form
    {




        public Job()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_jobTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbjobType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_JobDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            string post_Id = txt_publishId.Text;
            string Job_Title = txt_jobTitle.Text;
            string jobType = cmbjobType.SelectedItem != null ? cmbjobType.SelectedItem.ToString() : string.Empty;

            string Job_Description = txt_JobDescription.Text;
            DateTime Date = dtpPostDate.Value;
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(post_Id) ||
                string.IsNullOrWhiteSpace(Job_Title) ||
                string.IsNullOrWhiteSpace(jobType) ||
                string.IsNullOrWhiteSpace(Job_Description))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any required field is empty
            }

            CJob newJob = new CJob();
            newJob.postJob(post_Id, Job_Title, jobType, Job_Description, Date);


        }




        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_publishId.Clear();
            txt_jobTitle.Clear();
            cmbjobType.SelectedIndex = -1;
            txt_JobDescription.Clear();
        }

        private void picHrDish_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
