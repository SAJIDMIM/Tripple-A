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
    public partial class monitorStock : Form
    {
        public monitorStock()
        {
            InitializeComponent();
        }
        private string originalQuantityValue;
        private string originalReorderValue;
        private DateTime originalDateValue;
        private string originalCostValue;
        private void monitorStock_Load(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Product_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void picGoBackStr_Click(object sender, EventArgs e)
        {
            StorekeeperDashboard back = new StorekeeperDashboard();
            back.Show();
            this.Hide();
        }

        private void btn_Add_Stock_Click(object sender, EventArgs e)
        {
            string stockId = txt_Stock_Id.Text;
            string stockName = txt_Stock_Name.Text;
            string stockType = cmbStockType.SelectedItem.ToString();
            int stockQuantity = int.Parse(txt_Stock_Qty.Text);
            string stockWeight = cmbStockWeight.SelectedItem.ToString();
            string Location = txtLocation.Text;
            double cost = double.Parse(txt_Stock_Cost.Text);
            string SupplierName = txt_Supplier_Name.Text;
            int reorderLevel = int.Parse(cmbReorderLevel.SelectedItem.ToString());
            DateTime stockDate = dtp_Stock_Date.Value;
            DateTime lastDateUpdated = dtp_Last_Date.Value;
            string stockDescription = txt_Stock_Description.Text;

            CStock newStock = new CStock();
            newStock.addStock(stockId, stockName, stockType, stockQuantity, stockWeight, Location, cost, SupplierName, reorderLevel, stockDate, lastDateUpdated, stockDescription);

            // Clear or reset the fields if no stock is found
            txt_Stock_Name.Text = "";
            cmbStockType.SelectedIndex = -1; // Reset the combobox
            txt_Stock_Qty.Text = "";
            cmbStockWeight.SelectedIndex = -1; // Reset the combobox
            txtLocation.Text = "";
            txt_Stock_Cost.Text = "";
            txt_Supplier_Name.Text = "";
            cmbReorderLevel.SelectedIndex = -1; // Reset the combobox
            dtp_Stock_Date.Value = DateTime.Now; // Or a default date
            dtp_Last_Date.Value = DateTime.Now; // Or a default date
            txt_Stock_Description.Text = "";

        }

        private void btn_Update_Stock_Click(object sender, EventArgs e)
        {
            string stockId = txt_Stock_Id.Text;
            string stockName = txt_Stock_Name.Text;
            string stockType = cmbStockType.SelectedItem.ToString();
            string stockWeight = cmbStockWeight.SelectedItem.ToString();
            string Location = txtLocation.Text;
            string SupplierName = txt_Supplier_Name.Text;
            DateTime stockDate = dtp_Stock_Date.Value;
            string stockDescription = txt_Stock_Description.Text;

            bool validationFailed = false;

            // Validate quantity field
            if (txt_Stock_Qty.Text != originalQuantityValue && !IsAdmin())
            {
                MessageBox.Show("You are not authorized to change the quantity level. This field is set by the admin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Stock_Qty.Text = originalQuantityValue; // restore the original value
                validationFailed = true;
            }
            else
            {
                int stockQuantity = int.Parse(txt_Stock_Qty.Text);
            }

            // Validate reorder level field
            if (cmbReorderLevel.SelectedItem.ToString() != originalReorderValue && !IsAdmin())
            {
                MessageBox.Show("You are not authorized to change the reorder level. This field is set by the admin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbReorderLevel.SelectedItem = originalReorderValue; // restore the original value
                validationFailed = true;
            }
            else
            {
                int reorderLevel = int.Parse(cmbReorderLevel.SelectedItem.ToString());
            }

            // Validate cost field
            if (txt_Stock_Cost.Text != originalCostValue && !IsAdmin())
            {
                MessageBox.Show("You are not authorized to change the cost. This field is set by the admin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Stock_Cost.Text = originalCostValue; // restore the original value
                validationFailed = true;
            }
            else
            {
                double cost = double.Parse(txt_Stock_Cost.Text);
            }

            // Validate last updated date field
            if (dtp_Last_Date.Value != originalDateValue && !IsAdmin())
            {
                MessageBox.Show("You are not authorized to change the stock updated date. This field is set by the admin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (originalDateValue >= dtp_Last_Date.MinDate && originalDateValue <= dtp_Last_Date.MaxDate)
                {
                    dtp_Last_Date.Value = originalDateValue;
                }
                else
                {
                    // Handle invalid date assignment, e.g., display an error message
                    MessageBox.Show("Invalid date assignment. Please select a date within the valid range.");
                }
                validationFailed = true;
            }
            else
            {
                DateTime lastDateUpdated = dtp_Last_Date.Value;
            }

            if (validationFailed)
            {
                return; // exit the method if any validation failures occurred
            }

            // Proceed with updating the stock
            CStock newStock = new CStock();
            newStock.updateStock(stockId, stockName, stockType, stockWeight, Location, SupplierName, stockDate, stockDescription);

            // Clear or reset the fields if no stock is found
            txt_Stock_Name.Text = "";
            cmbStockType.SelectedIndex = -1; // Reset the combobox
            txt_Stock_Qty.Text = "";
            cmbStockWeight.SelectedIndex = -1; // Reset the combobox
            txtLocation.Text = "";
            txt_Stock_Cost.Text = "";
            txt_Supplier_Name.Text = "";
            cmbReorderLevel.SelectedIndex = -1; // Reset the combobox
            dtp_Stock_Date.Value = DateTime.Now; // Or a default date
            dtp_Last_Date.Value = DateTime.Now; // Or a default date
            txt_Stock_Description.Text = "";

        }

        private void btn_Delete_Stock_Click(object sender, EventArgs e)
        {
            string stockId = txt_Stock_Id.Text;

            CStock deleteStock = new CStock();
            deleteStock.deleteStock(stockId);

            // Clear or reset the fields if no stock is found
            txt_Stock_Name.Text = "";
            cmbStockType.SelectedIndex = -1; // Reset the combobox
            txt_Stock_Qty.Text = "";
            cmbStockWeight.SelectedIndex = -1; // Reset the combobox
            txtLocation.Text = "";
            txt_Stock_Cost.Text = "";
            txt_Supplier_Name.Text = "";
            cmbReorderLevel.SelectedIndex = -1; // Reset the combobox
            dtp_Stock_Date.Value = DateTime.Now; // Or a default date
            dtp_Last_Date.Value = DateTime.Now; // Or a default date
            txt_Stock_Description.Text = "";


        }

        private void btn_Search_Stock_Click(object sender, EventArgs e)
        {
            string stockId = txt_Stock_Id.Text;

            CStock searchStock = new CStock();
            DataTable getDetails = searchStock.viewStock(stockId);

            if (getDetails.Rows.Count > 0)
            {
                DataRow row = getDetails.Rows[0];

                txt_Stock_Name.Text = row["stockName"].ToString();
                cmbStockType.SelectedItem = row["stockType"].ToString();
                txt_Stock_Qty.Text = row["stockQuantity"].ToString();
                cmbStockWeight.SelectedItem = row["stockWeight"].ToString();
                txtLocation.Text = row["Location"].ToString();
                txt_Stock_Cost.Text = row["cost"].ToString();
                txt_Supplier_Name.Text = row["SupplierName"].ToString();
                cmbReorderLevel.SelectedItem = row["reorderLevel"].ToString();
                dtp_Stock_Date.Value = Convert.ToDateTime(row["stockDate"]);
                dtp_Last_Date.Value = Convert.ToDateTime(row["lastUpdatedDate"]);
                txt_Stock_Description.Text = row["stockDescription"].ToString();

            }
            else
            {
                MessageBox.Show("No stock found with the provided ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear or reset the fields if no stock is found
                txt_Stock_Name.Text = "";
                cmbStockType.SelectedIndex = -1; // Reset the combobox
                txt_Stock_Qty.Text = "";
                cmbStockWeight.SelectedIndex = -1; // Reset the combobox
                txtLocation.Text = "";
                txt_Stock_Cost.Text = "";
                txt_Supplier_Name.Text = "";
                cmbReorderLevel.SelectedIndex = -1; // Reset the combobox
                dtp_Stock_Date.Value = DateTime.Now; // Or a default date
                dtp_Last_Date.Value = DateTime.Now; // Or a default date
                txt_Stock_Description.Text = "";

            }
        }

        private void txt_Stock_Qty_TextChanged(object sender, EventArgs e)
        {
           
        }
        private string username; // assume you have a method to get the current username

        private bool IsAdmin()
        {
            return username == "ordinaryAdmin"; // replace with the actual admin username
        }

        private void cmbReorderLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtp_Last_Date_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Stock_Cost_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
