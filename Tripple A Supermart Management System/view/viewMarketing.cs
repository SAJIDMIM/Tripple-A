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
    public partial class viewMarketing : Form
    {
        public viewMarketing()
        {
            InitializeComponent();
        }

        private void btn_Search_Marketing_Click(object sender, EventArgs e)
        {
            string marketingId = txt_Marketing_Id.Text;

            if (string.IsNullOrWhiteSpace(marketingId))
            {
                MessageBox.Show("Please enter a valid Marketing ID to be processed", "Invalid Marketing ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CMarketing viewMarketingDetails = new CMarketing();

            DataTable marketDetails = viewMarketingDetails.viewMarketing(marketingId);

            if (marketDetails == null || marketDetails.Rows.Count == 0)
            {
                MessageBox.Show("Marketing ID not found or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvMarketing.DataSource = marketDetails;
        }
       

        private void picDMDashboard_Click(object sender, EventArgs e)
        {
            digitalMarketerDash back = new digitalMarketerDash();
            back.Show();
            this.Hide();
        }
    }
}
