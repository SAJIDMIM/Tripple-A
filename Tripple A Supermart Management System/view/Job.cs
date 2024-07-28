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
    public partial class Job : Form
    {

        private string _postId;
        private string _jobTitle;
        private List<string> _jobTypes;
        private string _jobDescription;

        private controller.CJob _cPostJob;
        public Job()
        {
            InitializeComponent();
            _cPostJob = new controller.CJob();
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
            _postId = txt_publishId.Text;
            _jobTitle = txt_jobTitle.Text;

            _jobTypes = new List<string>();
            if (cmbjobType.SelectedItem != null)
            {
                _jobTypes.Add(cmbjobType.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a job type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if no job type is selected
            }

            _jobDescription = txt_JobDescription.Text;
            if (string.IsNullOrWhiteSpace(_postId) || string.IsNullOrWhiteSpace(_jobTitle) || string.IsNullOrWhiteSpace(_jobDescription))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any field is empty
            }

            _cPostJob.postJob(_postId, _jobTitle, _jobTypes, _jobDescription);
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
    }
}
