using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CCreateAccount
    {
        public void createAccount(string user_type,string username,string email,string password,string confirm_password)
        {
            MCreateAccount Account = new MCreateAccount();
            Account.createAccount(user_type,username,email,password,confirm_password);

            
        }
    }
}
