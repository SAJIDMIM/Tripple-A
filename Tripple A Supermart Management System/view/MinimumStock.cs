using System;
using System.Data;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class MinimumStock : Form
    {
        public MinimumStock()
        {
            InitializeComponent();
        }

        private void btn_Set_Minimum_Stock_Click(object sender, EventArgs e)
        {
            string stockId = txt_stockId.Text;

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime stockDate = dtpStockDate.Value;
            DateTime lastUpdatedStock = dtpLastStock.Value;
            int reorderLevel = int.Parse(cmbReorderLevel.SelectedItem.ToString());
            // Validation for lastUpdatedStock
            if (lastUpdatedStock > DateTime.Now)
            {
                MessageBox.Show("Last Updated Stock Date cannot be in the future.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            CStock minimumStock = new CStock();
            minimumStock.setMinimumStock(stockId, quantity, lastUpdatedStock, reorderLevel);

            txt_stockId.Text = "";
            txtStockname.Text = "";
            cmbStockType.SelectedIndex = -1;
            txtQuantity.Text = "";
            dtpStockDate.Value = DateTime.Now;
            dtpLastStock.Value = DateTime.Now;
            cmbReorderLevel.SelectedIndex = -1;
           


          


        }



        private void txt_stockId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Stock_Click(object sender, EventArgs e)
        {
            string stockId = txt_stockId.Text;

            // Create an instance of the CMinimumStock controller class
            controller.CStock minimumStockController = new controller.CStock();
            DataTable stockDetails = minimumStockController.getStockDetails(stockId);

            if (stockDetails.Rows.Count > 0)
            {
                DataRow row = stockDetails.Rows[0];

                // Update the fields with the retrieved data
                txtStockname.Text = row["stockName"].ToString();

                // Assuming cmbStockType has items matching the stock types in your database
                cmbStockType.SelectedItem = row["stockType"].ToString();

                txtQuantity.Text = row["stockQuantity"].ToString();
                dtpStockDate.Value = Convert.ToDateTime(row["stockDate"]);
                dtpLastStock.Value = Convert.ToDateTime(row["lastUpdatedDate"]);

                // Assuming cmbReorderLevel has items matching the reorder levels in your database
                cmbReorderLevel.SelectedItem = row["reorderLevel"].ToString();
            }
            else
            {
                MessageBox.Show("No stock found with the provided Stock ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear or reset the fields if no stock is found
                txtStockname.Text = "";
                cmbStockType.SelectedIndex = -1; // Reset the combobox
                txtQuantity.Text = "";
                dtpStockDate.Value = DateTime.Now; // Or a default date
                dtpLastStock.Value = DateTime.Now; // Or a default date
                cmbReorderLevel.SelectedIndex = -1; // Reset the combobox
            }

        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            AdminDashboard goBack = new AdminDashboard();
            goBack.Show();
            this.Hide();
        }
    }
}
