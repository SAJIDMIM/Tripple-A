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
        public DataTable viewProduct(string productId)
        {
            DataTable productDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Product WHERE productId = @productId";

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
    }
}
