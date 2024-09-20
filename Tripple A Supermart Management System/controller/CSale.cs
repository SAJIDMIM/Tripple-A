using System;
using System.Data;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CSale
    {
        public DataTable analyzeSale()
        {
            Tripple_A_Supermart_Management_System.model.Sale modelSale = new Tripple_A_Supermart_Management_System.model.Sale();

            // Call the model's analyzeSale method to get the sale data
            return modelSale.analyzeSale();
        }
        public void promoteSale(int saleId, DateTime saleStartDate, DateTime saleEndDate, double price, double discount)
        {
            // Create an instance of the model Sale class
            Tripple_A_Supermart_Management_System.model.Sale modelSale = new Tripple_A_Supermart_Management_System.model.Sale();

            // Call the promoteSale method from the model class and pass the saleId
            modelSale.promoteSale(saleId, saleStartDate, saleEndDate, price, discount);
        }
        public DataTable getSaleDetails(int saleId)
        {
            Tripple_A_Supermart_Management_System.model.Sale modelSale = new Tripple_A_Supermart_Management_System.model.Sale();

            // Call the model's getSaleDetails method to get the sale data
            return modelSale.getSaleDetails(saleId);
        }
        public void createSale(string productId, string productName, double price, int quantity, DateTime saleDate, DateTime saleEndDate, double priceCalculate, double discount, string payMethod, string customerId, string customerName)
        {
            Sale newSale = new Sale();
            newSale.createSale(productId, productName, price, quantity, saleDate, saleEndDate, priceCalculate, discount, payMethod, customerId, customerName);
        }
        public DataTable getProduct(string productId)
        {
            Sale productModel = new Sale();

            return productModel.getProduct(productId);
        }
        public DataTable viewCustomer(string mobile)
        {
            Sale customerModel = new Sale();

            return customerModel.viewCustomer(mobile);
        }
        public DataTable viewSale(string saleId)
        {
            Sale saleModel = new Sale();

            return saleModel.viewSale(saleId);
        }



    }
}