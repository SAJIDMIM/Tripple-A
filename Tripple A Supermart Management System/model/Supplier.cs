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
    class Supplier
    {
        private string supplierId;
        private string supplierName;
        private string mobile;
        private string company;
        private string productType;
        private DateTime deliverySchedule;
        private string payTerm;
        private string comment;

        public string SupplierId { get { return supplierId; } set { supplierId = value; } }
        public string SupplierName { get { return supplierName; } set { supplierName = value; } }
        public string Mobile { get { return mobile; } set { mobile = value; } }
        public string Company { get { return company; } set { company = value; } }
        public string ProductType { get { return productType; } set { productType = value; } }
        public DateTime DeliverySchedule { get { return deliverySchedule; } set { deliverySchedule = value; } }
        public string PayTerm { get { return payTerm; } set { payTerm = value; } }
        public string Comment { get { return comment; } set { comment = value; } }

        public DataTable viewSuppliers(string supplierId)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {


                string query_select = "select * from Supplier where supplierId = @supplierId";
                using (SqlCommand cmd = new SqlCommand(query_select, con))
                {
                    cmd.Parameters.AddWithValue("@supplierId",supplierId);                    
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
        public void addSupplierDetails(string supplierId, string supplierName, string mobile, string company, string productType, DateTime deliverySchedule, string payTerm, string comment)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
            Mobile = mobile;
            Company = company;
            ProductType = productType;
            DeliverySchedule = deliverySchedule;
            PayTerm = payTerm;
            Comment = comment;

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Supplier (supplierId, supplierName, mobile, company, productType, deliverySchedule, payTerm, comment) VALUES (@supplierId, @supplierName, @mobile, @company, @productType, @deliverySchedule, @payTerm, @comment)", connection);

                command.Parameters.AddWithValue("@supplierId", supplierId);
                command.Parameters.AddWithValue("@supplierName", supplierName);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@company", company);
                command.Parameters.AddWithValue("@productType", productType);
                command.Parameters.AddWithValue("@deliverySchedule", deliverySchedule);
                command.Parameters.AddWithValue("@payTerm", payTerm);
                command.Parameters.AddWithValue("@comment", comment);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Supplier has been added successfully", "Supplier Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Supplier Details has not been saved.An error occurred", "Invalid Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void updateSupplierDetails(string supplierId, string supplierName, string mobile, string company, string productType, DateTime deliverySchedule, string payTerm, string comment)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
            Mobile = mobile;
            Company = company;
            ProductType = productType;
            DeliverySchedule = deliverySchedule;
            PayTerm = payTerm;
            Comment = comment;

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE Supplier SET supplierName = @supplierName, mobile = @mobile, company = @company, productType = @productType, deliverySchedule = @deliverySchedule, payTerm = @payTerm, comment = @comment WHERE supplierId = @supplierId", connection);

                command.Parameters.AddWithValue("@supplierId", supplierId);
                command.Parameters.AddWithValue("@supplierName", supplierName);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@company", company);
                command.Parameters.AddWithValue("@productType", productType);
                command.Parameters.AddWithValue("@deliverySchedule", deliverySchedule);
                command.Parameters.AddWithValue("@payTerm", payTerm);
                command.Parameters.AddWithValue("@comment", comment);

                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Supplier has been updated successfully", "Supplier Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Supplier Details has not been updated.An error occurred", "Invalid Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void deleteSupplierDetails(string supplierId)
        {
            SupplierId = supplierId;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection connection = MDBConnection.createConnection())
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Supplier WHERE supplierId = @supplierId", connection);

                    command.Parameters.AddWithValue("@supplierId", supplierId);

                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Supplier has been deleted successfully", "Supplier Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Supplier Details has not been deleted.An error occurred", "Invalid Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Delete operation cancelled", "Delete Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable viewSupplier(string supplierId)
        {
            DataTable supplierDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Supplier WHERE supplierId = @supplierId", connection);

                command.Parameters.AddWithValue("@supplierId", supplierId);

                SqlDataReader reader = command.ExecuteReader();

                supplierDetails.Load(reader);
            }

            return supplierDetails;
        }
    }

}

