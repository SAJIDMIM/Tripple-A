using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CStockPrice
    {
        public void setStockPrice(string stockId, double cost, DateTime lastUpdatedDate)
        {
            MStockPrice setStock = new MStockPrice();
            setStock.setStockPrice(stockId,cost,lastUpdatedDate);
        }
        public DataTable getStockDetails(string stockId)
        {
            MStockPrice newCost = new MStockPrice();

            // Call the getStockDetails method from the model and return the result
            return newCost.getStockDetails(stockId);
        }

    }
}
