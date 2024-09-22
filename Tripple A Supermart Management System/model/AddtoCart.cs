using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    class AddtoCart
    {
        private int addCartId;
        private string customerName;
        private string productName;
        private string itemName;
        private int quantity;
        private double unitPrice;
        private double discount;
        private double tax;
        private double totalAmount;
        private DateTime payDate;
        private string paymentMethod;
        private string stockName;
        private string orderId;

        public int AddCartId
        {
            get { return addCartId; }
            set { addCartId = value; }
        }

        public string OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }

        public double TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        public DateTime PayDate
        {
            get { return payDate; }
            set { payDate = value; }
        }

        public string StockName
        {
            get { return stockName; }
            set { stockName = value; }
        }

        // Method to view the order details for a given order ID
        public DataTable viewOrder(string orderId)
        {
            DataTable orderDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT customerName, productName, itemName, Quantity, unitPrice, discount, tax, totalPrice, payDate, paymentMethod, stockName, orderId FROM CustomerOrder WHERE orderId = @orderId", connection);
                command.Parameters.AddWithValue("@orderId", orderId);

                SqlDataReader reader = command.ExecuteReader();
                orderDetails.Load(reader);
            }

            return orderDetails;
        }
        public static int GetNextCartId()
        {
            int nextCartId = 1;
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT ISNULL(MAX(addtoCart), 0) + 1 FROM AddtoCart";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            nextCartId = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextCartId;
        }

        public void addtoCart(string customerName, string productName, string itemName, int quantity, double unitPrice, double discount, double tax, double totalPrice, DateTime payDate, string paymentMethod, string stockName, string orderId)
        {
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction(); // Use transaction for atomicity
                try
                {
                    // Check if order Id exists
                    SqlCommand checkOrderCommand = new SqlCommand("SELECT COUNT(*) FROM CustomerOrder WHERE orderId = @OrderId", connection, transaction);
                    checkOrderCommand.Parameters.AddWithValue("@OrderId", orderId);
                    int orderExists = (int)checkOrderCommand.ExecuteScalar();

                    if (orderExists > 0)
                    {
                        // Update existing order quantity
                        SqlCommand updateOrderQuantityCommand = new SqlCommand("UPDATE CustomerOrder SET Quantity = Quantity + @Quantity WHERE orderId = @OrderId", connection, transaction);
                        updateOrderQuantityCommand.Parameters.AddWithValue("@Quantity", quantity);
                        updateOrderQuantityCommand.Parameters.AddWithValue("@OrderId", orderId);
                        int rowsAffected = updateOrderQuantityCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Fetch current quantity for the product
                            SqlCommand getProductQuantityCommand = new SqlCommand("SELECT Quantity FROM Product WHERE productName = @ProductName", connection, transaction);
                            getProductQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
                            int currentProductQuantity = (int)getProductQuantityCommand.ExecuteScalar();

                            // Fetch current quantity for the item
                            SqlCommand getItemQuantityCommand = new SqlCommand("SELECT Quantity FROM Item WHERE itemName = @ItemName", connection, transaction);
                            getItemQuantityCommand.Parameters.AddWithValue("@ItemName", itemName);
                            int currentItemQuantity = (int)getItemQuantityCommand.ExecuteScalar();

                            // Update Stock table
                            SqlCommand updateStockCommand = new SqlCommand("UPDATE Stock SET stockQuantity = stockQuantity - @stockquantity WHERE stockName = @stockName", connection, transaction);
                            updateStockCommand.Parameters.AddWithValue("@stockquantity", quantity);
                            updateStockCommand.Parameters.AddWithValue("@stockName", stockName);
                            updateStockCommand.ExecuteNonQuery();

                            // Update product table
                            SqlCommand updateProductCommand = new SqlCommand("UPDATE Product SET Quantity = Quantity - @quantity WHERE productName = @ProductName", connection, transaction);
                            updateProductCommand.Parameters.AddWithValue("@quantity", quantity);
                            updateProductCommand.Parameters.AddWithValue("@ProductName", productName);
                            updateProductCommand.ExecuteNonQuery();

                            // Update item table
                            SqlCommand updateItemCommand = new SqlCommand("UPDATE Item SET Quantity = Quantity - @quantity WHERE itemName = @ItemName", connection, transaction);
                            updateItemCommand.Parameters.AddWithValue("@quantity", quantity);
                            updateItemCommand.Parameters.AddWithValue("@ItemName", itemName);
                            updateItemCommand.ExecuteNonQuery();

                            transaction.Commit(); // Commit transaction
                            MessageBox.Show("Order quantity has been updated successfully", "Order Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Order quantity update failed", "Order Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Insert new order record
                        SqlCommand command = new SqlCommand("INSERT INTO AddtoCart (customerName, productName, itemName, Quantity, unitPrice, discount, tax, totalprice, paymentMethod, payDate,stockName,orderId) VALUES (@CustomerName, @ProductName, @ItemName, @Quantity, @UnitPrice, @Discount, @Tax, @TotalPrice, @PaymentMethod, @PayDate,@stockName,@orderId)", connection, transaction);

                        command.Parameters.AddWithValue("@OrderId", orderId);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@ItemName", itemName);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        command.Parameters.AddWithValue("@Discount", discount);
                        command.Parameters.AddWithValue("@Tax", tax);
                        command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        command.Parameters.AddWithValue("@PayDate", payDate);

                        command.Parameters.AddWithValue("@stockName", stockName);

                        int count = command.ExecuteNonQuery();

                        if (count > 0)
                        {
                            // Fetch current quantity for the product
                            SqlCommand getProductQuantityCommand = new SqlCommand("SELECT Quantity FROM Product WHERE productName = @ProductName", connection, transaction);
                            getProductQuantityCommand.Parameters.AddWithValue("@ProductName", productName);
                            int currentProductQuantity = (int)getProductQuantityCommand.ExecuteScalar();

                            // Fetch current quantity for the item
                            SqlCommand getItemQuantityCommand = new SqlCommand("SELECT Quantity FROM Item WHERE itemName = @ItemName", connection, transaction);
                            getItemQuantityCommand.Parameters.AddWithValue("@ItemName", itemName);
                            int currentItemQuantity = (int)getItemQuantityCommand.ExecuteScalar();

                            // Check if there is enough stock for the order
                            if (currentProductQuantity < quantity || currentItemQuantity < quantity)
                            {
                                MessageBox.Show("Insufficient stock for this order", "Insufficient Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback(); // Roll back the transaction if not enough stock
                                return;
                            }

                            // Update Stock table
                            SqlCommand updateStockCommand = new SqlCommand("UPDATE Stock SET stockQuantity = stockQuantity - @stockquantity WHERE stockName = @stockName", connection, transaction);
                            updateStockCommand.Parameters.AddWithValue("@stockquantity", quantity);
                            updateStockCommand.Parameters.AddWithValue("@stockName", stockName);
                            updateStockCommand.ExecuteNonQuery();

                            // Update product table
                            SqlCommand updateProductCommand = new SqlCommand("UPDATE Product SET Quantity = Quantity - @quantity WHERE productName = @ProductName", connection, transaction);
                            updateProductCommand.Parameters.AddWithValue("@quantity", quantity);
                            updateProductCommand.Parameters.AddWithValue("@ProductName", productName);
                            updateProductCommand.ExecuteNonQuery();

                            // Update item table
                            SqlCommand updateItemCommand = new SqlCommand("UPDATE Item SET Quantity = Quantity - @quantity WHERE itemName = @ItemName", connection, transaction);
                            updateItemCommand.Parameters.AddWithValue("@quantity", quantity);
                            updateItemCommand.Parameters.AddWithValue("@ItemName", itemName);
                            updateItemCommand.ExecuteNonQuery();

                            transaction.Commit(); // Commit transaction
                            MessageBox.Show("Order has been placed successfully", "Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Order not placed yet", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Rollback in case of an error
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Method to retrieve receipt data from the database
        public DataTable GetReceiptData(string orderId)
        {
            DataTable receiptData = new DataTable();

            // Create a SqlConnection object
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand("SELECT * FROM AddtoCart WHERE orderId = @orderId", connection))
                {
                    // Add the orderId parameter
                    command.Parameters.AddWithValue("@orderId", orderId);

                    // Open the database connection
                    connection.Open();

                    // Create a SqlDataAdapter object
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Fill the DataTable with data
                        adapter.Fill(receiptData);
                    }
                }
            }

            return receiptData;
        }
    }

    }

