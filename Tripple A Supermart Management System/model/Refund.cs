using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class Refund
    {
        private string refundId;
        private string mobile;
        private string customerName;
        private string productId;
        private string productName;
        private DateTime refundDate;
        private string type;
        private double refundAmount;
        private double originalPrice;
        private string reason;
        private string itemCondition;

        public string RefundId
        {
            get { return refundId; }
            set { refundId = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public DateTime RefundDate
        {
            get { return refundDate; }
            set { refundDate = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RefundAmount
        {
            get { return refundAmount; }
            set { refundAmount = value; }
        }

        public double OriginalPrice
        {
            get { return originalPrice; }
            set { originalPrice = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public string ItemCondition
        {
            get { return itemCondition; }
            set { itemCondition = value; }
        }

        public void processRefund(string refundId, string mobile, string customerName, string productId, string productName, DateTime refundDate, string type, double refundAmount, double originalPrice, string reason, string itemCondition)
        {
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(); // Start a transaction

                try
                {
                    // Insert refund record
                    SqlCommand command = new SqlCommand("INSERT INTO Refund (refundId, mobile, customerName, productId, productName, refundDate, Type, refundAmount, originalPrice, reason, itemCondition) VALUES (@RefundId, @Mobile, @CustomerName, @ProductId, @ProductName, @RefundDate, @Type, @RefundAmount, @OriginalPrice, @Reason, @ItemCondition)", connection, transaction);

                    command.Parameters.AddWithValue("@RefundId", refundId);
                    command.Parameters.AddWithValue("@Mobile", mobile);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@ProductId", productId);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@RefundDate", refundDate);
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@RefundAmount", refundAmount);
                    command.Parameters.AddWithValue("@OriginalPrice", originalPrice);
                    command.Parameters.AddWithValue("@Reason", reason);
                    command.Parameters.AddWithValue("@ItemCondition", itemCondition);

                    int count = command.ExecuteNonQuery();
                    MessageBox.Show($"Refund record insert attempt: {count} rows affected.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information); // Debug message

                    if (count > 0 && itemCondition.ToLower() == "undamaged") // Check if item is undamaged
                    {
                        // Update product table
                        SqlCommand updateProductCommand = new SqlCommand("UPDATE Product SET Quantity = Quantity + 1 WHERE productId = @ProductId", connection, transaction);
                        updateProductCommand.Parameters.AddWithValue("@ProductId", productId);

                        int updateCount = updateProductCommand.ExecuteNonQuery(); // Execute the update command
                        MessageBox.Show($"Product quantity update attempt: {updateCount} rows affected.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information); // Debug message

                        if (updateCount > 0)
                        {
                            transaction.Commit(); // Commit the transaction
                            MessageBox.Show("Refund has been added successfully, and Stock tables have been updated.", "Refund Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            transaction.Rollback(); // Rollback if update fails
                            MessageBox.Show("Refund not added. Product quantity update failed.", "Invalid Refund", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        transaction.Rollback(); // Rollback if the refund was not successful or the item is damaged
                        MessageBox.Show("Refund not added. Product must be undamaged.", "Invalid Refund", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Rollback on exception
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public DataTable getProduct(string productId)
        {
            DataTable productDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT productName,Quantity FROM Product WHERE productId = @productId", connection);

                command.Parameters.AddWithValue("@productId", productId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(productDetails);
            }

            return productDetails;
        }



        public DataTable viewCustomer(string mobile)
        {
            DataTable customerDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT customerName FROM Customer WHERE mobile = @mobile", connection);

                command.Parameters.AddWithValue("@mobile", mobile);

                SqlDataReader reader = command.ExecuteReader();

                customerDetails.Load(reader);
            }

            return customerDetails;
        }
    }
}

