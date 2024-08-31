using System;
using System.Data.SqlClient;
using Tripple_A_Supermart_Management_System.model;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing.Imaging;

public class Profile
{
    public int AdminId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

   

    public string Gender { get; set; }
    public string Email { get; set; }
    public DateTime DoB { get; set; }
    public byte[] AdminPhoto { get; set; }


    public void updateProfile(int adminId, string firstName, string lastName, string gender, string email, DateTime doB)
    {
       // Connect to the database
    using (SqlConnection con = MDBConnection.createConnection())
    {
        try
        {
            // Open the connection before executing the command
            con.Open();

            string query = "UPDATE Admin SET firstName = @firstName, lastName = @lastName, doB = @doB, gender = @gender, email = @email WHERE adminId = @adminId";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@adminId", adminId);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@doB", doB);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);

                    /*if (adminPhoto != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            adminPhoto.Save(ms, ImageFormat.Png); // Choose appropriate image format
                            byte[] adminPhotoBytes = ms.ToArray();
                            command.Parameters.AddWithValue("@adminPhoto", Convert.ToString(adminPhotoBytes));
                        }
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@adminPhoto", DBNull.Value); // Handle case of null image
                    }*/

                    int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Admin Profile Updated Successfully.","Updated Profile",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Encountered issue on update,please try again later!","Invalid Update Profile",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error updating admin profile: " + ex.Message);
        }
        finally
        {
            // Close the connection even if an exception occurred
            con.Close();
        }
    }
    }

    public DataTable getAdminDetails(int adminId)
    {
        DataTable adminDetails = new DataTable();

        using (SqlConnection connection = MDBConnection.createConnection())
        {
            string query = "SELECT firstName,lastName,doB,gender,email,adminPhoto FROM Admin WHERE adminId = @adminId";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@adminId", adminId);

                try
                {
                    // Open the connection before executing the command
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(adminDetails);
                        
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving stock details: " + ex.Message);
                }
                finally
                {
                    // Close the connection even if an exception occurred
                    connection.Close();
                }
            }
        }

        return adminDetails;
    }

    
}