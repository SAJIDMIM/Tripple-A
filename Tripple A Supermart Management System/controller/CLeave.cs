using System;
using System.Collections.Generic;
using System.Data;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CLeave
    { 

        public void addLeaveRequest(string employeeId, string userType, string firstName, string lastName, string leaveType, string reason, DateTime leaveStartDate, DateTime leaveEndDate)
        {
            Leave newLeave = new Leave();
            newLeave.addLeaveRequest(employeeId, userType, firstName, lastName, leaveType, reason, leaveStartDate, leaveEndDate);
        }


        public DataTable getLeave(int leaveRequestedId)
        {
            Leave modelLeave = new Leave();
            return modelLeave.getLeave(leaveRequestedId);
        }
        public DataTable getEmployee(string employeeId)
        {
            Leave modelEmp = new Leave();
            return modelEmp.getEmployee(employeeId);
        }





    }

}
