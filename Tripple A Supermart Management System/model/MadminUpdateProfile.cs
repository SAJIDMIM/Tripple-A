using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tripple_A_Supermart_Management_System.model
{
    public class MadminUpdateProfile
    {
        public void UpdateProfile(string adminId,string name,DateTime DoB,string Gender, string email,string username,string password,string Type, byte[] photo)
        {
            // Assuming a connection string "your_connection_string"
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                // SQL query to retrieve the username and password from the login table
                string query = "select username, password from admin where user_type = @UserType ";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserType", Type);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                 username = reader["username"].ToString();
                                 password = reader["password"].ToString();

                                // Update the admin profile with the retrieved username and password
                                query = "update adminProfile set Name = @Name,DoB = @DoB,Gender = @Gender, email = @Email, username = @Username, password = @Password,adminPhoto = @Photo WHERE adminId  = @AdminID AND Type = @Type";

                                using (SqlCommand updateCommand = new SqlCommand(query, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@Name", name);
                                    updateCommand.Parameters.AddWithValue("@Email", email);
                                    updateCommand.Parameters.AddWithValue("@Username", username);
                                    updateCommand.Parameters.AddWithValue("@Password", password);
                                    updateCommand.Parameters.AddWithValue("@Photo", photo);
                                    updateCommand.Parameters.AddWithValue("@AdminID", adminId);
                                    updateCommand.Parameters.AddWithValue("@Type",Type);

                                    updateCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error updating profile: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
