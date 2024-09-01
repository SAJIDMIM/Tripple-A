using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class RetirementPlan
    {
        // Private fields
        private string retirementId;
        private string employeeId;
        private string employeeFirstName;
        private string employeeLastName;
        private string position;
        private string retireType;
        private DateTime dateJoined;
        private DateTime expectedDate;
        private string contribution;

        // Public properties
        public string RetirementId { get => retirementId; set => retirementId = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeFirstName { get => employeeFirstName; set => employeeFirstName = value; }
        public string EmployeeLastName { get => employeeLastName; set => employeeLastName = value; }
        public string Position { get => position; set => position = value; }
        public string RetireType { get => retireType; set => retireType = value; }
        public DateTime DateJoined { get => dateJoined; set => dateJoined = value; }
        public DateTime ExpectedDate { get => expectedDate; set => expectedDate = value; }
        public string Contribution { get => contribution; set => contribution = value; }

        // Method to retire an employee
        public void addretireEmployee()
        {
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "INSERT INTO RetirementPlan (retirementId, employeeId, firstName, lastName, position, retireType, DateJoined, expectedDate, contribution) " +
                                   "VALUES (@retirementId, @employeeId, @employeeFirstName, @employeeLastName, @position, @retireType, @DateJoined, @expectedDate, @contribution)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@retirementId", retirementId);
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        cmd.Parameters.AddWithValue("@employeeFirstName", employeeFirstName);
                        cmd.Parameters.AddWithValue("@employeeLastName", employeeLastName);
                        cmd.Parameters.AddWithValue("@position", position);
                        cmd.Parameters.AddWithValue("@retireType", retireType);
                        cmd.Parameters.AddWithValue("@DateJoined", dateJoined);
                        cmd.Parameters.AddWithValue("@expectedDate", expectedDate);
                        cmd.Parameters.AddWithValue("@contribution", contribution);

                        int count = cmd.ExecuteNonQuery();

                        if (count > 0)
                        {
                            MessageBox.Show("Retirement has been added", "Retirement Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Retirement Plan is not set yet", "Invalid Retirement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to get the next retirement ID
        public static string GetNextRetirementId()
        {
            string nextRetirementId = "R1";
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT TOP 1 retirementId FROM RetirementPlan ORDER BY retirementId DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string lastRetirementId = result.ToString();
                            int nextIdNumber = int.Parse(lastRetirementId.Substring(1)) + 1;
                            nextRetirementId = "R" + nextIdNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextRetirementId;
        }
        

        public static (string, string, string, DateTime) GetEmployeeDetails(string employeeId)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            string position = string.Empty;
            DateTime dateJoined = DateTime.MinValue;

            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT firstName, lastName, position, DateJoined FROM Employee WHERE employeeId = @employeeId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstName = reader["firstName"].ToString();
                                lastName = reader["lastName"].ToString();
                                position = reader["position"].ToString();
                                dateJoined = Convert.ToDateTime(reader["DateJoined"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (firstName, lastName, position, dateJoined);
        }

        public DataTable viewretirementPlan(string retirementId)
        {
            DataTable retireDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM RetirementPlan WHERE retirementId = @retirementId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@retirementId",retirementId); // Use the userId parameter

                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(retireDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving Retirement details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return retireDetails; // Return the DataTable with user details
        }
    }
}


