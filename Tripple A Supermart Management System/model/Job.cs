using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    public class Job
    {
        private string post_Id { get; set; }
        private string Job_Title { get; set; }
        private string jobType { get; set; }
        private string job_Description { get; set; }
        private DateTime Date { get; set; }

        // Method to post a job
        public void postJob(string post_Id, string Job_Title, string jobType, string Job_Description, DateTime Date)
        {

            using (SqlConnection con = MDBConnection.createConnection())
            {


                // Insert job details
                string query_insert = "insert into Job (post_Id, Job_Title, jobType, Job_Description,Date) VALUES (@postId, @jobTitle, @jobType, @jobDescription,@Date)";
                using (SqlCommand cmd = new SqlCommand(query_insert, con))
                {
                    cmd.Parameters.AddWithValue("@postId", post_Id);
                    cmd.Parameters.AddWithValue("@jobTitle", Job_Title);
                    cmd.Parameters.AddWithValue("@jobType", jobType);
                    cmd.Parameters.AddWithValue("@jobDescription", Job_Description);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    con.Open();

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Job has been successfully posted.", "Posted Job", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Job has not been posted yet", "Invalid Posted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Method to get job details by job type
        public DataTable viewPostJob(string post_Id)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                string query_select = "select * from Job where post_Id = @post_Id ";
                using (SqlCommand cmd = new SqlCommand(query_select, con))
                {
                    cmd.Parameters.AddWithValue("@post_Id", post_Id);
                    con.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;

                    }
                }
            }
        }
    }
}