using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class BillingReminder
    {
        // Use properties to access and modify data
        private string ReminderId { get; set; }
        private DateTime Date { get; set; }
        private string Option { get; set; }
        private string Message { get; set; }
        private double dueAmount { get; set; }
        private DateTime NextDate { get; set; }
        private string status { get; set; }
        private string emailNotify { get; set; }

        public void sendBillingReminder(string ReminderId, DateTime Date, string Option, string Message, double dueAmount, DateTime NextDate, string Status, string emailNotify)
        {
            try
            {




                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO BillingReminder INSERT INTO BillingReminder (ReminderId, Date, Option, Message,dueAmount, NextDate, Status, emailNotify) VALUES (@ReminderId, @Date, @Option, @Message,@dueAmount @NextDate, @Status, @emailNotify)", con))
                    {

                        cmd.Parameters.AddWithValue("@ReminderId", this.ReminderId);
                        cmd.Parameters.AddWithValue("@Date", this.Date);
                        cmd.Parameters.AddWithValue("@Option", this.Option);
                        cmd.Parameters.AddWithValue("@Message", this.Message);
                        cmd.Parameters.AddWithValue("@dueAmount", this.dueAmount);
                        cmd.Parameters.AddWithValue("@NextDate", this.NextDate);
                        cmd.Parameters.AddWithValue("@Status", this.status);
                        cmd.Parameters.AddWithValue("@emailNotify", this.emailNotify);


                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Billing reminder has been sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SendBillingReminderToCustomer(emailNotify, "Please settle your payment on time to avoid late fees.", DateTime.Now.AddDays(7), "$100.00");


                        }
                        else
                        {
                            MessageBox.Show("Billing reminder has not been sent. An Error occurred", "Invalid Reminder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
        }
            public void SendBillingReminderToCustomer(string recipientEmail, string billingReminderMessage, DateTime nextPaymentDate, string amountDue)
            {
                string emailBody = $@"
    <html>
        <body>
            <h2>Billing Reminder: Payment Due Soon!</h2>
            <p>Dear Customer,</p>
            <p>This is a friendly reminder that your payment is due soon. Please find the details below:</p>
            <p>Next Payment Date: {nextPaymentDate.ToString("yyyy-MM-dd")}</p>
            <p>Amount Due: {amountDue}</p>
            <p>{billingReminderMessage}</p>
            <p>Please settle your payment on time to avoid any late fees. If you have already made the payment, please disregard this email.</p>
            <p>Thank you for your prompt attention to this matter.</p>
            <p>Best regards,</p>
            <p>Tripple A Supermart</p>
        </body>
    </html>
";
                try
                {
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential("mohamedsajid450@gmail.com", "pjpt pqak ldxd gukn");

                    MailMessage mailMessage = new MailMessage("mohamedsajid450@gmail.com", recipientEmail);
                    mailMessage.Subject = "Billing Reminder: Payment Due Soon!";
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = emailBody;

                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Billing reminder email sent successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while sending email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

