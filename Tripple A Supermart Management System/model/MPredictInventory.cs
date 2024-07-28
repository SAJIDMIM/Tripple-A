using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    public class MPredictInventory
    {
        public void ForecastInventory(string predictInventory,string stockId,int Quantity,string sale,string demandInventory,bool Reorder,DateTime LeadTime,string SafetyStock,double cost)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();

                // SQL query to insert the cost based on stock ID and quantity
                string query = "insert into PredictInventory (inventoryForecastId,stockId,Quantity,Sale,demandInventory,Reorder,LeadTime,SafetyStock,cost) values (@InventoryId, @stockId, @Quantity,@Sale,@demand,@Reorder,@leadTime,@SafetyStock,@cost)";

                // Create command object
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@InventoryId", predictInventory);
                    cmd.Parameters.AddWithValue("@stockId", stockId);
                    cmd.Parameters.AddWithValue(" @Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@Sale", sale);
                    cmd.Parameters.AddWithValue("@demand",demandInventory);
                    cmd.Parameters.AddWithValue("@Reorder",Reorder);
                    cmd.Parameters.AddWithValue("@leadTime", LeadTime);
                    cmd.Parameters.AddWithValue("@SafetyStock", SafetyStock);
                    cmd.Parameters.AddWithValue("@cost", cost);
                    // Execute the command
                    int count = cmd.ExecuteNonQuery();
                    if(count> 0)
                    {
                        MessageBox.Show("Successfully Predicted Inventory", "Predicted Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Predicted was not Completed Yet.Please try again later", "Predicted Inventory Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();
                }
            }
        }
    }
}
