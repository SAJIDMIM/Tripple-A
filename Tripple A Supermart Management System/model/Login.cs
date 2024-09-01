using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Tripple_A_Supermart_Management_System.model

{
    public class Users
    {
        public string Username { get; set; }
        public string Role { get; set; }
    }
    public class Login
    {


        public Users Login(string usertype, string username, string password)
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
               
                
                    con.Open();
                    string query_select = "select user_type,username,user_password from UserLogin where username = @Username and user_password = @Password and user_type = @UserType ";
                    using (SqlCommand cmd = new SqlCommand(query_select, con))
                    {
                        cmd.Parameters.AddWithValue("@UserType", usertype);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there are any rows
                            {
                                // If there are rows, create a new User object
                                return new Users
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
    


