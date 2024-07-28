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

    public partial class DirectorAdminDashboard : Form
    {
        private bool isMenuStripVisible = true;

        public DirectorAdminDashboard()
        {
            InitializeComponent();
        }

        private void picMenuIcon_Click(object sender, EventArgs e)
        {
            directorMenu.Visible = !directorMenu.Visible;
        }

        private void auditStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifyStock auditstock = new VerifyStock();
            auditstock.Show();
            this.Hide();
        }

        private void forecastInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PredictInventory forecastinventory = new PredictInventory();
            forecastinventory.Show();
            this.Hide();
            
        }

        private void analzyeSaleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleData saledata = new SaleData();
            saledata.Show();
            this.Hide();
        }

        private void advertiseSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromoteSale advertisesale = new PromoteSale();
            advertisesale.Show();
            this.Hide();

        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TargetSale setsale = new TargetSale();
            setsale.Show();
            this.Hide();

        }
    }
}
