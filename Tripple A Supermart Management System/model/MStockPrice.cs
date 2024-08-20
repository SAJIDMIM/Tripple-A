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
    class MStockPrice
    {
        private string stockId;
        private double cost;

       
        private DateTime lastUpdatedStock;
       
        public void setStockPrice(string stockId,double cost,DateTime lastUpdatedDate)
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

        public DataTable getStockDetails(string stockId)
        {
            DataTable stockDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT stockName,stockType,cost,stockDate,lastUpdatedDate,reorderLevel FROM Stock WHERE stockId = @stockId";

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

