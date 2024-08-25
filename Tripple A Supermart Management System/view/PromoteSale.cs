using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class PromoteSale : Form
    {
        private object dt;
        private DataTable saleDetails; // Store the sale details for comparison
        public PromoteSale()
        {

            InitializeComponent();
        }

        private void btn_Search_Sale_Click(object sender, EventArgs e)
        {

            int saleId = Convert.ToInt32(txt_saleId.Text);
            controller.CSale salesDetails = new controller.CSale();

            // Fetch sale details
            DataTable dt = salesDetails.getSaleDetails(saleId);

            if (dt.Rows.Count > 0)
            {
                // Populate the form fields with the sale data
                txtProdId.Text = dt.Rows[0]["productId"].ToString();
                txtProdName.Text = dt.Rows[0]["productName"].ToString();
                dtpStartSale.Value = Convert.ToDateTime(dt.Rows[0]["saleStartDate"]);
                dtpSaleEndDate.Value = Convert.ToDateTime(dt.Rows[0]["saleEndDate"]);
                txtPrice.Text = dt.Rows[0]["price"].ToString();
                txtDiscount.Text = dt.Rows[0]["discount"].ToString();
            }
            else
            {
                MessageBox.Show("No sale id was found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btn_Promote_Sale_Click(object sender, EventArgs e)
        {

          
            
                int saleId = Convert.ToInt32(txt_saleId.Text);
                string productId = txtProdId.Text;
                string productName = txtProdName.Text;
                DateTime saleStartDate = dtpStartSale.Value;
                DateTime saleEndDate = dtpSaleEndDate.Value;
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);



                // Proceed with promoting the sale (no need for the if condition now)
                controller.CSale promoteSale = new controller.CSale();
                promoteSale.promoteSale(saleId, dtpStartSale.Value, dtpSaleEndDate.Value, price, discount);
                ClearFormFields();

           







        }


        // Function to clear the form fields
        private void ClearFormFields()
        {
            txt_saleId.Text = "";
            txtProdId.Text = "";
            txtProdName.Text = "";
            dtpStartSale.Value = DateTime.Now;
            dtpSaleEndDate.Value = DateTime.Now;
            txtPrice.Text = "";
            txtDiscount.Text = "";
        }

        private void dtpStartSale_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpSaleEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
  