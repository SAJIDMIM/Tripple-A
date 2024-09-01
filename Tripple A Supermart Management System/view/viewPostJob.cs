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
    public partial class viewPostJob : Form
    {
        public viewPostJob()
        {
            InitializeComponent();
        }

        private void cmbPostJobId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string post_Id = cmbPostJobId.SelectedItem.ToString();
            CJob viewJobs = new CJob();
            viewJobs.viewPostJob(post_Id);
            DataTable dt = viewJobs.viewPostJob(post_Id);
            dgvJobs.DataSource = dt;
        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {

        }

        private void picHRDish_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
