using System;
using System.Collections.Generic;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CEmployee
    {
        private MLeave _mLeave;

        public CEmployee()
        {
            _mLeave = new MLeave();
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

       

        public List<Employees> GetEmployeesByUserType(string userType)
        {
            return _mLeave.GetEmployeesByUserType(userType);
        }

        internal void addEmployee(int employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            throw new NotImplementedException();
        }

        internal MEmployee displayEmployee(string employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
