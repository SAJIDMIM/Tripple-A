using System;
using System.Data;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CHealthInsurance
    {
        public void AddHealthInsurance(string employeeID, string firstName, string lastName, string type, string description, DateTime effectiveDate, DateTime expiryDate, double premiumAmount, double deductibleAmount, string renewalOption)
        {
            HealthInsurance addNew = new HealthInsurance();
            addNew.AddHealthInsurance(employeeID, firstName, lastName, type, description, effectiveDate, expiryDate, premiumAmount, deductibleAmount, renewalOption);

        }
        public DataTable getEmployeeDetails(string employeeId)
        {
            HealthInsurance modelRetire = new HealthInsurance();
            return modelRetire.getEmployeeDetails(employeeId);
        }
        public DataTable viewHealthInsurance(int HealthInsuranceId)
        {
            HealthInsurance modelHealth = new HealthInsurance();
            return modelHealth.viewHealthInsurance(HealthInsuranceId);
        }

    }
}
