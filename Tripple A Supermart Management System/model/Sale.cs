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
    class Sale
    {
        private int saleId;
        private DateTime saleStartDate;
        private DateTime saleEndDate;
        private double price;
        private double discount;


        public DataTable analyzeSale()
        {

            DataTable saleDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Sale"; // Modify the query to fetch all sales

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(saleDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving sale details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return saleDetails; // Return the DataTable with sale details
        }
       

        public void promoteSale(int saleId, DateTime saleStartDate, DateTime saleEndDate, double price, double discount)
        {
            // Validate Sale ID
            if (saleId <= 0)
            {
                MessageBox.Show("Invalid Sale ID. Please enter a valid Sale ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Sale Start Date (cannot be in the past)
            if (saleStartDate < DateTime.Now)
            {
                MessageBox.Show("Sale start date cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Sale End Date (must be after start date)
            if (saleEndDate <= saleStartDate)
            {
                MessageBox.Show("Sale end date must be after the start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Price (must be positive)
            if (price <= 0)
            {
                MessageBox.Show("Price must be a positive value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Discount (must be between 0 and 100)
            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("Discount must be a percentage between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                // Check if at least one field has changed
                bool hasChanges = saleStartDate != this.saleStartDate ||
                                 saleEndDate != this.saleEndDate ||
                                 price != this.price ||
                                 discount != this.discount;

                // Only update if there are changes
                if (hasChanges)
                {
                    using (SqlConnection con = MDBConnection.createConnection())
                    {
                        string query = "UPDATE Sale SET saleStartDate = @saleStartDate, saleEndDate = @saleEndDate, price = @price, discount = @discount WHERE saleId = @saleId";

                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            // Add parameters
                            command.Parameters.AddWithValue("@saleId", saleId);  // Pass the saleId parameter
                            command.Parameters.AddWithValue("@saleStartDate", saleStartDate);
                            command.Parameters.AddWithValue("@saleEndDate", saleEndDate);
                            command.Parameters.AddWithValue("@price", price);
                            command.Parameters.AddWithValue("@discount", discount);

                            con.Open();
                            int count = command.ExecuteNonQuery();
                            if(count > 0)
                            {
                                MessageBox.Show("Successfully Predicted the Sale","Promote Sale",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sale was not Predicted yet.Try some other time", "Promote Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }




                        }
                        
                    }
                  
                }
            }

        }
    

        public DataTable getSaleDetails(int saleId)
        {
            DataTable saleDetails = new DataTable();
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT productId,productName, saleStartDate,saleEndDate,price,discount FROM Sale WHERE saleId = @saleId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@saleId", saleId);

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(saleDetails);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving sale details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return saleDetails;
        }
    }
}
