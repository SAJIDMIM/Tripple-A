using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    public class MForgotPassword
    {
        public void ForgotPassword(string username, string password, string confirm_password)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                string query_Update = "update UserLogin set user_password = @Password where username = @Username";
                using (SqlCommand cmd = new SqlCommand(query_Update, con))
                {

                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);



                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Successfully Updated Password", "Reset Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password was not updated.Please check and try again later", "Reset Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                con.Close();

            }

        }
    }
}
