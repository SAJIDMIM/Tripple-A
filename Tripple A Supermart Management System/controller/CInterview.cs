using System;
using System.Data;
using Tripple_A_Supermart_Management_System.model;


namespace Tripple_A_Supermart_Management_System.controller

{
    class CInterview
    {
        public void scheduleInterview(string employeeId, string firstName, string lastName, DateTime Date,DateTime endDate, string Location, string Type, string Status, string scheduleEmail)
        {
            Interview newInterview = new Interview();
            newInterview.scheduleInterview(employeeId, firstName, lastName, Date,endDate, Location, Type, Status, scheduleEmail);
        }
        public DataTable viewEmployee(string employeeId)
        {
            Employee modelEmployee = new Employee();
            return modelEmployee.viewEmployee(employeeId);
        }
        public DataTable viewInterview(int InterviewID)
        {
            Interview modelInterview = new Interview();
            return modelInterview.viewInterview(InterviewID); 
        }

    }
}
