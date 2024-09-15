using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class viewStock : Form
    {
        public viewStock()
        {
            InitializeComponent();
        }

        private void picGoBackStr_Click(object sender, EventArgs e)
        {
            StorekeeperDashboard back = new StorekeeperDashboard();
            back.Show();
            this.Hide();
        }

        private void btn_Search_Item_Click(object sender, EventArgs e)
        {
            string stockId = txt_Stock_Id.Text;

            if (string.IsNullOrWhiteSpace(stockId))
            {
                MessageBox.Show("Please enter a valid Stock Id to be processed", "Invalid Stock Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CStock viewStock = new CStock();

            DataTable stockDetails = viewStock.viewStock(stockId);

            if (stockDetails == null || stockDetails.Rows.Count == 0)
            {
                MessageBox.Show("Stock ID not found", "Invalid Stock Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvStock.DataSource = stockDetails;
            }
        }
    }
}
