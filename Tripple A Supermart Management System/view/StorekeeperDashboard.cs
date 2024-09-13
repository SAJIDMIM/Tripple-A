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
    }
}
