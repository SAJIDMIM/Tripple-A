using System;
using Tripple_A_Supermart_Management_System.model;
using System.Drawing;
using System.Data;

public class CProfile
{




    private Profile profile = new Profile();

    public void updateProfile(int adminId, string firstName, string lastName, string gender, string email, DateTime doB, Image adminPhoto)
    {
        profile.updateProfile(adminId, firstName, lastName, gender, email, doB, adminPhoto);
    }
    public DataTable getAdminDetails(int adminId)
    {
        Profile adminDetails = new Profile();
        return adminDetails.getAdminDetails(adminId);
    }


  
}
