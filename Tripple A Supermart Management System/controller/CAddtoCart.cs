using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CAddtoCart
    {
        public DataTable viewOrder(string orderId)
        {
            AddtoCart orderModel = new AddtoCart();

            return orderModel.viewOrder(orderId);
        }
        public void addtoCart(string customerName, string productName, string itemName, int quantity, double unitPrice, double discount, double tax, double totalPrice, DateTime payDate, string paymentMethod, string stockName, string orderId)
        {
            AddtoCart newCart = new AddtoCart();
            newCart.addtoCart(customerName, productName, itemName, quantity, unitPrice, discount, tax, totalPrice, payDate, paymentMethod, stockName, orderId);

        }
        public DataTable GetReceiptData(string orderId)
        {
            AddtoCart orderModel = new AddtoCart();

            return orderModel.GetReceiptData(orderId);
        }







    }
}
