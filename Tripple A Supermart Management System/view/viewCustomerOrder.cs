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
    public partial class viewCustomerOrder : Form
    {
        public viewCustomerOrder()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Search_Order_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;

            if (string.IsNullOrWhiteSpace(orderId))
            {
                MessageBox.Show("Please enter a valid Order Id to be processed", "Invalid Order Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CCustomerOrder viewOrder = new CCustomerOrder();

            DataTable orderDetails = viewOrder.viewOrder(orderId);

            if (orderDetails == null || orderDetails.Rows.Count == 0)
            {
                MessageBox.Show("Order ID not found", "Invalid Order Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvOrderDetails.DataSource = orderDetails;
            }
        }

        private void picGoBackSaleDash_Click(object sender, EventArgs e)
        {
            SaleDash back = new SaleDash();
            back.Show();
            this.Hide();
        }
    }
}
