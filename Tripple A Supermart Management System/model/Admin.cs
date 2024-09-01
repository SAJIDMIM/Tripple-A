using System;
using System.Data.SqlClient;//without this statement sql won't be work
using System.Drawing;





namespace Tripple_A_Supermart_Management_System.model
{
    public class Admin
    {
        internal string firstName;
        internal string lastName;
        internal string gender;
        internal string email;
        internal DateTime doB;
        internal Image adminPhoto;

        public string Username { get; set; }
        public string Role { get; set; }


    }
    public class MAdmin
    {

        public Admin Login(string Type, string username, string password)//declare method with enum
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {


                con.Open();
                string query_select = "select user_type,username,password from Admin where username = @Username and password = @Password and user_type = @UserType ";
                using (SqlCommand cmd = new SqlCommand(query_select, con))
                {
                    cmd.Parameters.AddWithValue("@UserType", Type);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Check if there are any rows
                        {
                            // If there are rows, create a new User object
                            return new Admin
                            {
                                Username = reader["username"].ToString(),
                                Role = reader["user_type"].ToString()
                            };
                        }
                        else
                        {
                            // If there are no rows, return null
                            return null;
                        }
                    }
                }
            }
        }

    }

}



