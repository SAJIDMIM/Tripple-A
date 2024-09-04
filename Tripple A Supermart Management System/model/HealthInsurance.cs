using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class HealthInsurance
    {
        // Private fields with auto-implemented properties
        public int HealthInsuranceID { get; set; }
        public string EmployeeID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double PremiumAmount { get; set; }
        public double DeductibleAmount { get; set; }
        public string RenewalOption { get; set; }

        public void AddHealthInsurance(string employeeID, string firstName, string lastName, string type, string description, DateTime effectiveDate, DateTime expiryDate, double premiumAmount, double deductibleAmount, string renewalOption)
        {
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "INSERT INTO HealthInsurance (employeeID, firstName, lastName, Type, Description, EffectiveDate, ExpiryDate, PremiumAmount, deductibleAmount, RenewalOption) " +
                                   "VALUES (@employeeID, @firstName, @lastName, @Type, @Description, @EffectiveDate, @ExpiryDate, @PremiumAmount, @deductibleAmount, @RenewalOption)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@employeeID", employeeID);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@EffectiveDate", effectiveDate);
                        cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                        cmd.Parameters.AddWithValue("@PremiumAmount", premiumAmount);
                        cmd.Parameters.AddWithValue("@deductibleAmount", deductibleAmount);
                        cmd.Parameters.AddWithValue("@RenewalOption", renewalOption);

                        int count = cmd.ExecuteNonQuery();

                        if (count > 0)
                        {
                            MessageBox.Show("Health Insurance has been added", "Health Insurance Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Health Insurance is not set yet", "Invalid Health Insurance", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public static int GetNextHealthId()
        {
            int nextHealthId = 1;
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT ISNULL(MAX(HealthInsuranceID), 0) + 1 FROM HealthInsurance";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            nextHealthId = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextHealthId;
        }

        public DataTable getEmployeeDetails(string employeeId)
        {
            DataTable employeeDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT firstName,lastName FROM Employee WHERE employeeId = @employeeId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(employeeDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving Employee details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return employeeDetails;
        }
        public DataTable viewHealthInsurance(int HealthInsuranceID)
        {
            DataTable healthDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM HealthInsurance WHERE HealthInsuranceId = @HealthInsuranceId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HealthInsuranceId", HealthInsuranceID);

                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(healthDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        MessageBox.Show("Error retrieving Health Insurance details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return healthDetails;
        }
    }
}
