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
    public partial class StorekeeperDashboard : Form
    {
        public StorekeeperDashboard()
        {
            InitializeComponent();
        }

        private void placeStockOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOrder placeStockOrder = new StockOrder();
            placeStockOrder.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewItems showItem = new viewItems();
            showItem.Show();
            this.Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewStock showStock = new viewStock();
            showStock.Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewProduct showProduct = new viewProduct();
            showProduct.Show();
            this.Hide();
        }

        private void monitorStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorStock newStock = new monitorStock();
            newStock.Show();
            this.Hide();
        }

        private void generateStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void weeklyStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeeklyStockReport showStockReport = new WeeklyStockReport();
            showStockReport.Show();
            this.Hide();
        }
    }
}
