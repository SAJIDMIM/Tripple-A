using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;


namespace Tripple_A_Supermart_Management_System.model
{
    class Item
    {
        private string itemId;
        private string itemName;
        private string description;
        private string department;
        private int quantity;
        private double unitPrice;
        private double totalPrice;
        private string category;
        private DateTime manufactureDate;
        private DateTime expiryDate;
        private string manufacturer;

        public string ItemId { get { return itemId; } set { itemId = value; } }
        public string ItemName { get { return itemName; } set { itemName = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Department { get { return department; } set { department = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public double UnitPrice { get { return unitPrice; } set { unitPrice = value; } }
        public double TotalPrice { get { return totalPrice; } set { totalPrice = value; } }
        public string Category { get { return category; } set { category = value; } }
        public DateTime ManufactureDate { get { return manufactureDate; } set { manufactureDate = value; } }
        public DateTime ExpiryDate { get { return expiryDate; } set { expiryDate = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }

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

                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail);
                mailMessage.Subject = "Transfer Items Details";
                mailMessage.Body = emailBody;

                smtpClient.Send(mailMessage);
                // Show a message box after successful transfer
                MessageBox.Show("Item has been successfully transferered", "Transfer Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Transfer.Please check the details and retry it", "Invalid Transfer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // The transfer is successful, but data is not stored in the database.
            return true;
        }
        public DataTable viewItems(string itemId)
        {
            DataTable stockDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Item WHERE itemId = @itemId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@itemId", itemId);


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
                        MessageBox.Show("Error retrieving Item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return stockDetails;
        }


        public void addItem(string itemId, string itemName, string description, string department, int quantity, double unitPrice, double totalPrice, string category, DateTime manufactureDate, DateTime expiryDate, string manufacturer)
        {
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Item (itemId, itemName, Description, department, Quantity, unitPrice, totalPrice, Category, manufactureDate, expiryDate, manufacturer) VALUES (@ItemId, @ItemName, @Description, @Department, @Quantity, @UnitPrice, @TotalPrice, @Category, @ManufactureDate, @ExpiryDate, @Manufacturer)", connection);

                command.Parameters.AddWithValue("@ItemId", itemId);
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@ManufactureDate", manufactureDate);
                command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                command.Parameters.AddWithValue("@Manufacturer", manufacturer);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Item has been added successfully", "Item Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Item Details has not been saved. An error occurred", "Invalid Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void editItem(string itemId, string itemName, string description, string department, int quantity, double unitPrice, double totalPrice, string category, DateTime manufactureDate, DateTime expiryDate, string manufacturer)
        {
            ItemId = itemId;
            ItemName = itemName;
            Description = description;
            Department = department;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
            Category = category;
            ManufactureDate = manufactureDate;
            ExpiryDate = expiryDate;
            Manufacturer = manufacturer;

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE Item SET itemName = @ItemName, Description = @Description, department = @Department, Quantity = @Quantity, unitPrice = @UnitPrice, totalPrice = @TotalPrice, Category = @Category, manufactureDate = @ManufactureDate, expiryDate = @ExpiryDate, manufacturer = @Manufacturer WHERE itemId = @ItemId", connection);

                command.Parameters.AddWithValue("@ItemId", itemId);
                command.Parameters.AddWithValue("@ItemName", itemName);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@ManufactureDate", manufactureDate);
                command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                command.Parameters.AddWithValue("@Manufacturer", manufacturer);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Item has been updated successfully", "Item Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Item Details has not been updated. An error occurred", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void removeItem(string itemId)
        {
            ItemId = itemId;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = MDBConnection.createConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Item WHERE itemId = @ItemId", connection);

                    command.Parameters.AddWithValue("@ItemId", itemId);

                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Item has been deleted successfully", "Item Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Item Details has not been deleted. An error occurred", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Delete operation cancelled", "Delete Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable viewItem(string itemId)
        {
            DataTable productDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Item WHERE itemId = @ItemId", connection);

                command.Parameters.AddWithValue("@ItemId", itemId);

                SqlDataReader reader = command.ExecuteReader();

                productDetails.Load(reader);
            }

            return productDetails;
        }
    }


}

