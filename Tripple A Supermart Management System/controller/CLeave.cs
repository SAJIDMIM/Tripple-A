using System;
using System.Collections.Generic;
using System.Data;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CLeave
    {
        private Leave _mLeave;

        public CLeave()
        {
            _mLeave = new Leave();
        }

        public int getleaveRequest()
        {
            // Use the instance field _mLeave instead of creating a new instance
            return _mLeave.GetNextLeaveRequestId();
        }



        public void addLeaveRequest(string employeeId, string userType, string firstName, string lastName, string leaveType, string reason, DateTime leaveStartDate, DateTime leaveEndDate)
        {
            _mLeave.addLeaveRequest(employeeId, userType, firstName, lastName, leaveType, reason, leaveStartDate, leaveEndDate);
        }


        public DataTable viewLeaveRequest(int leaveRequestId)
        {
            Leave modelLeave = new Leave();
            return modelLeave.viewLeaveRequest(leaveRequestId); // Pass the userId to the model method
        }

        public List<Employees> GetEmployeesByUserType(string userType)
        {
            return _mLeave.GetEmployeesByUserType(userType);
        }

        internal void addEmployee(int employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            throw new NotImplementedException();
        }

        internal Employee displayEmployee(string employeeId)
        {
            throw new NotImplementedException();
        }


    }

}
