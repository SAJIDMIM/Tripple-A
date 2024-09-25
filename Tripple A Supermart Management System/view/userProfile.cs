using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class userProfile : Form
    {
        public userProfile()
        {
            InitializeComponent();
        }

        private void btn_Save_User_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txt_userId.Text);
            string firstName = txtfirstName.Text;
            string lastName = txtlastName.Text;
            DateTime doB = dtpDoB.Value;
            string gender;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string email = txtEmail.Text;
            string userType = cmbUserType.SelectedItem.ToString();
            Byte[] userPhoto = null;

            if (picAdminProfile.Image != null)
            {
                // Convert the Image object to a byte[] array
                MemoryStream ms = new MemoryStream();
                picAdminProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                userPhoto = ms.ToArray();
            }

            CProfile newProfile2 = new CProfile();
           // newProfile2.updateUserProfile(firstName, lastName, gender, doB, userType, userPhoto);

            // Load the updated profile details for users only
            // When the ordinary users logs in
            Profile profile = new Profile
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                DoB = doB,
                Gender = gender,
                Email = email,
                userType = userType,
                //AdminPhoto = adminPhotoBytes
            };
            SessionManager.SetSession("Login", profile);
        }

        private void picAdminProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAdminProfile.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_userId_TextChanged(object sender, EventArgs e)
        {

            if (txt_userId.Text.Length > 0)
            {
                int userId = Convert.ToInt32(txt_userId.Text);

                if (userId == 9)
                {
                    MessageBox.Show("You are not authorized to use this ID. Please enter your own ID.", "Unauthorized Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_userId.Clear();
                    txt_userId.Focus();
                    return;
                }

                CProfile userDetailsof = new CProfile();
                DataTable userDetails = userDetailsof.getUserDetails(userId);

                if (userDetails.Rows.Count > 0)
                {
                    DataRow row = userDetails.Rows[0];

                    // Update the fields with the retrieved data
                    userId = Convert.ToInt32(row["userId"]);
                    string firstName = row["firstName"].ToString();
                    string lastName = row["lastName"].ToString();
                    DateTime doB = Convert.ToDateTime(row["doB"]);
                    string gender = row["gender"].ToString();
                    string email = row["email"].ToString();
                    string userType = row["userType"].ToString();
                    byte[] userPhoto = (byte[])row["userPhoto"];

                    // Load the admin photo
                    if (userPhoto != null)
                    {
                        try
                        {
                            MemoryStream ms = new MemoryStream(userPhoto);
                            picAdminProfile.Image = Image.FromStream(ms);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading user photo: " + ex.Message);
                        }
                    }

                    // Update the UI fields
                    txtfirstName.Text = firstName;
                    txtlastName.Text = lastName;
                    dtpDoB.Value = doB;
                    txtEmail.Text = email;

                    // Set the gender radio button based on the retrieved value
                    if (gender == "Male")
                    {
                        rbMale.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        rbFemale.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("No user found with the provided admin ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear or reset the fields if no stock is found
                    txtfirstName.Text = "";
                    txtlastName.Text = "";
                    dtpDoB.Value = DateTime.Now;
                    txtEmail.Text = ""; // Clear the email field

                    // Reset gender radio buttons
                    rbMale.Checked = false;
                    rbFemale.Checked = false;

                    cmbUserType.SelectedIndex = -1;
                }
            }

        }

        private void userProfile_Load(object sender, EventArgs e)
        {
            // Retrieve the admin's profile details from the database
            Profile profile = (Profile)SessionManager.GetSession("AdminProfile");

            if (profile != null)
            {
                int userId = profile.UserId;
                string firstName = profile.FirstName;
                string lastName = profile.LastName;
                string gender = profile.Gender;
                DateTime doB = profile.DoB;
                string email = profile.Email;
                string userType = profile.userType;
                byte[] userPhoto = (byte[])profile.AdminPhoto;

                CProfile newProfile = new CProfile();
               // newProfile.updateUserProfile(firstName, lastName, gender, doB, userType, userPhoto);
            }
        }

        private void picGoBackUserLogin_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear or reset the fields if no stock is found
            txtfirstName.Text = "";
            txtlastName.Text = "";
            dtpDoB.Value = DateTime.Now;
            txtEmail.Text = ""; // Clear the email field

            // Reset gender radio buttons
            rbMale.Checked = false;
            rbFemale.Checked = false;

            cmbUserType.SelectedIndex = -1;
        }
    }
    }
    

