using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CStock
    {
        public void setMinimumStock(string stockId, int quantity, DateTime lastUpdatedStock, int reorderLevel)
        {
            // Create an instance of the MMinimumStock model class
            Stock minimumStockModel = new Stock();
            minimumStockModel.setMinimumStock(stockId,quantity, lastUpdatedStock, reorderLevel);



        }
        public DataTable getStockDetails(string stockId)
        {
            // Create an instance of the MMinimumStock model class
            Stock minimumStockModel = new Stock();

            // Call the getStockDetails method from the model and return the result
            return minimumStockModel.getStockDetails(stockId);
        }
        public void setStockPrice(string stockId, double cost, DateTime lastUpdatedDate)
        {
            Stock setStock = new Stock();
            setStock.setStockPrice(stockId, cost, lastUpdatedDate);
        }
        public DataTable getStock(string stockId)
        {
            Stock newCost = new Stock();

            // Call the getStockDetails method from the model and return the result
            return newCost.getStockDetails(stockId);
        }


    }
}


