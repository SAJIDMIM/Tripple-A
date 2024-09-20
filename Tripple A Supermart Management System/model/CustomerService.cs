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
    class CustomerService
    {

        public string mobile { get; private set; }
        public string customerName { get; private set; }
        public string  Type { get; private set; }
        public DateTime responseTime { get; private set; }
        public string feedback { get; private set; }
        
        public void sendCustomerService(string mobile,string customerName,string Type,DateTime responseTime,string feedback)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                string query_insert = "INSERT INTO CustomerService (mobile, customerName, Type, responseTime, feedback, mobile) VALUES (@mobile, @customerName, @Type, @responseTime, @feedback)";
                using (SqlCommand cmd = new SqlCommand(query_insert, con))
                {
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@customerName", customerName);
                    cmd.Parameters.AddWithValue("@Type", Type);
                    cmd.Parameters.AddWithValue("@responseTime", responseTime);
                    cmd.Parameters.AddWithValue("@feedback", feedback);
                    
                    con.Open();
                    int count =  cmd.ExecuteNonQuery();
                    if(count > 0)
                    {
                        MessageBox.Show("Successfully assign a service with customer","Success Service",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid or an error occurred during the process.Please try again some time", "Success Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        public DataTable getCustomerDetails(string mobile)
        {
            DataTable customerDetails = new DataTable();
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT customerName FROM Customer WHERE mobile = @mobile";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mobile",mobile);


                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(customerDetails);
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

            return customerDetails;
        }
        // Method to get the next retirement ID
        public static int GetNextCustomerServiceId()
        {
            int nextServiceId = 1;
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT ISNULL(MAX(CustomerServiceId), 0) + 1 FROM CustomerService";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            nextServiceId = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextServiceId;
        }
    }
}

