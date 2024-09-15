using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class Stock
    {
        // Use properties to access and modify data
        private string stockId { get; set; }
        private string stockName { get; set; }
        private string stockType { get; set; }
        private int stockQuantity { get; set; }
        private string stockWeight { get; set; }
        private string Location { get; set; }
        private double cost { get; set; }
        private string SupplierName { get; set; }
        private int reorderLevel { get; set; }
        private DateTime stockDate { get; set; }
        private DateTime lastDateUpdated { get; set; }
        private string stockDescription { get; set; }
        public void setMinimumStock(string stockId, int quantity, DateTime lastUpdatedStock, int reorderLevel)
        {
            this.stockId = stockId;
            this.stockQuantity = quantity;

            this.lastDateUpdated = lastUpdatedStock;
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

            if (quantity > reorderLevel)
            {
                MessageBox.Show("Quantity cannot be greater than the reorder level.Please insert a number below reorder level in order to be set stock level", "Invalid Set Stock ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                try
                {
                    connection.Open(); // Open the connection

                    // Update stock quantity and lastUpdatedDate
                    string updateQuery = "update Stock set stockQuantity = @stockQuantity, reorderLevel = @reorderLevel, lastUpdatedDate = @lastUpdatedDate where stockId = @stockId";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@stockId", stockId);
                        command.Parameters.AddWithValue("@stockQuantity", quantity);

                        command.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                        command.Parameters.AddWithValue("@lastUpdatedDate", DateTime.Now);

                        // Execute the update command
                        int count = command.ExecuteNonQuery();

                        if (count > 0)
                        {
                            MessageBox.Show("Stocks have been updated successfully", "Updated Minimum Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Reorder level is less than the quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            this.lastDateUpdated = lastUpdatedDate;

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
                MessageBox.Show("Payment unsuccessful! Stock order has not been placed. Please check the details and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Payment successful! Your stock order has been placed.", "Stock Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void addStock(string stockId, string stockName, string stockType, int stockQuantity,string stockWeight, string location, double cost, string supplierName, int reorderLevel, DateTime stockDate, DateTime lastUpdatedDate, string stockDescription)
        {
            try
            {
                this.stockId = stockId;
                this.stockName = stockName;
                this.stockType = stockType;
                this.stockQuantity = stockQuantity;
                this.stockWeight = stockWeight;
                this.Location = location;
                this.cost = cost;
                this.SupplierName = supplierName;
                this.reorderLevel = reorderLevel;
                this.stockDate = stockDate;
                this.lastDateUpdated = lastUpdatedDate;
                this.stockDescription = stockDescription;

                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Stock (stockId, stockName, stockType, stockQuantity, stockWeight, location, cost, supplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription) VALUES (@stockId, @stockName, @stockType, @stockQuantity, @stockWeight, @location, @cost, @supplierName, @reorderLevel, @stockDate, @lastUpdatedDate, @stockDescription)", con))
                    {
                        cmd.Parameters.AddWithValue("@stockId", this.stockId);
                        cmd.Parameters.AddWithValue("@stockName", this.stockName);
                        cmd.Parameters.AddWithValue("@stockType", this.stockType);
                        cmd.Parameters.AddWithValue("@stockQuantity", this.stockQuantity);
                        cmd.Parameters.AddWithValue("@stockWeight", this.stockWeight);
                        cmd.Parameters.AddWithValue("@location", this.Location);
                        cmd.Parameters.AddWithValue("@cost", this.cost);
                        cmd.Parameters.AddWithValue("@supplierName", this.SupplierName);
                        cmd.Parameters.AddWithValue("@reorderLevel", this.reorderLevel);
                        cmd.Parameters.AddWithValue("@stockDate", this.stockDate);
                        cmd.Parameters.AddWithValue("@lastUpdatedDate", this.lastDateUpdated);
                        cmd.Parameters.AddWithValue("@stockDescription", this.stockDescription);

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Stock has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Stock details has not been saved. An Error occurred", "Invalid Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        public void updateStock(string stockId, string stockName, string stockType,string stockWeight, string location,string supplierName,DateTime stockDate,string stockDescription)
        {
            try
            {
                this.stockId = stockId;
                this.stockName = stockName;
                this.stockType = stockType;
               
                this.stockWeight = stockWeight;
                this.Location = location;
                
                this.SupplierName = supplierName;
                
                this.stockDate = stockDate;
               
                this.stockDescription = stockDescription;

                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Stock SET stockName = @stockName, stockType = @stockType,stockWeight = @stockWeight, location = @location,  supplierName = @supplierName, stockDate = @stockDate, stockDescription = @stockDescription WHERE stockId = @stockId", con))
                    {
                        cmd.Parameters.AddWithValue("@stockId", this.stockId);
                        cmd.Parameters.AddWithValue("@stockName", this.stockName);
                        cmd.Parameters.AddWithValue("@stockType", this.stockType);
                        
                        cmd.Parameters.AddWithValue("@stockWeight", this.stockWeight);
                        cmd.Parameters.AddWithValue("@location", this.Location);
                      
                        cmd.Parameters.AddWithValue("@supplierName", this.SupplierName);
                        cmd.Parameters.AddWithValue("@stockDate", this.stockDate);
                       
                        cmd.Parameters.AddWithValue("@stockDescription", this.stockDescription);

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Stock has been updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Stock details has not been updated. An Error occurred", "Invalid Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        public void deleteStock(string stockId)
        {
            // 1. Display a confirmation dialog.
            DialogResult result = MessageBox.Show($"Are you sure you want to delete stock with ID {stockId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 2. Check the user's response.
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Stock WHERE stockId = @stockId", con))
                    {
                        cmd.Parameters.AddWithValue("@stockId", stockId.ToString()); // Convert to nvarchar

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Stock has been deleted successfully", "Deleted Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Stock details has not been deleted. An Error occurred", "Invalid Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable viewStock(string stockId)
        {
            DataTable stockDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Stock WHERE stockId = @stockId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@stockId",stockId);


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
                        MessageBox.Show("Error retrieving Stock details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
