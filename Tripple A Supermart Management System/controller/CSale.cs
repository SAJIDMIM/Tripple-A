using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void promoteSale(int saleId,DateTime saleStartDate, DateTime saleEndDate, double price, double discount)
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


    }
}