using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CBillingReminder
    {
        public void sendBillingReminder(string ReminderId, DateTime Date, string Option, string Message, double dueAmount, DateTime NextDate, string Status, string emailNotify)
        {
            BillingReminder newBillReminder = new BillingReminder();
            newBillReminder.sendBillingReminder(ReminderId, Date, Option, Message, dueAmount, NextDate, Status, emailNotify);
        }

    }
}
