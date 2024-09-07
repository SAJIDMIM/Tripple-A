using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_A_Supermart_Management_System.model
{
    class Supplier
    {
        private string supplierId { get; set; }
        private string supplierName { get; set; }
        private string mobile { get; set; }
        private string Company { get; set; }
        private string productType { get; set; }
        private DateTime deliverySchedule { get; set; }
        private string payTerm { get; set; }
        private string comment { get; set; }

        public DataTable viewSupplier(string supplierId)
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
    }
}
