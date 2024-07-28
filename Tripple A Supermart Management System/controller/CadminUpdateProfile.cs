using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tripple_A_Supermart_Management_System.model;
namespace Tripple_A_Supermart_Management_System.controller
{
    public class CadminUpdateProfile
    {
        public void UpdateProfile(string adminId,string name, DateTime DoB, string Gender, string email,string username,string password,string Type, byte[] photo)
        {
            MadminUpdateProfile updateProfile = new MadminUpdateProfile();
            updateProfile.UpdateProfile(adminId, name, DoB, Gender, email,username,password,Type,photo);
        }
    }
}
