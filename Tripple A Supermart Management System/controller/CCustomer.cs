using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CCustomer
    {
        public DataTable viewNormalCustomer(string mobile,string Type)
        {
            Customer viewNormal = new Customer();
            return viewNormal.viewCustomer(mobile, Type);
        }
        public DataTable viewLoyaltyCustomer(string mobile, string Type)
        {
            Customer viewLoyalty = new Customer();
            return viewLoyalty.viewCustomer(mobile, Type);
        }
    }
}
