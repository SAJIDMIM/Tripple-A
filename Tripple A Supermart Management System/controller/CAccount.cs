using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    class CAccount
    {

        public DataTable viewAccount(int userId)
        {
            Account modelAccount = new Account();
            return modelAccount.viewAccount(userId); // Pass the userId to the model method
        }


    }
}
