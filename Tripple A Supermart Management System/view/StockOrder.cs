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
    public partial class StockOrder : Form
    {
        public StockOrder()
        {
            InitializeComponent();
        }

        private void btn_Place_Stock_Click(object sender, EventArgs e)
        {
            string stockId = txtStockId.Text;
            string stockName = txt_Stock_Name.Text;
            string stockType = cmbStockType.SelectedItem.ToString();
            int stockQuantity = int.Parse(txtQuantity.Text);
            string Location = txtLocation.Text;
            double cost = double.Parse(txtCost.Text);
            DateTime stockDate = dtpDateStock.Value;
            string supplierName = txtSupplierName.Text;

            if (string.IsNullOrWhiteSpace(stockId) ||
        string.IsNullOrWhiteSpace(stockName) ||
        string.IsNullOrWhiteSpace(stockType) ||
        string.IsNullOrWhiteSpace(txtQuantity.Text) ||
        string.IsNullOrWhiteSpace(txtLocation.Text) ||
        string.IsNullOrWhiteSpace(txtCost.Text) ||
        string.IsNullOrWhiteSpace(supplierName))
            {
                MessageBox.Show("Please fill in all required fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            CStock placeStock = new CStock();
            placeStock.placeStockOrder(stockId, stockName, stockType, stockQuantity, Location, cost, stockDate, supplierName);

        }

        private void btn_Search_Stock_Cost_Click(object sender, EventArgs e)
        {
            string stockId = txtStockId.Text;

            CStock createCost = new CStock();
            DataTable stockDetails = createCost.getStockCost(stockId);

            if (stockDetails.Rows.Count > 0)
            {
                DataRow row = stockDetails.Rows[0];

                if (double.TryParse(row["cost"].ToString(), out double cost))
                {
                    txtCost.Text = cost.ToString();
                }
                else
                {
                    // Handle the case where the value in row["cost"] is not a valid double
                    txtCost.Text = "Invalid cost";
                }

                // Display stock name
                txt_Stock_Name.Text = row["stockName"].ToString();

                // Display stock type
                cmbStockType.SelectedItem = row["stockType"].ToString();
                // Display stock date
                if (row["stockDate"] != DBNull.Value)
                {
                    DateTime stockDate = Convert.ToDateTime(row["stockDate"]);
                    dtpDateStock.Value = stockDate;
                }
                else
                {
                    dtpDateStock.Value = DateTime.MinValue;
                }
                txtQuantity.Text = row["stockQuantity"].ToString();
            }
            else
            {
                MessageBox.Show("No stock found with the provided Stock ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCost.Text = "";
                txt_Stock_Name.Text = "";
                cmbStockType.SelectedItem = null;
                txtQuantity.Text = "";

            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtCost.Text))
            {
                int quantity;
                double cost;

                if (int.TryParse(txtQuantity.Text, out quantity) && double.TryParse(txtCost.Text, out cost))
                {
                    double totalCost = quantity * cost;
                    txtCost.Text = totalCost.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid quantity and cost.", "Invalid Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You cannot change quantity levels", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cancel_Stock_Order_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the stock order?", "Cancel Stock Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cancel the stock order
                // Add your code here to cancel the order
                Application.Exit();
            }
            else
            {
                // Do nothing if the user clicks No
            }
        }

        private void picGoBackStr_Click(object sender, EventArgs e)
        {
            StorekeeperDashboard back = new StorekeeperDashboard();
            back.Show();
            this.Hide();
        }

        private void btn_Make_Payment_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}

