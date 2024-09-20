using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class Sale
    {
        private int saleId;
        private string productId;
        private string productName;
        private double price;
        private int quantity;
        private DateTime saleStartDate;
        private DateTime saleEndDate;
        private double priceCalculate;
        private double discount;
        private string payMethod;
        private string customerId;
        private string customerName;

        public int SaleId
        {
            get { return saleId; }
            set { saleId = value; }
        }

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime SaleDate
        {
            get { return saleStartDate; }
            set { saleEndDate = value; }
        }

        public double PriceCalculate
        {
            get { return priceCalculate; }
            set { priceCalculate = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public string PayMethod
        {
            get { return payMethod; }
            set { payMethod = value; }
        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public DataTable analyzeSale()
        {

            DataTable saleDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Sale"; // Modify the query to fetch all sales

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(saleDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving sale details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return saleDetails; // Return the DataTable with sale details
        }


        public void promoteSale(int saleId, DateTime saleStartDate, DateTime saleEndDate, double price, double discount)
        {
            // Validate Sale ID
            if (saleId <= 0)
            {
                MessageBox.Show("Invalid Sale ID. Please enter a valid Sale ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Sale Start Date (cannot be in the past)
            if (saleStartDate < DateTime.Now)
            {
                MessageBox.Show("Sale start date cannot be in the past.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Sale End Date (must be after start date)
            if (saleEndDate <= saleStartDate)
            {
                MessageBox.Show("Sale end date must be after the start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Price (must be positive)
            if (price <= 0)
            {
                MessageBox.Show("Price must be a positive value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Discount (must be between 0 and 100)
            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("Discount must be a percentage between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                // Check if at least one field has changed
                bool hasChanges = saleStartDate != this.saleStartDate ||
                                 saleEndDate != this.saleEndDate ||
                                 price != this.price ||
                                 discount != this.discount;

                // Only update if there are changes
                if (hasChanges)
                {
                    using (SqlConnection con = MDBConnection.createConnection())
                    {
                        string query = "UPDATE Sale SET saleStartDate = @saleStartDate, saleEndDate = @saleEndDate, price = @price, discount = @discount WHERE saleId = @saleId";

                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            // Add parameters
                            command.Parameters.AddWithValue("@saleId", saleId);  // Pass the saleId parameter
                            command.Parameters.AddWithValue("@saleStartDate", saleStartDate);
                            command.Parameters.AddWithValue("@saleEndDate", saleEndDate);
                            command.Parameters.AddWithValue("@price", price);
                            command.Parameters.AddWithValue("@discount", discount);

                            con.Open();
                            int count = command.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("Successfully Predicted the Sale", "Promote Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sale was not Predicted yet.Try some other time", "Promote Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }




                        }

                    }

                }
            }

        }


        public DataTable getSaleDetails(int saleId)
        {
            DataTable saleDetails = new DataTable();
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT productId,productName, saleStartDate,saleEndDate,price,discount FROM Sale WHERE saleId = @saleId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@saleId", saleId);

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(saleDetails);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving sale details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return saleDetails;
        }
        public void createSale(string productId, string productName, double price, int quantity, DateTime saleDate, DateTime saleEndDate, double priceCalculate, double discount, string payMethod, string customerId, string customerName)
        {
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Sale (productId, productName, price,Quantity, saleStartDate,saleEndDate,priceCalculate, discount, payMethod,mobile, customerName) VALUES (@ProductId, @ProductName, @Price, @Quantity, @SaleDate,@saleEndDate, @PriceCalculate, @Discount, @PayMethod, @mobile, @CustomerName)", connection);


                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@SaleDate", saleDate);
                command.Parameters.AddWithValue("@SaleEndDate", saleEndDate);
                command.Parameters.AddWithValue("@PriceCalculate", priceCalculate);
                command.Parameters.AddWithValue("@Discount", discount);
                command.Parameters.AddWithValue("@PayMethod", payMethod);
                command.Parameters.AddWithValue("@mobile", customerId);
                command.Parameters.AddWithValue("@CustomerName", customerName);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Sale has been added successfully", "Sale Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sale not been added yet", "Invalid Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public DataTable getProduct(string productId)
        {
            DataTable productDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT productName, price FROM Product WHERE productId = @productId", connection);

                command.Parameters.AddWithValue("@productId", productId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(productDetails);
            }

            return productDetails;
        }



        public DataTable viewCustomer(string mobile)
        {
            DataTable customerDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT customerName FROM Customer WHERE mobile = @mobile", connection);

                command.Parameters.AddWithValue("@mobile", mobile);

                SqlDataReader reader = command.ExecuteReader();

                customerDetails.Load(reader);
            }

            return customerDetails;
        }

        public static int GetNextSaleId()
        {
            int nextSaleId = 1;
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT ISNULL(MAX(saleId), 0) + 1 FROM Sale";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            nextSaleId = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextSaleId;
        }

        public DataTable viewSale(string saleId)
        {
            DataTable saleDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Sale WHERE saleId = @saleId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@saleId", saleId); // Use the userId parameter

                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(saleDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving Sale details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return saleDetails; // Return the DataTable with user details
        }
    }
}

