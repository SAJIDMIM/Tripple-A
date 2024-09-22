using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CCustomerOrder
    {
        public void placeOrder(string orderId, string mobile, string customerName, string productId, string productName, string itemId, string itemName, int quantity, double unitPrice, double discount, double tax, double totalPrice, string paymentMethod, DateTime payDate, string status,string stockId,string stockName)
        {
            CustomerOrder newOrder = new CustomerOrder();
            newOrder.placeOrder(orderId, mobile, customerName, productId, productName, itemId, itemName, quantity, unitPrice, discount, tax, totalPrice, paymentMethod, payDate, status,stockId,stockName);
        }
        public DataTable getProduct(string productId)
        {
            CustomerOrder productModel = new CustomerOrder();

            return productModel.getProduct(productId);
        }
        public DataTable viewCustomer(string mobile)
        {
            CustomerOrder customerModel = new CustomerOrder();

            return customerModel.viewCustomer(mobile);
        }
        public DataTable getItem(string itemId)
        {
            CustomerOrder itemModel = new CustomerOrder();

            return itemModel.getItem(itemId);
        }
        public DataTable viewStock(string stockId)
        {
            CustomerOrder stockModel = new CustomerOrder();

            return stockModel.viewStock(stockId);
        }

    }
}
