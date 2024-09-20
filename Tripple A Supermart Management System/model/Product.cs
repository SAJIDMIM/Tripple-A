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
    class Product
    {
        private string productId;
        private string productName;
        private string category;
        private int quantity;
        private string description;
        private double price;

        public string ProductId { get { return productId; } set { productId = value; } }
        public string ProductName { get { return productName; } set { productName = value; } }
        public string Category { get { return category; } set { category = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { price = value; } }



        public DataTable viewProducts(string productId)
        {
            DataTable productDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Products WHERE productId = @productId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@stockId", productId);


                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(productDetails);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving Product details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return productDetails;
        }
        public void addProduct(string productId, string productName, string category, int quantity, string description, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
            Quantity = quantity;
            Description = description;
            Price = price;

            // Assuming you have a SqlConnection object named 'connection'
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Products (productId, productName, category, quantity, description, price) VALUES (@productId, @productName, @category, @quantity, @description, @price)", connection);

                command.Parameters.AddWithValue("@productId", productId);
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Product has been added successfully", "Product Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product Details has not been saved.An error occurred", "Invalid Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void updateProduct(string productId, string productName, string category, int quantity, string description, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
            Quantity = quantity;
            Description = description;
            Price = price;

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE Products SET productName = @productName, category = @category, quantity = @quantity, description = @description, price = @price WHERE productId = @productId", connection);

                command.Parameters.AddWithValue("@productId", productId);
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@price", price);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Product has been updated successfully", "Product Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product Details has not been updated.An error occurred", "Invalid Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void removeProduct(string productId)
        {
            ProductId = productId;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = MDBConnection.createConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Producta WHERE productId = @productId", connection);

                    command.Parameters.AddWithValue("@productId", productId);

                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Product has been deleted successfully", "Product Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Product Details has not been deleted.An error occurred", "Invalid Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Delete operation cancelled", "Delete Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable viewProduct(string productId)
        {
            DataTable productDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE productId = @productId", connection);

                command.Parameters.AddWithValue("@productId", productId);

                SqlDataReader reader = command.ExecuteReader();

                productDetails.Load(reader);
            }

            return productDetails;
        }
    }
}

