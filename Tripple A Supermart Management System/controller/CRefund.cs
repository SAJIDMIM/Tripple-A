using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CRefund
    {
        public void processRefund(string refundId, string mobile, string customerName, string productId, string productName, DateTime refundDate, string type, double refundAmount, double originalPrice, string reason, string itemCondition)
        {
            Refund newFund = new Refund();
            newFund.processRefund(refundId, mobile, customerName, productId, productName, refundDate, type, refundAmount, originalPrice, reason, itemCondition);
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

    }
}
