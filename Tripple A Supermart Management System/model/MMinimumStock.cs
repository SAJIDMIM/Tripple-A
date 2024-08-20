using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class MMinimumStock
    {
        private string stockId;
        private int quantity;
        private DateTime lastUpdatedStock;
        private int reorderLevel;
        public void setMinimumStock(string stockId, int quantity,DateTime lastUpdatedStock, int reorderLevel)
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
                            MessageBox.Show("Stocks have not been updated successfully", "Invalid minimum stock update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
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
                string query = "SELECT stockName,stockType,stockQuantity,stockDate,lastUpdatedDate,reorderLevel FROM Stock WHERE stockId = @stockId";

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

    }
}

