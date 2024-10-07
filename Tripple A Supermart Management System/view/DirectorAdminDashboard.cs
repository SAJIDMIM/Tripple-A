using System;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.view;

namespace Tripple_A_Supermart_Management_System
{
    public partial class DirectorAdminDashboard : Form
    {
        public DirectorAdminDashboard()
        {
            InitializeComponent();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProfile newUpdate = new UpdateProfile();
            newUpdate.Show();
            this.Hide();

        }

        private void weeklyStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeeklyStockReport viewStockWeekly = new WeeklyStockReport();
            viewStockWeekly.Show();
            this.Hide();
        }

        private void analyzeSaleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analyse_Sales_Data analyzeSale = new Analyse_Sales_Data();
            analyzeSale.Show();
            this.Hide();
        }

        private void promoteSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromoteSale newSale = new PromoteSale();
            newSale.Show();
            this.Show();
        }

        private void picGoBackDir_Click(object sender, EventArgs e)
        {
            AdminLogin back = new AdminLogin();
            back.Show();
            this.Hide();
        }

        private void monthlySaleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthlySale newSale = new MonthlySale();
            newSale.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin back = new AdminLogin();
            back.Show();
            this.Hide();
        }
    }
}
