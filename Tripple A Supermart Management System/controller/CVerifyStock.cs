using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CVerifyStock
    {
        public void VerifyStock(string stockId, string stockDescription, int quantity, string street, string city, int postalCode, DateTime auditDate, DateTime lastAuditDate, string comment)
        {
            //calling the method
            MVerifyStock verifyStock = new MVerifyStock();
            verifyStock.VerifyStock(stockId, stockDescription, quantity, street, city, postalCode, auditDate, lastAuditDate, comment);
        }

    }
}
