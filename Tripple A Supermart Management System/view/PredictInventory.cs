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
    public partial class PredictInventory : Form
    {
        public PredictInventory()
        {
            InitializeComponent();
        }

        private void btn_Predict_Click(object sender, EventArgs e)
        {
            string predictInventory = txtPredictId.Text;
            string stockId = txtStockId.Text;
            int Qty;
            if (!int.TryParse(txtQty.Text, out Qty))
            {
                MessageBox.Show("Quantity must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sale = cmbSale.SelectedItem.ToString();
            string demandInventory = txtdemandInventory.Text;
            DateTime leadtime = dtpLeadTime.Value;
            string safetystock = cmbSafeStock.SelectedItem.ToString();
            double cost = Convert.ToDouble(txtCost.Text);
        }
    }
}
