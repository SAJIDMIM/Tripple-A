using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;
using Tripple_A_Supermart_Management_System.view;


namespace Tripple_A_Supermart_Management_System.controller
{
    public class CLogin
    {
        private model.Login login;
        public CLogin()
        {
            login = new model.Login(); // Initialize the instance of LoginModel
        }
        
        public Users Login(string usertype,string username, string password)
        {
            // Call the Login method of LoginModel
            return login.Login(usertype,username, password);
        }
    }
}
