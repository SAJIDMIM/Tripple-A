using System;
using System.Data;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CStock
    {
        
        

        public void setMinimumStock(string stockId, int quantity, DateTime lastUpdatedStock, int reorderLevel)
        {
            // Create an instance of the MMinimumStock model class
            Stock minimumStockModel = new Stock();
            minimumStockModel.setMinimumStock(stockId, quantity, lastUpdatedStock, reorderLevel);



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
        public void placeStockOrder(string stockId, string stockName, string stockType, int stockQuantity, string Location, double cost, DateTime stockDate, string supplierName)
        {
            Stock placeStock = new Stock();
            placeStock.placeStockOrder(stockId, stockName, stockType, stockQuantity, Location, cost, stockDate, supplierName);
        }
        public DataTable getStockCost(string stockId)
        {
            Stock newCost = new Stock();
            return newCost.getStockCost(stockId);



        }
        public void addStock(string stockId, string stockName, string stockType, int stockQuantity, string stockWeight, string location, double cost, string supplierName, int reorderLevel, DateTime stockDate, DateTime lastUpdatedDate, string stockDescription)
        {
            Stock addStock = new Stock();
            addStock.addStock(stockId, stockName, stockType, stockQuantity, stockWeight, location, cost, supplierName, reorderLevel, stockDate, lastUpdatedDate, stockDescription);
        }
        public void updateStock(string stockId, string stockName, string stockType,string stockWeight, string location,string supplierName,DateTime stockDate,string stockDescription)
        {
            Stock updateStock = new Stock();
            updateStock.updateStock(stockId, stockName, stockType,stockWeight, location,supplierName, stockDate, stockDescription);
        }
        public void deleteStock(string stockId)
        {
            Stock deleteStock = new Stock();
            deleteStock.deleteStock(stockId);


        }
        public DataTable viewStock(string stockId)
        {
            Stock newStock = new Stock();


            return newStock.viewStock(stockId);
        }



    }
}


