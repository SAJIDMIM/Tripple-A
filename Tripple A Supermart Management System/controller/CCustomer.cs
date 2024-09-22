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
        public void addCustomer(string customerId, string customerName, DateTime DoB, string Gender, string Email, string City, string Street, int PostalCode, string mobile, string Type)
        {
            Customer addNew = new Customer();
            addNew.addCustomer(customerId, customerName, DoB, Gender, Email, City, Street, PostalCode, mobile, Type);

        }
        public void editCustomer(string customerId, string customerName, DateTime DoB, string Gender, string Email, string City, string Street, int PostalCode, string mobile, string Type)
        {
            Customer editNew = new Customer();
            editNew.editCustomer(customerId, customerName, DoB, Gender, Email, City, Street, PostalCode, mobile, Type);

        }
        public void removeCustomer(string mobile)
        {
            Customer removeNew = new Customer();
            removeNew.removeCustomer(mobile);

        }
        public DataTable viewCustomers(string mobile)
        {
            Customer viewCustomer = new Customer();
            return viewCustomer.viewCustomers(mobile);
        }


    }
}
