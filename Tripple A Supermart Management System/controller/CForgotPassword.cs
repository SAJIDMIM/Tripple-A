using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.controller
{
    public class CForgotPassword
    {
        public void ForgotPassword(string username, string password, string confirm_password)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.ForgotPassword(username, password, confirm_password);

        }


    }
}
