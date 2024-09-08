using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;
namespace Tripple_A_Supermart_Management_System.controller
{
    class CCustomerService
    {
        public void sendCustomerService(string customerId, string customerName, string Type, DateTime responseTime, string feedback, string mobile)
        {
            CustomerService newCustomerService = new CustomerService();
            newCustomerService.sendCustomerService(customerId, customerName, Type, responseTime, feedback, mobile);
        }
        public DataTable getCustomerDetails(string mobile)
        {
            CustomerService viewCustomerDetails = new CustomerService();
            return viewCustomerDetails.getCustomerDetails(mobile);
        }
    }
}
