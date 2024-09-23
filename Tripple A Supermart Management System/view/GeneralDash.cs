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
            viewNormalCustomer showNormalCustomer = new viewNormalCustomer();
            showNormalCustomer.Show();
            this.Hide();
        }

        private void loyaltyCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewLoyaltyCustomer showLoyaltyCustomer = new viewLoyaltyCustomer();
            showLoyaltyCustomer.Show();
            this.Hide();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSupplier showSupplier = new showSupplier();
            showSupplier.Show();
            this.Hide();
        }

        private void monthlyCustomerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateCustomerReport generate = new generateCustomerReport();
            generate.Show();
            this.Hide();
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userProfile newProfile = new userProfile();
            newProfile.Show();
            this.Hide();
        }
    }
}
