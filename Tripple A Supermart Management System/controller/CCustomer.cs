using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CCustomer
    {
        public DataTable viewNormalCustomer(string mobile,string Type)
        {
            model.Customer viewNormal = new model.Customer();
            return viewNormal.viewNormalCustomer(mobile,Type);
        }
        public DataTable viewLoyaltyCustomer(string mobile, string Type)
        {
            model.Customer viewLoyalty = new model.Customer();
            return viewLoyalty.viewLoyaltyCustomer(mobile, Type);
        }
    }
}
