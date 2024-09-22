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
    public partial class cashierDash : Form
    {
        public cashierDash()
        {
            InitializeComponent();
        }

        private void processRefundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proceeRefund startRefund = new proceeRefund();
            startRefund.Show();
            this.Hide();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewItems showItem = new viewItems();
            showItem.Show();
            this.Hide();

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewProduct showProduct = new viewProduct();
            showProduct.Show();
            this.Hide();
        }

        private void placeCustomerOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            placeCustomerOrder placeCustomerOrder = new placeCustomerOrder();
            placeCustomerOrder.Show();
            this.Hide();
        }

        private void addToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddtoCart addItems = new AddtoCart();
            addItems.Show();
            this.Hide();
        }

        private void monitorCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorCustomer newCustomer = new monitorCustomer();
            newCustomer.Show();
            this.Hide();
        }

        private void weekltPaymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            weeklyPayment showPayment = new weeklyPayment();
            showPayment.Show();
            this.Hide();
        }

        private void issueReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueReceipt newReceipt = new issueReceipt();
            newReceipt.Show();
            this.Hide();
        }

        private void generateCustomerBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerBill newBill = new CustomerBill();
            newBill.Show();
            this.Hide();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }
    }
}
