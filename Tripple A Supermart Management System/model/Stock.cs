using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class Stock
    {
        private string stockId;
        private string stockName;
        private string stockType;
        
        private int quantity;
        private string Location;
        private string supplierName;
        private string stockWeight;
        private DateTime lastUpdatedStock;
        private int reorderLevel;
        private double cost;

        public void setMinimumStock(string stockId, int quantity, DateTime lastUpdatedStock, int reorderLevel)
        {
            this.stockId = stockId;
            this.quantity = quantity;

            this.lastUpdatedStock = lastUpdatedStock;
            this.reorderLevel = reorderLevel;

            // Data Validation (Add more validation as needed)
            if (string.IsNullOrEmpty(stockId))
            {
                throw new ArgumentException("Stock ID cannot be empty.");
            }
            if (quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }
            if (reorderLevel < 0)
            {
                throw new ArgumentException("Reorder level cannot be negative.");
            }

            using (SqlConnection connection = MDBConnection.createConnection())
            {

                try
                {


                    connection.Open(); // Open the connection

                    // Update stock quantity and lastUpdatedDate
                    string updateQuery = "update Stock set stockQuantity = @stockQuantity,reorderLevel = @reorderLevel,lastUpdatedDate = @lastUpdatedDate where stockId = @stockId AND @stockQuantity < reorderLevel";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@stockId", stockId);
                        command.Parameters.AddWithValue("@stockQuantity", quantity);

                        command.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                        command.Parameters.AddWithValue("@lastUpdatedDate", DateTime.Now);



                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stocks have been updated successfully", "Updated Minimum Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid Stock update on Quantity.Please check on reorder level and maintain the quantity level", "Invalid Quantity Level Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        public DataTable getStockDetails(string stockId)
        {
            DataTable stockDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT stockName,stockType,stockQuantity,stockWeight,cost,stockDate,lastUpdatedDate,reorderLevel FROM Stock WHERE stockId = @stockId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@stockId", stockId);


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
                        Console.WriteLine("Error retrieving stock details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return stockDetails;
        }
        public void setStockPrice(string stockId, double cost, DateTime lastUpdatedDate)
        {
            this.stockId = stockId;
            this.cost = cost; // This line updates the cost field in your MStockPrice class
            this.lastUpdatedStock = lastUpdatedDate;

            using (SqlConnection connection = MDBConnection.createConnection())
            {

                try
                {
                    connection.Open(); // Open the connection

                    // Update stock quantity and lastUpdatedDate
                    string updateQuery = "update Stock set cost = @cost,lastUpdatedDate = @lastUpdatedDate where stockId = @stockId";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@stockId", stockId);
                        command.Parameters.AddWithValue("@cost", cost);
                        command.Parameters.AddWithValue("@lastUpdatedDate", DateTime.Now);
                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New stock price has been set successfully", "Updated Stock Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Does not changed.Error! please review it and retry to set a new price", "Invalid new stock price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

        }


        public DataTable getStock(string stockId)
        {
            DataTable stockDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT stockName,stockType,stockWeight,cost,stockDate,lastUpdatedDate,reorderLevel FROM Stock WHERE stockId = @stockId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@stockId", stockId);


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
                        Console.WriteLine("Error retrieving stock details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return stockDetails;
        }
        public DataTable getStockCost(string stockId)
        {
            DataTable stockDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT stockName,stockType,stockQuantity,cost,stockDate FROM Stock WHERE stockId = @stockId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@stockId", stockId);


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
                        Console.WriteLine("Error retrieving stock details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return stockDetails;
        }
        public void placeStockOrder(string stockId, string stockName, string stockType, int stockQuantity, string Location, double cost, DateTime stockDate, string supplierName)
        {
           
            // Construct the email body with the place stock order details.
            string emailBody = $"Place Stock Order Details:\n\n" +
                                $"Stock ID: {stockId}\n" +
                                $"Stock Name: {stockName}\n" +
                                $"Stock Type: {stockType}\n" +
                                $"Quantity: {stockQuantity}\n" +
                                $"Location: {Location}\n" +
                                $"Cost: {cost}\n" +
                                $"Stock Date: {stockDate}\n" +
                                $"Supplier Name: {supplierName}";

            if (string.IsNullOrEmpty(emailBody))
            {
                MessageBox.Show("Stock order has not been placed. Please check the details and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Stock order has been successfully placed", "Stock Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
