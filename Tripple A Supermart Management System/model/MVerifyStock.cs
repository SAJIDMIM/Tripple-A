using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
   public  class MVerifyStock
    {
        public void VerifyStock(string stockId, string stockDescription, int quantity, string street, string city, int postalCode, DateTime auditDate, DateTime lastAuditDate, string comment)
        {
            //apply database logic here
            string query = "insert into VerifyStock (stock_Id, stockDescription, Quantity, Street, City, PostalCode, AuditDate, LastAuditDate, Comment) " +
                           "values (@StockId, @StockDescription, @Quantity, @Street, @City, @PostalCode, @AuditDate, @LastAuditDate, @Comment)";

            using (SqlConnection con = MDBConnection.createConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StockId", stockId);
                    cmd.Parameters.AddWithValue("@StockDescription", stockDescription);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Street", street);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                    cmd.Parameters.AddWithValue("@AuditDate", auditDate);
                    cmd.Parameters.AddWithValue("@LastAuditDate", lastAuditDate);
                    cmd.Parameters.AddWithValue("@Comment", comment);

                    con.Open();
                    int count = cmd.ExecuteNonQuery();
                    if(count > 0)
                    {
                        MessageBox.Show("Sucessfully Verified the Stocks","Stock Verified",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Stock was not Verified Yet.Please check it again and verify", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();
                }
            }
            
        }

    }
}
