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
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class showSupplier : Form
    {
        public showSupplier()
        {
            InitializeComponent();
        }

        private void btn_Search_Supplier_Click(object sender, EventArgs e)
        {
            string supplierId = txtSupplierId.Text;
            CSupplier showSupplier = new CSupplier();

            // Assuming viewSupplier returns a DataTable
            DataTable supplierDetails = showSupplier.viewSupplier(supplierId);

            if (supplierDetails.Rows.Count > 0)
            {
                // Set the DataGridView's data source to the DataTable if data is found
                dgvSupplier.DataSource = supplierDetails;
            }
            else
            {
                // Clear the DataGridView if no data is found
                dgvSupplier.DataSource = null;
                dgvSupplier.Rows.Clear();

                // Show error message
                MessageBox.Show("No supplier found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picGoBackGeneralManager_Click(object sender, EventArgs e)
        {
            GeneralDash back = new GeneralDash();
            back.Show();
            this.Hide();
        }
    }
}
