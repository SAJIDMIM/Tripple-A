using System;
using System.Data.SqlClient; // For SQL Server operations
using System.Drawing; // For Image handling

namespace Tripple_A_Supermart_Management_System.model
{
    public class Admin
    {
        internal string firstName;
        internal string lastName;
        internal string gender;
        internal string email;
        internal DateTime doB;
        internal Image adminPhoto; // Image handling requires logic to load/create images

        public string Username { get; set; }
        public string Role { get; set; }
    }

    public class MAdmin
    {
        

        public Admin Login(string Type, string username, string password)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                try
                {
                    con.Open();

                    // Select statement to retrieve user information based on credentials
                    string query_select = "SELECT user_type, username FROM Admin WHERE username = @Username AND password = @Password AND user_type = @UserType";
                    using (SqlCommand cmd = new SqlCommand(query_select, con))
                    {
                        cmd.Parameters.AddWithValue("@UserType", Type);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // If the credentials match, create and return an Admin object
                                return new Admin
                                {
                                    Username = reader["username"].ToString(),
                                    Role = reader["user_type"].ToString()
                                };
                            }
                            else
                            {
                                // If credentials are invalid, return null
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions properly (log, display error message, etc.)
                    Console.WriteLine($"Error during login: {ex.Message}");
                    return null;
                }
            }
        }
    }
}