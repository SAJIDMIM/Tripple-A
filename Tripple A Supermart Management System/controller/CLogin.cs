using Tripple_A_Supermart_Management_System.model;


namespace Tripple_A_Supermart_Management_System.controller
{
    public class CLogin
    {
        private model.MLogin login;
        public CLogin()
        {
            login = new model.MLogin(); // Initialize the instance of LoginModel
        }

        public Users Login(string usertype, string username, string password)
        {
            // Call the Login method of LoginModel
            return login.Login(usertype, username, password);
        }
    }
}
