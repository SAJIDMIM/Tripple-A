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
    public partial class viewHealthInsurance : Form
    {
        public viewHealthInsurance()
        {
            InitializeComponent();
        }

        private void btn_Search_Health_Click(object sender, EventArgs e)
        {

            int healthInsuranceId;

            // Check if the health insurance ID is a valid integer
            if (!int.TryParse(txtHealthId.Text, out healthInsuranceId))
            {
                MessageBox.Show("Please enter a valid health insurance ID.", "Invalid Insurance Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (healthInsuranceId <= 0)
            {
                MessageBox.Show("Please enter a valid health insurance ID to be processed", "Invalid Insurance Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CHealthInsurance viewHealthDetails = new CHealthInsurance();
            DataTable healthDetails = viewHealthDetails.viewHealthInsurance(healthInsuranceId);

            if (healthDetails == null || healthDetails.Rows.Count == 0)
            {
                MessageBox.Show("Health insurance ID not found. Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvHealth.DataSource = healthDetails;
        }
    

        private void picGoBackHR_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
