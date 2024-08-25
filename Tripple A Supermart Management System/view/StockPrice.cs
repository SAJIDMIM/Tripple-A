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
    public partial class StockPrice : Form
    {
        public StockPrice()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Stock_Click(object sender, EventArgs e)
        {
            string stockId = txt_stockId.Text;

            CStock createCost = new CStock();
            DataTable stockDetails = createCost.getStockDetails(stockId);

            if (stockDetails.Rows.Count > 0)
            {
                DataRow row = stockDetails.Rows[0];

                // Update the fields with the retrieved data
                txtStockname.Text = row["stockName"].ToString();


                // Assuming cmbStockType has items matching the stock types in your database
                cmbStockType.SelectedItem = row["stockType"].ToString();

                if (double.TryParse(row["cost"].ToString(), out double cost))
                {
                    txtCost.Text = cost.ToString();
                }
                else
                {
                    // Handle the case where the value in row["cost"] is not a valid double
                    txtCost.Text = "Invalid cost";
                }
                dtpDateEdited.Value = Convert.ToDateTime(row["stockDate"]);
                dtpLastUpdated.Value = Convert.ToDateTime(row["lastUpdatedDate"]);

            }
            else
            {
                MessageBox.Show("No stock found with the provided Stock ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear or reset the fields if no stock is found
                txtStockname.Text = "";
                cmbStockType.SelectedIndex = -1; // Reset the combobox
                txtCost.Text = "";
                dtpDateEdited.Value = DateTime.Now; // Or a default date
                dtpLastUpdated.Value = DateTime.Now; // Or a default date
               
            }
        }

        private void btn_Set_Stock_Price_Click(object sender, EventArgs e)
        {
            string stockId = txt_stockId.Text;
            double cost = Convert.ToDouble(txtCost.Text); // Assuming txtCost is the TextBox control where the user enters the cost
            DateTime lastUpdatedStock = dtpLastUpdated.Value;

            CStock setPrice = new CStock();
            setPrice.setStockPrice(stockId,cost,lastUpdatedStock);
        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            AdminDashboard goBack = new AdminDashboard();
            goBack.Show();
            this.Hide();
        }
    }
}
