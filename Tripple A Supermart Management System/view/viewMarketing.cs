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

            if (marketingId == null)
            {
                MessageBox.Show("Please enter valid Marketing Id to be process", "Invalid Marketing Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CMarketing viewMarketingDetails = new CMarketing();


                DataTable marketDetails = viewMarketingDetails.viewMarketing(marketingId);



                dgvMarketing.DataSource = marketDetails;
            }
        }

        private void picDMDashboard_Click(object sender, EventArgs e)
        {
            digitalMarketerDash back = new digitalMarketerDash();
            back.Show();
            this.Hide();
        }
    }
}
