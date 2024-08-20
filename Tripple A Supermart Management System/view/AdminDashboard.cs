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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void stockPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockPrice setStockPrice = new StockPrice();
            setStockPrice.Show();
            this.Hide();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProfile updateProfile = new UpdateProfile();
            updateProfile.Show();
            this.Hide();
        }

        private void generateCustomerBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerBill generateCustomerBill = new CustomerBill();
            generateCustomerBill.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Account viewAccount = new Account();
            viewAccount.Show();
            this.Hide();
        }

        private void minimumStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinimumStock setMinimum = new MinimumStock();
            setMinimum.Show();
            this.Hide();
        }

        private void transferItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer_Item transferItemDetails = new Transfer_Item();
            transferItemDetails.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            AdminLogin goBackLogin = new AdminLogin();
            goBackLogin.Show();
            this.Hide();
        }
    }
}
