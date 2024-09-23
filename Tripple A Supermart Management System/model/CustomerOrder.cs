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
    class CustomerOrder
    {
        public class Order
        {
            private string orderId;
            private string mobile;
            private string customerName;
            private string productId;
            private string productName;
            private string itemId;
            private string itemName;
            private int quantity;
            private double unitPrice;
            private double discount;
            private double tax;
            private double totalPrice;
            private string paymentMethod;
            private DateTime payDate;
            private string status;
            private string stockId;
            private string stockName;

            public string OrderId
            {
                get { return orderId; }
                set { orderId = value; }
            }

            public string Mobile
            {
                get { return mobile; }
                set { mobile = value; }
            }

            public string CustomerName
            {
                get { return customerName; }
                set { customerName = value; }
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

            public string ItemId
            {
                get { return itemId; }
                set { itemId = value; }
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

            public double TotalPrice
            {
                get { return totalPrice; }
                set { totalPrice = value; }
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

            public string Status
            {
                get { return status; }
                set { status = value; }
            }

            public string StockId
            {
                get { return stockId; }
                set { stockId = value; }
            }

            public string StockName
            {
                get { return stockName; }
                set { stockName = value; }
            }
        }


        public void placeOrder(string orderId, string mobile, string customerName, string productId, string productName, string itemId, string itemName, int quantity, double unitPrice, double discount, double tax, double totalPrice, string paymentMethod, DateTime payDate, string status,string stockId,string stockName)
        {
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction(); // Use transaction for atomicity
                try
                {
                    // Insert order record
                    SqlCommand command = new SqlCommand("INSERT INTO CustomerOrder (orderId, mobile, customerName, productId, productName, itemId, itemName, Quantity, unitPrice, discount, tax, totalprice, paymentMethod, payDate, status,stockId,stockName) VALUES (@OrderId, @Mobile, @CustomerName, @ProductId, @ProductName, @ItemId, @ItemName, @Quantity, @UnitPrice, @Discount, @Tax, @TotalPrice, @PaymentMethod, @PayDate, @Status,@stockId,@stockName)", connection, transaction);

                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.Parameters.AddWithValue("@Mobile", mobile);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@ProductId", productId);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@ItemId", itemId);
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    command.Parameters.AddWithValue("@Discount", discount);
                    command.Parameters.AddWithValue("@Tax", tax);
                    command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    command.Parameters.AddWithValue("@PayDate", payDate);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@stockId", stockId);
                    command.Parameters.AddWithValue("@stockName", stockName);

                    int count = command.ExecuteNonQuery();

                    if (count > 0)
                    {
                        // Fetch current quantity for the product
                        SqlCommand getProductQuantityCommand = new SqlCommand("SELECT Quantity FROM Product WHERE productId = @ProductId", connection, transaction);
                        getProductQuantityCommand.Parameters.AddWithValue("@ProductId", productId);
                        int currentProductQuantity = (int)getProductQuantityCommand.ExecuteScalar();

                        // Fetch current quantity for the item
                        SqlCommand getItemQuantityCommand = new SqlCommand("SELECT Quantity FROM Item WHERE itemId = @ItemId", connection, transaction);
                        getItemQuantityCommand.Parameters.AddWithValue("@ItemId", itemId);
                        int currentItemQuantity = (int)getItemQuantityCommand.ExecuteScalar();

                        // Check if there is enough stock for the order
                        if (currentProductQuantity < quantity || currentItemQuantity < quantity)
                        {
                            MessageBox.Show("Insufficient stock for this order", "Insufficient Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback(); // Roll back the transaction if not enough stock
                            return;
                        }

                        // Update Stock table
                        SqlCommand updateStockCommand = new SqlCommand("UPDATE Stock SET stockQuantity = stockQuantity - @stockquantity WHERE stockId = @stockId", connection, transaction);
                        updateStockCommand.Parameters.AddWithValue("@stockquantity", quantity);
                        updateStockCommand.Parameters.AddWithValue("@stockId",stockId);
                        updateStockCommand.ExecuteNonQuery();

                        // Update product table
                        SqlCommand updateProductCommand = new SqlCommand("UPDATE Product SET Quantity = Quantity - @quantity WHERE productId = @ProductId", connection, transaction);
                        updateProductCommand.Parameters.AddWithValue("@quantity", quantity);
                        updateProductCommand.Parameters.AddWithValue("@ProductId", productId);
                        updateProductCommand.ExecuteNonQuery();

                        // Update item table
                        SqlCommand updateItemCommand = new SqlCommand("UPDATE Item SET Quantity = Quantity - @quantity WHERE itemId = @ItemId", connection, transaction);
                        updateItemCommand.Parameters.AddWithValue("@quantity", quantity);
                        updateItemCommand.Parameters.AddWithValue("@ItemId", itemId);
                        updateItemCommand.ExecuteNonQuery();

                        transaction.Commit(); // Commit transaction
                        MessageBox.Show("Order has been placed successfully", "Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Order not placed yet", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Rollback in case of an error
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public DataTable getProduct(string productId)
        {
            DataTable productDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT productName FROM Product WHERE productId = @productId", connection);

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
        public DataTable getItem(string itemId)
        {
            DataTable itemDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT itemName,Quantity,unitprice FROM Item WHERE itemId = @itemId", connection);

                command.Parameters.AddWithValue("@itemId",itemId);

                SqlDataReader reader = command.ExecuteReader();

                itemDetails.Load(reader);
            }
            
            return itemDetails;
        }
        public DataTable viewStock(string stockId)
        {
            DataTable stockDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT stockName FROM Stock WHERE stockId = @stockId", connection);

                command.Parameters.AddWithValue("@stockId",stockId);

                SqlDataReader reader = command.ExecuteReader();

                stockDetails.Load(reader);
            }

            return stockDetails;
        }
        public DataTable viewOrder(string orderId)
        {
            DataTable orderDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM CustomerOrder WHERE orderId = @orderId", connection);

                command.Parameters.AddWithValue("@orderId", orderId);

                SqlDataReader reader = command.ExecuteReader();

                orderDetails.Load(reader);
            }

            return orderDetails;
        }
        public void approvePurchaseOrder(string orderId,string status)
        {

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE CustomerOrder SET status = @status WHERE orderId = @orderId", connection);

                command.Parameters.AddWithValue("@orderId", orderId);
                command.Parameters.AddWithValue("@status", status);
                

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Approval has been given for the Order {orderId}", "Approval Order Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Approval cannot be granted.An error occurred", "Invalid Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
