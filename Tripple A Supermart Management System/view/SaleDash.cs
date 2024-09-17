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
    public partial class SaleDash : Form
    {
        public SaleDash()
        {
            InitializeComponent();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorDelivery showDelivery = new monitorDelivery();
            showDelivery.Show();
            this.Hide();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorSupplier showSupplier = new monitorSupplier();
            showSupplier.Show();
            this.Hide();
        }

        private void customerOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCustomerOrder showCustomerOrder = new viewCustomerOrder();
            showCustomerOrder.Show();
            this.Hide();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSale showSale = new viewSale();
            showSale.Show();
            this.Hide();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewProduct showProduct = new viewProduct();
            showProduct.Show();
            this.Hide();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewItems showItems = new viewItems();
            showItems.Show();
            this.Hide();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlySale showSaleReport = new MonthlySale();
            showSaleReport.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorProduct showProduct = new monitorProduct();
            showProduct.Show();
            this.Hide();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorItem showItem = new monitorItem();
            showItem.Show();
            this.Hide();
        }

        private void saleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            creaSale createNew = new creaSale();
            createNew.Show();
            this.Hide();
        }
    }
}
