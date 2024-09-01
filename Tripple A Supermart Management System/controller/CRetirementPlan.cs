using System;
using System.Data;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CRetirementPlan
    {
        public void addretireEmployee(string retirementId, string employeeId, string employeeFirstName, string employeeLastName, string position, string retireType, DateTime dateJoined, DateTime expectedDate, string contribution)
        {
            if (string.IsNullOrEmpty(retirementId) || string.IsNullOrEmpty(employeeId) || string.IsNullOrEmpty(employeeFirstName) || string.IsNullOrEmpty(employeeLastName) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(retireType) || string.IsNullOrEmpty(contribution))
            {
                MessageBox.Show("All fields must be filled out", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RetirementPlan newRetire = new RetirementPlan
            {
                RetirementId = retirementId,
                EmployeeId = employeeId,
                EmployeeFirstName = employeeFirstName,
                EmployeeLastName = employeeLastName,
                Position = position,
                RetireType = retireType,
                DateJoined = dateJoined,
                ExpectedDate = expectedDate,
                Contribution = contribution
            };

            newRetire.addretireEmployee(); 
        }
        public DataTable viewretirementPlan(string retirementId)
        {
            RetirementPlan modelRetire = new RetirementPlan();
            return modelRetire.viewretirementPlan(retirementId); 
        }

    }
}

