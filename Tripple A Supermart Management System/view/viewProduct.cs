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

            if (productId == null)
            {
                MessageBox.Show("Please enter valid Product Id to be process", "Invalid Product Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CProduct viewProduct = new CProduct();


                DataTable productDetails = viewProduct.viewProduct(productId);



                dgvProduct.DataSource = productDetails;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
