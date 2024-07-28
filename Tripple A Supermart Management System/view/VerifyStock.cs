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
    public partial class VerifyStock : Form
    {
        public VerifyStock()
        {
            InitializeComponent();
        }

        private void AuditStock_Load(object sender, EventArgs e)
        {

        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {

            // Initialize variables for validation

         
            //point the variables and reading the values
            string stockId = txtStockId.Text;
            string description = txtStock_Description.Text;
            int Qty;
            if (!int.TryParse(txtQuantity.Text, out Qty))
            {
                MessageBox.Show("Quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string street = txtStreet.Text;
            string city = txtCity.Text;
            int postalCode;
            if(!int.TryParse(txtCode.Text,out postalCode))
            {
                MessageBox.Show("Postal Code must be an Integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime auditdate = dtpAuditDate.Value;
            DateTime lastAudit = dtpLastAuditDate.Value;
            string comment = txtComment.Text;
            // Validate input
            if (string.IsNullOrWhiteSpace(txtStockId.Text))
            {
                MessageBox.Show("Stock ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStock_Description.Text))
            {
                MessageBox.Show("Stock Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

    

            if (!int.TryParse(txtQuantity.Text, out Qty))
            {
                MessageBox.Show("Quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("Street is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Postal Code is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Comment is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate quantity
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate postal code
            if (!int.TryParse(txtCode.Text, out postalCode))
            {
                MessageBox.Show("Postal Code must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate audit date
            if (dtpAuditDate.Value > DateTime.Now)
            {
                MessageBox.Show("Audit Date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate last audit date
            if (dtpLastAuditDate.Value > DateTime.Now)
            {
                MessageBox.Show("Last Audit Date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate audit date is not later than last audit date
            if (dtpAuditDate.Value > dtpLastAuditDate.Value)
            {
                MessageBox.Show("Audit Date cannot be later than Last Audit Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the VerifyStock method
            CVerifyStock verifyStock = new CVerifyStock();
            verifyStock.VerifyStock(stockId, description, Qty, street, city, postalCode, dtpAuditDate.Value, dtpLastAuditDate.Value, comment);




           

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //clear all the fields
            txtStockId.Clear();
            txtStock_Description.Clear();
            txtQuantity.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtCode.Clear();
            dtpAuditDate.CustomFormat = "";
            dtpLastAuditDate.CustomFormat = "";
            txtComment.Clear();

        }

        private void picBackDas_Click(object sender, EventArgs e)
        {
            //this goes back to director dashboard
            DirectorAdminDashboard directorAdminDashboard = new DirectorAdminDashboard();
            directorAdminDashboard.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   

}
