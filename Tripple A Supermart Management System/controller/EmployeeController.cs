using System;
using System.Data;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class EmployeeController
    {
        public DateTime DateJoined { get; internal set; }

        public void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
    {
        MEmployee employee = new MEmployee();
        employee.addEmployee(employeeId, firstName, lastName, empType, actorId, position, department, dateJoined, salary, retirement);
    }

    public MEmployee LoadEmployeeData(string employeeId)
    {
            MEmployee employee = new MEmployee();
            try
            {
                employee = employee.LoadEmployeeData(employeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return employee;
        }



    }
   
}
