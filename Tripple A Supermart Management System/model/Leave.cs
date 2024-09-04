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
                               "VALUES (@employeeId, @UserType, @firstName, @lastName, @LeaveType, @Reason, @LeaveStartDate, @LeaveEndDate)";
                               
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@UserType", userType);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@LeaveType", leaveType);
                    cmd.Parameters.AddWithValue("@Reason", reason);
                    cmd.Parameters.AddWithValue("@LeaveStartDate", leaveStartDate);
                    cmd.Parameters.AddWithValue("@LeaveEndDate", leaveEndDate);

                    int leaveRequestId = cmd.ExecuteNonQuery();
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

        

        public DataTable getLeave(int leaveRequestedId)
        {
            DataTable leaveDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Leave WHERE leaveRequestId = @leaveRequestId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@leaveRequestId",leaveRequestedId); 

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
                        MessageBox.Show("Error retrieving Leave details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return leaveDetails; 
        }
        public DataTable getEmployee(string employeeId)
        {
            DataTable empDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Employee WHERE employeeId = @employeeId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@leaveRequestedId",employeeId);

                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(empDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        MessageBox.Show("Error retrieving Employee details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return empDetails;
        }

        // Method to get the next retirement ID
        public static int GetNextLeaveId()
        {
            int nextLeaveId = 1;
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT ISNULL(MAX(leaveRequestId), 0) + 1 FROM Leave";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            nextLeaveId = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextLeaveId;
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

