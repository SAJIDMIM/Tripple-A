using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void picAdminType_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhoto = new OpenFileDialog();
            openPhoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(openPhoto.ShowDialog() == DialogResult.OK)
            {
                picAdminType.Image = new Bitmap(openPhoto.FileName);
                picAdminType.Image = Image.FromFile(openPhoto.FileName);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string adminId = cmbAdminId.SelectedItem.ToString();
            string Name = txtadminName.Text;
            DateTime Dob = dtpDob.Value;
            string gender;
            if(rdbMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string email = txtadminEmail.Text;
            string Type = cmbadminType.SelectedItem.ToString();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            byte[] photo = null;
           

            CadminUpdateProfile update = new CadminUpdateProfile();
            update.UpdateProfile(adminId,Name, Dob, gender, email, username, password,Type,photo);

            //Set the Text properties of the txtUsername and txtPassword textboxes to the username and password variables
            txtUsername.Text = username;
            txtPassword.Text = password;

            

        }
    }
}
