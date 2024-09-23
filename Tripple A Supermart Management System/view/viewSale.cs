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
    public partial class viewSale : Form
    {
        public viewSale()
        {
            InitializeComponent();
        }

        private void btn_Search_Sale_Click(object sender, EventArgs e)
        {

            string saleId = txtSaleId.Text;

            // Check if sale ID is empty or null
            if (string.IsNullOrWhiteSpace(saleId))
            {
                MessageBox.Show("Please enter a valid Sale ID", "Invalid Sale ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CSale viewSale = new CSale();

            // Check if sale ID exists before viewing sale details
            if (saleId == null)
            {
                MessageBox.Show("Sale ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable saleDetails = viewSale.viewSale(saleId);

            if (saleDetails == null || saleDetails.Rows.Count == 0)
            {
                MessageBox.Show("No sale details found for the given Sale ID", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvSaleDetails.DataSource = saleDetails;
        }

        private void picGoBackSaleDash_Click(object sender, EventArgs e)
        {
            SaleDash back = new SaleDash();
            back.Show();
            this.Hide();
        }
    }
}
