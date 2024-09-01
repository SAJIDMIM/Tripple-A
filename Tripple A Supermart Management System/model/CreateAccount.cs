using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tripple_A_Supermart_Management_System.view;
using System.Windows.Forms;




namespace Tripple_A_Supermart_Management_System.model
{
    public class CreateAccount
    {
        public void createAccount(string user_type, string username, string email, string password, string confirm_password)
        {
            
           
            using (SqlConnection con = MDBConnection.createConnection())
            {
                try
                {
                   
                    
                    string insert_query = "INSERT INTO UserLogin (user_type, username, Email,user_password,user_confirm_password) VALUES (@UserType, @Username, @Email, @Password,@ConfirmPassword)";

                    using (SqlCommand cmd = new SqlCommand(insert_query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserType", user_type);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email",email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@ConfirmPassword", confirm_password);

                        con.Open();
                       
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            
                            
                           
                            MessageBox.Show("You have been successfully registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show("Encountered an error.Please review your fields and try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                con.Close();
                
            }
            

        }
    }
}
            


                
        
        
    



    

