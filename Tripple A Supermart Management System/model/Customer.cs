using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.model
{
    class Customer
    {
        protected string customerId { get; set; }
        protected string customerName { get; set; }
        protected DateTime DoB { get; set; }
        protected string Gender { get; set; }
        protected string Email { get; set; }
        protected string City { get; set; }
        protected string Street { get; set; }
        protected int PostalCode { get; set; }
        protected string mobile { get; set; }
        protected string Type { get; set; }
        protected string MemberStatus { get; set; }

        // A method to view customer details based on type
        public virtual DataTable viewCustomer(string mobile, string Type)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                string query_select = "select * from Customer where mobile = @mobile and Type = @Type";
                using (SqlCommand cmd = new SqlCommand(query_select, con))
                {
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@Type", Type);
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
        // Add Customer
        public void addCustomer(string customerId, string customerName, DateTime DoB, string Gender, string Email, string City, string Street, int PostalCode, string mobile, string Type)
        {
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Customer (customerId, customerName, DoB, Gender, Email, City, Street, PostalCode, mobile, Type) VALUES (@customerId, @customerName, @DoB, @Gender, @Email, @City, @Street, @PostalCode, @mobile, @Type)", con))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@customerName", customerName);
                        cmd.Parameters.AddWithValue("@DoB", DoB);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@City", City);
                        cmd.Parameters.AddWithValue("@Street", Street);
                        cmd.Parameters.AddWithValue("@PostalCode", PostalCode);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@Type", Type);
                   

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Customer has been added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Customer details has not been saved. An Error occurred", "Invalid Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        // Edit Customer
        public void editCustomer(string customerId, string customerName, DateTime DoB, string Gender, string Email, string City, string Street, int PostalCode, string mobile, string Type)
        {
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Customer SET customerId = @customerId,customerName = @customerName, DoB = @DoB, Gender = @Gender, Email = @Email, City = @City, Street = @Street, PostalCode = @PostalCode,Type = @Type WHERE mobile = @mobile", con))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@customerName", customerName);
                        cmd.Parameters.AddWithValue("@DoB", DoB);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@City", City);
                        cmd.Parameters.AddWithValue("@Street", Street);
                        cmd.Parameters.AddWithValue("@PostalCode", PostalCode);
                        cmd.Parameters.AddWithValue("@mobile", mobile);
                        cmd.Parameters.AddWithValue("@Type", Type);
                        

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Customer has been updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Customer details has not been updated. An Error occurred", "Invalid Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // View Customer
        public DataTable viewCustomers(string mobile)
        {
            DataTable customerDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Customer WHERE mobile = @mobile";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mobile",mobile);

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(customerDetails);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving Customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return customerDetails;
        }
        // Remove Customer
        public void removeCustomer(string mobile)
        {
            // 1. Display a confirmation dialog.
            DialogResult result = MessageBox.Show($"Are you sure you want to delete customer with ID {mobile}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 2. Check the user's response.
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE mobile = @mobile", con))
                    {
                        cmd.Parameters.AddWithValue("@mobile", mobile);

                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Customer has been deleted successfully", "Deleted Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Customer details has not been deleted. An Error occurred", "Invalid Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    class LoyaltyCustomer : Customer
    {
        // If any specific logic for loyalty customers is needed, override here
    }

    class NormalCustomer : Customer
    {
        // If any specific logic for normal customers is needed, override here
    }
}
