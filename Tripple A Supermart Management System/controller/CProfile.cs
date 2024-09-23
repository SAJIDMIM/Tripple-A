using System;
using System.Data;

public class CProfile
{

    private Profile profile = new Profile();

    public void updateProfile(int adminId, string firstName, string lastName, string gender, string email, DateTime doB)
    {
        profile.updateProfile(adminId, firstName, lastName, gender, email, doB);
    }
    public DataTable getAdminDetails(int adminId)
    {
        Profile adminDetails = new Profile();
        return adminDetails.getAdminDetails(adminId);
    }
    public void updateUserProfile(string firstName, string lastName, string Gender, DateTime doB, string email,string userType, Byte[] userPhoto)
    {
        profile.updateUserProfile(firstName, lastName, Gender, doB,email,userType, userPhoto);
    }
    public DataTable getUserDetails(int userId)
    {
        Profile userDetails = new Profile();
        return userDetails.getUserDetails(userId);
    }



}
