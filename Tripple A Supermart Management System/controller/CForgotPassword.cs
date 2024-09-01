using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tripple_A_Supermart_Management_System.model;
using Tripple_A_Supermart_Management_System.view;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CForgotPassword
    {
        public void ForgotPassword(string username,string password, string confirm_password)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.ForgotPassword(username,password, confirm_password);
            
        }


    }
}
