using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    public class Employees
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Leave
    {
        // Method to add a leave request (already provided)
        public void addLeaveRequest(string employeeId, string userType, string firstName, string lastName, string leaveType, string reason, DateTime leaveStartDate, DateTime leaveEndDate)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                string query = "INSERT INTO Leave (employeeId, userType, firstName, lastName, LeaveType, reason, leaveStartDate, leaveEndDate) " +
                               "VALUES (@EmployeeId, @UserType, @firstName, @lastName, @LeaveType, @Reason, @LeaveStartDate, @LeaveEndDate); " +
                               "SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmd.Parameters.AddWithValue("@UserType", userType);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@LeaveType", leaveType);
                    cmd.Parameters.AddWithValue("@Reason", reason);
                    cmd.Parameters.AddWithValue("@LeaveStartDate", leaveStartDate);
                    cmd.Parameters.AddWithValue("@LeaveEndDate", leaveEndDate);

                    int leaveRequestId = Convert.ToInt32(cmd.ExecuteScalar());
                    if (leaveRequestId > 0)
                    {
                        MessageBox.Show("Leave has been successfully requested", "Leave Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Leave has not been requested yet", "Invalid Leave Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        public DataTable viewLeaveRequest(int leaveRequestId)
        {
            DataTable leaveDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Leave WHERE leaveRequestId = @leaveRequestId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", leaveRequestId); // Use the userId parameter

                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(leaveDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving user details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return leaveDetails; // Return the DataTable with user details
        }

        // Method to get the next leave request ID (already provided)
        public int GetNextLeaveRequestId()
        {
            int nextLeaveRequestId = 1; // Default to 1 if there are no records
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT TOP 1 leaveRequestId FROM Leave ORDER BY leaveRequestId DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int lastIdNumber = Convert.ToInt32(result);
                            nextLeaveRequestId = lastIdNumber + 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextLeaveRequestId;
        }

       

        // Method to get employees by user type
        public List<Employees> GetEmployeesByUserType(string userType)
        {
            List<Employees> employees = new List<Employees>();

            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                string query = "SELECT employeeId, firstName, lastName FROM Employee WHERE UserType = @UserType";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@UserType", userType);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employees employee = new Employees
                            {
                                EmployeeId = reader["employeeId"].ToString(),
                                FirstName = reader["firstName"].ToString(),
                                LastName = reader["lastName"].ToString()
                            };

                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

      
    }
}

