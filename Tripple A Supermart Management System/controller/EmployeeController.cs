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
            Employee employee = new Employee();
            employee.addEmployee(employeeId, firstName, lastName, empType, actorId, position, department, dateJoined, salary, retirement);
        }


    }
}
