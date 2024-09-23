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
    public partial class approvePurchaseOrder : Form
    {
        public approvePurchaseOrder()
        {
            InitializeComponent();
        }

        private void approvePurchaseOrder_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Approve_Order_Click(object sender, EventArgs e)
        {
            // Check if the order ID is empty
            if (string.IsNullOrWhiteSpace(txtOrderd.Text))
            {
                MessageBox.Show("Please enter a valid order ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string orderId = txtOrderd.Text;

            // Check if the approval status is selected
            if (cmbApproveStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select an approval status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string status = cmbApproveStatus.SelectedItem.ToString();

            // Check if the order ID is a valid integer
            if (!int.TryParse(orderId, out int orderIdValue))
            {
                MessageBox.Show("Invalid order ID. Please enter a valid integer value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CCustomerOrder approval = new CCustomerOrder();
            approval.approvePurchaseOrder(orderId, status);

            txtOrderd.Clear();
            // Check if the approval status is selected
            if (cmbApproveStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an approval status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Cancel_Order_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you really want to cancel this approval for given {orderId}","Invalid Approval",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(msg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void picGoBackJuniorManger_Click(object sender, EventArgs e)
        {
            juniorManagerDash back = new juniorManagerDash();
            back.Show();
            this.Hide();

        }
    }
}
