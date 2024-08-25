using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;//import model package to connect with controller package
using System.Windows.Forms;
using System.Data.SqlClient;
using Tripple_A_Supermart_Management_System.view;




namespace Tripple_A_Supermart_Management_System.controller
{
    public class CAdminLogin
    {
        //calling the method with enum
        private MAdmin login;

        public CAdminLogin()
        {
            login = new MAdmin(); // Initialize the instance of LoginModel
        }

        public Admin Login(string Type, string username, string password)
        {
            // Call the Login method of LoginModel
            return login.Login(Type, username, password);
        }
    }
    }

