using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CHealthInsurance
    {
        public void AddHealthInsurance(int healthInsuranceID, string employeeID, string firstName, string lastName, string type, string description, DateTime effectiveDate, DateTime expiryDate, double premiumAmount, double deductibleAmount, string renewalOption)
        {
            HealthInsurance addNew = new HealthInsurance();
            addNew.AddHealthInsurance(healthInsuranceID, employeeID, firstName, lastName, type, description, effectiveDate, expiryDate, premiumAmount, deductibleAmount, renewalOption);

        }
        public DataTable getEmployeeDetails(string employeeId)
        {
            HealthInsurance modelRetire = new HealthInsurance();
            return modelRetire.getEmployeeDetails(employeeId);
        }

    }
}
