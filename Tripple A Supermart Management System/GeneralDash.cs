using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.view;

namespace Tripple_A_Supermart_Management_System
{
    public partial class GeneralDash : Form
    {
        public GeneralDash()
        {
            InitializeComponent();
        }

        private void normalCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loyaltyCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthlyCustomerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picGoBackLogin_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
