using System;
using Tripple_A_Supermart_Management_System.model;

public class EmployeeController
{
    public void addEmployee(string employeeId, string firstName, string lastName, string empType, string position, string department, DateTime dateJoined, float salary, string retirement)
    {
        Employee employee = null;

        switch (empType)
        {
            case "Storekeeper":
                employee = new Storekeeper();
                break;
            case "Cashier":
                employee = new Cashier();
                break;
            case "SalesRepresentative":
                employee = new SalesRepresentative();
                break;
            default:
                throw new System.ArgumentException("Invalid employee type.");
        }

        employee.addEmployee(employeeId, firstName, lastName, empType, position, department, dateJoined, salary, retirement);
    }
}

public class SalesRepresentative : Employee
{
    public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string position, string department, DateTime dateJoined, float salary, string retirement)
    {
        // Implementation for SalesRepresentative
        base.addEmployee(employeeId, firstName, lastName, empType, position, department, dateJoined, salary, retirement);
        // Additional logic for SalesRepresentative
    }
}

public class Cashier : Employee
{
    public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string position, string department, DateTime dateJoined, float salary, string retirement)
    {
        // Implementation for Cashier
        base.addEmployee(employeeId, firstName, lastName, empType, position, department, dateJoined, salary, retirement);
        // Additional logic for Cashier
    }
}

public class Storekeeper : Employee
{
    public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string position, string department, DateTime dateJoined, float salary, string retirement)
    {
        // Implementation for Storekeeper
        base.addEmployee(employeeId, firstName, lastName, empType, position, department, dateJoined, salary, retirement);
        // Additional logic for Storekeeper
    }
}