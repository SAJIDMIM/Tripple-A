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
    public partial class juniorManagerDash : Form
    {
        public juniorManagerDash()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }

        private void normalCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewNormalCustomer showNormalCustomer = new viewNormalCustomer();
            showNormalCustomer.Show();
            this.Hide();
        }

        private void loyaltyCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewLoyaltyCustomer showLoyalty = new viewLoyaltyCustomer();
            showLoyalty.Show();
            this.Hide();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSupplier showSupplier = new viewSupplier();
            showSupplier.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            approvePurchaseOrder newApprovalOrder = new approvePurchaseOrder();
            newApprovalOrder.Show();
            this.Hide();
        }
    }
}
