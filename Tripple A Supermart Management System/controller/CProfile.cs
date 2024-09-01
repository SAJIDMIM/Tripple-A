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


}
