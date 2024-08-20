using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CMinimumStock
    {
        public void setMinimumStock(string stockId,int quantity,DateTime lastUpdatedStock, int reorderLevel)
        {
            // Create an instance of the MMinimumStock model class
            MMinimumStock minimumStockModel = new MMinimumStock();
            minimumStockModel.setMinimumStock(stockId,quantity,lastUpdatedStock,reorderLevel);

            
            
        }
        public DataTable getStockDetails(string stockId)
        {
            // Create an instance of the MMinimumStock model class
            MMinimumStock minimumStockModel = new MMinimumStock();

            // Call the getStockDetails method from the model and return the result
            return minimumStockModel.getStockDetails(stockId);
        }

        
    }
}
