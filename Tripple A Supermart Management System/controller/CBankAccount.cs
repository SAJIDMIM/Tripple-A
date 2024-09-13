using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CBankAccount
    {
        public void addBankAccount(string accountNumber, string accountType, double salary, string employeeId, string employeeName, string bankName, string branch, DateTime openingDate, string accountStatus)
        {
            BankAccount newBank = new BankAccount();
            newBank.addBankAccount(accountNumber, accountType, salary, employeeId, employeeName, bankName, branch, openingDate, accountStatus);
        }
        public DataTable getEmployeeDetails(string employeeId)
        {
            BankAccount newBank = new BankAccount();
            return newBank.getEmployeeDetails(employeeId);
        }

    }
}
