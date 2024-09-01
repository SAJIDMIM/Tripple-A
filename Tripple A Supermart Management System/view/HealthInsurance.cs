using System;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class HealthInsurance : Form
    {
        public HealthInsurance()
        {
            InitializeComponent();
            DisplayNextHealthId();
        }
        private void DisplayNextHealthId()
        {
            try
            {
                int nextHealthId = model.HealthInsurance.GetNextHealthId();
                txt_health_InsuranceId.Text = nextHealthId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Health_Click(object sender, EventArgs e)
        {
            int HealthInsuranceID = Convert.ToInt32(txt_health_InsuranceId.Text);
            string employeeId = txtEmpId.Text;
            string firstName = txt_First_Name.Text;
            string lastName = txt_Last_Name.Text;
            string Type = cmbHealthType.SelectedItem.ToString();
            string Description = txtDescription.Text;
            DateTime EffectiveDate = dtp_Effective_Date.Value;
            DateTime ExpiryDate = dtp_Expiry_Date.Value;
            double PremiumAmount = Convert.ToDouble(txt_Premium_Amount.Text);
            double DeductibleAmount = Convert.ToDouble(txt_Deductable_Amount.Text);
            string RenewalOption = cmbRenewalType.SelectedItem.ToString();

            CHealthInsurance newHealth = new CHealthInsurance();
            newHealth.AddHealthInsurance(HealthInsuranceID, employeeId, firstName, lastName, Type, Description, EffectiveDate, ExpiryDate, PremiumAmount, DeductibleAmount, RenewalOption);


        }

        private void btn_Search_Employee_Details_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmpId.Text;

            CHealthInsurance viewEmployee = new CHealthInsurance();
            viewEmployee.getEmployeeDetails(employeeId);
        }

        private void pic_Hr_Dashboard_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
