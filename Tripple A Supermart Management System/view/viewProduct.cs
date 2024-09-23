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
    public partial class viewProduct : Form
    {
        public viewProduct()
        {
            InitializeComponent();
        }

        private void picGoBackStr_Click(object sender, EventArgs e)
        {
            StorekeeperDashboard back = new StorekeeperDashboard();
            back.Show();
            this.Hide();
        }

        private void btn_Search_Product_Click(object sender, EventArgs e)
        {
            string productId = txt_Product_Id.Text;

            if (string.IsNullOrWhiteSpace(productId))
            {
                MessageBox.Show("Please enter a valid Product ID to be processed", "Invalid Product ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CProduct viewProduct = new CProduct();

            DataTable productDetails = viewProduct.viewProduct(productId);

            if (productDetails == null || productDetails.Rows.Count == 0)
            {
                MessageBox.Show("Product ID not found or unknown", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvProduct.DataSource = productDetails;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
