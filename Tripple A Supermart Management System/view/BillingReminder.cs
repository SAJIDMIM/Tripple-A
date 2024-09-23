using System;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class BillingReminder : Form
    {

        public BillingReminder()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Set_Minimum_Stock_Click(object sender, EventArgs e)
        {
            string ReminderId = txt_reminder_Id.Text;
            DateTime Date = dtp_Date.Value;
            string Option = cmbOption.SelectedItem.ToString();
            string Message = txtMessage.Text;
            double dueAmount = double.Parse(txtdueAmount.Text);
            DateTime NextDate = dtp_Next_Date.Value;
            string status = cmbStatus.SelectedItem.ToString();
            string emailNotify = txt_Email_Notify.Text;
            if (string.IsNullOrWhiteSpace(ReminderId) || Option == null || string.IsNullOrWhiteSpace(Message) || string.IsNullOrWhiteSpace(txtdueAmount.Text) || status == null || string.IsNullOrWhiteSpace(emailNotify))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            if (!double.TryParse(txtdueAmount.Text, out dueAmount))
            {
                MessageBox.Show("Invalid due amount. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CBillingReminder sendBill = new CBillingReminder();
            sendBill.sendBillingReminder(ReminderId, Date, Option, Message, dueAmount, NextDate, status, emailNotify);
    }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you want to close this?", "Bill Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(msg == DialogResult.Yes)
            {
                this.Close();
            }
           

        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin back = new AdminLogin();
            back.Show();
            this.Hide();
        }
    }
}
