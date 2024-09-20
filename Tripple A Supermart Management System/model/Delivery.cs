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
    class Delivery
    {
        private string deliverId;
        private string deliveryName;
        private string contactNumber;
        private string deliveryAddress;
        private string deliveryType;
        private string availableStatus;

        public string DeliverId { get { return deliverId; } set { deliverId = value; } }
        public string DeliveryName { get { return deliveryName; } set { deliveryName = value; } }
        public string ContactNumber { get { return contactNumber; } set { contactNumber = value; } }
        public string DeliveryAddress { get { return deliveryAddress; } set { deliveryAddress = value; } }
        public string DeliveryType { get { return deliveryType; } set { deliveryType = value; } }
        public string AvailableStatus { get { return availableStatus; } set { availableStatus = value; } }

        public void addDelivery(string DeliveryId, string deliveryName, string contactNumber, string deliveryAddress, string deliveryType, string availableStatus)
        {
            

            // Assuming you have a SqlConnection object named 'connection'
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Delivery (DeliverId, deliveryName, contactNumber, deliveryAddress, deliveryType, availableStatus) VALUES (@DeliverId, @deliveryName, @contactNumber, @deliveryAddress, @deliveryType, @availableStatus)", connection);

                command.Parameters.AddWithValue("@DeliverId",DeliveryId);
                command.Parameters.AddWithValue("@deliveryName", deliveryName);
                command.Parameters.AddWithValue("@contactNumber", contactNumber);
                command.Parameters.AddWithValue("@deliveryAddress", deliveryAddress);
                command.Parameters.AddWithValue("@deliveryType", deliveryType);
                command.Parameters.AddWithValue("@availableStatus", availableStatus);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Delivery has been added successfully", "Delivery Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delivery Details has not been saved.An error occurred", "Invalid Delivery", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }
        public void updateDelivery(string DeliveryId, string deliveryName, string contactNumber, string deliveryAddress, string deliveryType, string availableStatus)
        {
            DeliverId = DeliveryId;
            DeliveryName = deliveryName;
            ContactNumber = contactNumber;
            DeliveryAddress = deliveryAddress;
            DeliveryType = deliveryType;
            AvailableStatus = availableStatus;

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE Delivery SET deliveryName = @deliveryName, contactNumber = @contactNumber, deliveryAddress = @deliveryAddress, deliveryType = @deliveryType, availableStatus = @availableStatus WHERE DeliverId = @DeliverId", connection);

                command.Parameters.AddWithValue("@DeliverId", DeliveryId);
                command.Parameters.AddWithValue("@deliveryName", deliveryName);
                command.Parameters.AddWithValue("@contactNumber", contactNumber);
                command.Parameters.AddWithValue("@deliveryAddress", deliveryAddress);
                command.Parameters.AddWithValue("@deliveryType", deliveryType);
                command.Parameters.AddWithValue("@availableStatus", availableStatus);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Delivery has been updated successfully", "Delivery Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delivery Details has not been updated.An error occurred", "Invalid Delivery", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void deleteDelivery(string DeliveryId)
        {
            DeliverId = DeliveryId;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this delivery?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = MDBConnection.createConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Delivery WHERE DeliverId = @DeliverId", connection);

                    command.Parameters.AddWithValue("@DeliverId", DeliveryId);

                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Delivery has been deleted successfully", "Delivery Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delivery Details has not been deleted.An error occurred", "Invalid Delivery", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Delete operation cancelled", "Delete Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public DataTable searchDelivery(string DeliveryId)
        {
            DataTable deliveryDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Delivery WHERE DeliverId = @DeliverId", connection);

                command.Parameters.AddWithValue("@DeliverId", DeliveryId);

                SqlDataReader reader = command.ExecuteReader();

                deliveryDetails.Load(reader);
            }

            return deliveryDetails;
        }

    }
    }

