using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class Marketing
    {

        // Use properties to access and modify data
        private string marketingId { get; set; }
        private string marketingName { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
        private string type { get; set; }
        private string USP { get; set; }
        private double pricing { get; set; }
        private string FAQs { get; set; }
        private string contactNumber { get; set; }


        public void addMarketing(string marketingId, string marketingName, DateTime startDate, DateTime endDate, string type, string USP, double pricing, string FAQs, string contactNumber)
        {

            try
            {




                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Marketing (marketingId, marketingName,startDate,endDate,type,USP,pricing,FAQs,contactNumber) VALUES (@marketingId, @marketingName, @startDate, @endDate, @type, @USP,@pricing, @FAQs, @contactNumber)", con))
                    {
                        cmd.Parameters.AddWithValue("@marketingId", marketingId);
                        cmd.Parameters.AddWithValue("@marketingName", marketingName);
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@USP", USP);
                        cmd.Parameters.AddWithValue("@pricing", pricing);
                        cmd.Parameters.AddWithValue("@FAQs", FAQs);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);


                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Marketing has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }
                        else
                        {
                            MessageBox.Show("Marketing details has not been saved.An Error occurred", "Invalid Promotion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);

            }
        }
        public void updateMarketing(string marketingId, string marketingName, DateTime startDate, DateTime endDate, string type, string USP, double pricing, string FAQs, string contactNumber)
        {
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Marketing SET marketingName = @marketingName, startDate = @startDate, endDate = @endDate, type = @type, USP = @USP, pricing = @pricing, FAQs = @FAQs, contactNumber = @contactNumber WHERE marketingId = @marketingId", con))
                    {
                        cmd.Parameters.AddWithValue("@marketingId", marketingId);
                        cmd.Parameters.AddWithValue("@marketingName", marketingName);
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@USP", USP);
                        cmd.Parameters.AddWithValue("@pricing", pricing);
                        cmd.Parameters.AddWithValue("@FAQs", FAQs);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Marketing has been updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Marketing details has not been updated. An Error occurred", "Invalid Promotion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        // Select Marketing Details
        public DataTable viewMarketing(string marketingId)
        {
            DataTable marketingDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Marketing WHERE marketingId = @marketingId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@marketingId", marketingId);

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(marketingDetails);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving Marketing details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return marketingDetails;
        }

        // Delete Marketing
        public void removeMarketing(string marketingId)
        {
            // 1. Display a confirmation dialog.
            DialogResult result = MessageBox.Show($"Are you sure you want to delete marketing with ID {marketingId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 2. Check the user's response.
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Marketing WHERE marketingId = @marketingId", con))
                    {
                        cmd.Parameters.AddWithValue("@marketingId", marketingId);

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Marketing has been deleted successfully", "Deleted Marketing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Marketing details has not been deleted. An Error occurred", "Invalid Promotion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

