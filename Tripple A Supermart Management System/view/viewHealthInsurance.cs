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

            int HealthInsuranceId = Convert.ToInt32(txtHealthId.Text);


            if (HealthInsuranceId<= 0)
            {
                MessageBox.Show("Please enter valid Health Insurance Id to be process", "Invalid Insurance Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CHealthInsurance viewHealthDetails = new CHealthInsurance();
                DataTable healthDetails = viewHealthDetails.viewHealthInsurance(HealthInsuranceId);
                dgvHealth.DataSource = healthDetails;
            }
        }

        private void picGoBackHR_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
