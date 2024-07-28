using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    public class MJob
    {
        private string _postId;
        private string _jobTitle;
        private List<string> _jobTypes;
        private string _jobDescription;
        public void postJob(string post_Id, string job_Title, List<string> jobTypes, string Job_Description)
        {
            _postId = post_Id;
            _jobTitle = job_Title;
            _jobTypes = jobTypes;
            _jobDescription = Job_Description;
            using (SqlConnection con = MDBConnection.createConnection())
            {

                // Convert jobTypes to a single string
                string jobTypesString = string.Join(",", jobTypes);



                // Insert job details
                
                string query_insert = "insert into Job (post_Id, job_Title, jobType, Job_Description) VALUES (@postId, @jobTitle, @jobType, @jobDescription)";
                using (SqlCommand cmd = new SqlCommand(query_insert, con))
                {
                    cmd.Parameters.AddWithValue("@postId", post_Id);
                    cmd.Parameters.AddWithValue("@jobTitle", job_Title);
                    cmd.Parameters.AddWithValue("@jobType", jobTypesString);
                    cmd.Parameters.AddWithValue("@jobDescription", Job_Description);
                    con.Open();

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Job has been successfully posted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Job has not been posted yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           
        }

    }
}

        
 


        
        

