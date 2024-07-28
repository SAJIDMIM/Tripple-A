using System;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CRetirementPlan
    {
        public void RetireEmployee(string retirementId, string employeeId, string employeeFirstName, string employeeLastName, string position, string retireType, DateTime dateJoined, DateTime expectedDate, string contribution)
        {
            if (string.IsNullOrEmpty(retirementId) || string.IsNullOrEmpty(employeeId) || string.IsNullOrEmpty(employeeFirstName) || string.IsNullOrEmpty(employeeLastName) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(retireType) || string.IsNullOrEmpty(contribution))
            {
                MessageBox.Show("All fields must be filled out", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MRetirementPlan newRetire = new MRetirementPlan
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

            newRetire.RetireEmployee(); // Call the RetireEmployee method to insert data into the database
        }
    }
}

