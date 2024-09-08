using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class MarketingPromotion
    {

        // Use properties to access and modify data
        private string markPromotionId { get; set; }
        private string marketingPromotionName { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
        private string discount { get; set; }
        private string offer { get; set; }
        private string emailMarketing { get; set; }
        private string contentMarketing { get; set; }
        private string inStorePromotion { get; set; }
        private string condition { get; set; }

        public void addPromotionMarketing(string markPromotionId, string marketPromotionName, DateTime startDate, DateTime endDate, double discount, string offer, string emailMarketing, string contentMarketing, string inStoreMarketing, string condition)
        {

            try
            {
                double actualDiscount = discount;
                if (offer == "Buy 1 Get another Item 50% off" || offer == "Buy Items for 10,000 and get 5000 off")
                {
                    if (discount == 0)
                    {
                        MessageBox.Show("Discount is required for this offer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }



                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO MarketingPromotion (markPromotion_Id, markertPromotionName, startDate, endDate, discount,offer,emailMarketing,contentMarketing,inStorePromotion,condition) VALUES (@markPromotion_Id, @marketPromotionName, @startDate, @endDate, @discount, @offer, @emailMarketing, @contentMarketing, @inStorePromotion, @condition)", con))
                    {
                        cmd.Parameters.AddWithValue("@markPromotion_Id", markPromotionId);
                        cmd.Parameters.AddWithValue("@marketPromotionName", marketPromotionName);
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@offer", offer);
                        cmd.Parameters.AddWithValue("@emailMarketing", emailMarketing);
                        cmd.Parameters.AddWithValue("@contentMarketing", contentMarketing);
                        cmd.Parameters.AddWithValue("@inStorePromotion", inStoreMarketing);
                        cmd.Parameters.AddWithValue("@condition", condition);

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Marketing Promotion has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SendEmailToMultipleRecipients(emailMarketing, offer, startDate, endDate, discount, inStoreMarketing);


                        }
                        else
                        {
                            MessageBox.Show("Marketing Promotion details has not been saved.An Error occurred", "Invalid Promotion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
        }
        // Update Promotion Details
        public void updatePromotionMarketing(string markPromotionId, string marketingPromotionName, DateTime startDate, DateTime endDate, double discount, string offer, string emailMarketing, string contentMarketing, string inStoreMarketing, string condition)
        {
            try
            {

                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE MarketingPromotion SET markertPromotionName = @marketPromotionName, startDate = @startDate, endDate = @endDate, discount = @discount, offer = @offer, emailMarketing = @emailMarketing, contentMarketing = @contentMarketing, inStorePromotion = @inStorePromotion, condition = @condition WHERE markPromotion_Id = @markPromotionId", con))
                    {
                        cmd.Parameters.AddWithValue("@markPromotionId", markPromotionId);
                        cmd.Parameters.AddWithValue("@marketPromotionName", marketingPromotionName);
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@offer", offer);
                        cmd.Parameters.AddWithValue("@emailMarketing", emailMarketing);
                        cmd.Parameters.AddWithValue("@contentMarketing", contentMarketing);
                        cmd.Parameters.AddWithValue("@inStorePromotion", inStoreMarketing);
                        cmd.Parameters.AddWithValue("@condition", condition);

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Marketing Promotion has been updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Marketing Promotion details has not been updated.An Error occurred", "Invalid Promotion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
        }
        public void removePromotionMarketing(string markPromotion_Id)
        {
            // 1. Display a confirmation dialog.
            DialogResult result = MessageBox.Show($"Are you sure you want to delete promotion with ID {markPromotion_Id}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 2. Check the user's response.
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM MarketingPromotion WHERE markPromotion_Id = @markPromotionId", con))
                    {
                        cmd.Parameters.AddWithValue("@markPromotionId", markPromotion_Id.ToString()); // Convert to nvarchar

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Marketing Promotion has been deleted successfully", "Deleted Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Marketing Promotion details has not been deleted. An Error occurred", "Invalid Promotion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SendEmailToMultipleRecipients(string recipientEmail, string offer, DateTime startDate, DateTime endDate, double discount, string inStorePromotion)
        {
            string offerCode = GenerateOfferCode(offer);
            string emailBody = $@"
    <html>
        <body>
            <h2>Exclusive Promotion for You!</h2>
            <p>Dear Customer,</p>
            <p>We are excited to offer you an exclusive promotion for our latest products!</p>
            <p>From {startDate.ToString("yyyy-MM-dd")} to {endDate.ToString("yyyy-MM-dd")}, enjoy {(discount > 0 ? discount.ToString() + "%" : "this amazing offer")} on {offer} at {inStorePromotion}. Use code <b>{offerCode}</b> to redeem your offer.</p>
            <p>Don't miss out on this amazing opportunity to save big! Visit us today and experience the best deals in town.</p>
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
                mailMessage.Subject = "Exclusive Promotion for You!";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = emailBody;

                smtpClient.Send(mailMessage);
                MessageBox.Show("Email sent successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateOfferCode(string offerName)
        {
            Random random = new Random();
            string codePrefix = "";
            switch (offerName)
            {
                case "Buy 1 Get 1 Free":
                    codePrefix = "B1G1F";
                    break;
                case "Buy 1 Get another Item 50% off":
                    codePrefix = "50OFF";
                    break;
                case "Buy Items for 10,000 and get 5000 off":
                    codePrefix = "B2G3F";
                    break;
                // Add more cases for other offers
                default:
                    codePrefix = "GENERIC";
                    break;
            }

            string codeSuffix = random.Next(1000, 9999).ToString();
            return codePrefix + codeSuffix;
        }

        public DataTable viewMarketingPromotion(string markPromotion_Id)
        {
            DataTable stockDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM MarketingPromotion WHERE markPromotion_Id = @markPromotion_Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@markPromotion_Id", markPromotion_Id);


                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(stockDetails);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving MarketingPromotion details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return stockDetails;
        }
    }
}