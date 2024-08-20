using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class MTransferItem
    {
        private string itemId { get; set; }
        private string itemName { get; set; }
        private string Description { get; set; }
        private int Quantity { get; set; }
        private string Category { get; set; }

        // Fixed sender email address
        private const string senderEmail = "mohamedsajid450@gmail.com";
        private const string senderPassword = "pjpt pqak ldxd gukn";



        public bool transferItem(string itemId, string itemName, string Description, int Quantity, string Category, string recipientEmail)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.Description = Description;
            this.Quantity = Quantity;
            this.Category = Category;

          

        // Construct the email body with the transfer details.
        string emailBody = $"Transfer Item Details:\n\n" +
                              $"Item ID: {itemId}\n" +
                              $"Item Name: {itemName}\n" +
                              $"Description: {Description}\n" +
                              $"Quantity: {Quantity}\n" +
                              $"Category: {Category}";

            // Send the email to multiple recipients.
            try
            {
                // Replace with your actual email server settings.
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(senderEmail, senderPassword);

                MailMessage mailMessage = new MailMessage(senderEmail,recipientEmail);
                mailMessage.Subject = "Transfer Items Details";
                mailMessage.Body = emailBody;

                smtpClient.Send(mailMessage);
                // Show a message box after successful transfer
                MessageBox.Show("Item has been successfully transferered", "Transfer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Transfer.Please check the details and retry it","Invalid Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // The transfer is successful, but data is not stored in the database.
            return true;
        }


    }

}
