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
        public void sendCustomerService(string mobile, string customerName, string Type, DateTime responseTime, string feedback)
        {
            CustomerService newCustomerService = new CustomerService();
            newCustomerService.sendCustomerService(mobile, customerName, Type, responseTime, feedback);
        }
        public DataTable getCustomerDetails(string mobile)
        {
            CustomerService viewCustomerDetails = new CustomerService();
            return viewCustomerDetails.getCustomerDetails(mobile);
        }
    }
}
