using System;
using System.Data;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class EmployeeController
    {
        public DateTime DateJoined { get; internal set; }

        public void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, double salary, string retirement)
        {
            Employee employee = new Employee();
            employee.addEmployee(employeeId, firstName, lastName, empType, actorId, position, department, dateJoined, salary, retirement);
        }
        public  void editEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, double salary, string retirement)
        {
            Employee updateEmployee = new Employee();
            updateEmployee.editEmployee(employeeId, firstName, lastName, empType,actorId,position, department, dateJoined, salary, retirement);
        }
        public  void deleteEmployee(string employeeId)
        {
            Employee deleteEmployee = new Employee();
            deleteEmployee.deleteEmployee(employeeId);
        }
        public DataTable viewEmployee(string employeeId)
        {
            Employee modelEmployee = new Employee();
            return modelEmployee.viewEmployee(employeeId);
        }



    }
}
