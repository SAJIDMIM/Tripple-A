using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;
using Tripple_A_Supermart_Management_System.model;
//using System.Drawing;
namespace Tripple_A_Supermart_Management_System.view

{
    public partial class UpdateProfile : Form
    {
        private byte[] adminPhoto;
        private object adminPhotoBytes;

        public UpdateProfile()
        {
            InitializeComponent();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int adminId = Convert.ToInt32(txt_adminId.Text);
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
            Image adminPhoto = null; // Initialize adminPhoto to null
           

            CProfile newProfile = new CProfile();
            newProfile.updateProfile(adminId, firstName, lastName, gender, email, doB,adminPhoto);

            // Load the updated profile details for ordinary admins only
            // When the ordinary admin logs in
            Profile profile = new Profile
            {
                AdminId = adminId,
                FirstName = firstName,
                LastName = lastName,
                DoB = doB,
                Gender = gender,
                Email = email,
                AdminPhoto = adminPhotoBytes
            };
            SessionManager.SetSession("AdminProfile", profile);
        }



        private void picAdminProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAdminProfile.Image = Image.FromFile(ofd.FileName);

                // Convert the image to a byte array
                MemoryStream ms = new MemoryStream();
                picAdminProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                adminPhoto = ms.ToArray();
            }
        }

        private void btn_Search_AdminId_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int adminId = Convert.ToInt32(txt_adminId.Text);

            CProfile adminDetailsof = new CProfile();
            DataTable adminDetails = adminDetailsof.getAdminDetails(adminId);

            if (adminDetails.Rows.Count > 0)
            {
                DataRow row = adminDetails.Rows[0];

                // Update the fields with the retrieved data
                txtfirstName.Text = row["firstName"].ToString();
                txtlastName.Text = row["lastName"].ToString();
                dtpDoB.Value = Convert.ToDateTime(row["doB"]);
                txtEmail.Text = row["email"].ToString(); // Assuming "email" is the column name for email

                // Set the gender radio button based on the retrieved value
                if (row["gender"].ToString() == "Male")
                {
                    rbMale.Checked = true;
                }
                else if (row["gender"].ToString() == "Female")
                {
                    rbFemale.Checked = true;
                }

            }
            else
            {
                MessageBox.Show("No admin found with the provided admin ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear or reset the fields if no stock is found
                txtfirstName.Text = "";
                txtlastName.Text = "";
                dtpDoB.Value = DateTime.Now;
                txtEmail.Text = ""; // Clear the email field

                // Reset gender radio buttons
                rbMale.Checked = false;
                rbFemale.Checked = false;
            }
            }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            // Retrieve the admin's profile details from the database
            Profile profile = (Profile)SessionManager.GetSession("AdminProfile");

            if (profile != null)
            {
                txt_adminId.Text = profile.AdminId.ToString();
                txtfirstName.Text = profile.FirstName;
                txtlastName.Text = profile.LastName;
                dtpDoB.Value = profile.DoB;
                txtEmail.Text = profile.Email;

                // Set the gender radio button based on the retrieved value
                if (profile.Gender == "Male")
                {
                    rbMale.Checked = true;
                }
                else if (profile.Gender == "Female")
                {
                    rbFemale.Checked = true;
                }

                // Load the admin photo
                if (profile.AdminPhoto != null)
                {
                    MemoryStream ms = new MemoryStream((byte[])profile.AdminPhoto);
                    picAdminProfile.Image = Image.FromStream(ms);
                }
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            AdminDashboard back = new AdminDashboard();
            back.Show();
            this.Hide();
        }

        private void txt_adminId_TextChanged(object sender, EventArgs e)
        {
            if (txt_adminId.Text.Length > 0)
            {
                int adminId = Convert.ToInt32(txt_adminId.Text);
                if (adminId == 2)
                {
                    MessageBox.Show("You are not authorized to use this ID. Please enter your own ID.","Unauthorized Access",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txt_adminId.Clear();
                    txt_adminId.Focus();
                }
                else
                {
                    
                }
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            string email = txtEmail.Text;
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus(); // This will bring the focus back to the text box
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_adminId.Clear();
            txtfirstName.Clear();
            txtlastName.Clear();
            dtpDoB.Value = DateTime.Today;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtEmail.Clear();

        }
    }
    public class SessionManager
    {
        private static Dictionary<string, object> _session = new Dictionary<string, object>();

        public static void SetSession(string key, object value)
        {
            _session[key] = value;
        }

        public static object GetSession(string key)
        {
            if (_session.ContainsKey(key))
            {
                return _session[key];
            }
            return null;
        }
    }
}
    

    
    

