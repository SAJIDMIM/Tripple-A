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
using Tripple_A_Supermart_Management_System.model;



namespace Tripple_A_Supermart_Management_System.view
{
    public partial class AdminLogin : Form
    {

        public AdminLogin()
        {
            InitializeComponent();
            cmbType.Items.Add("Ordinary");
            cmbType.Items.Add("Director");
            cmbType.Items.Add("User");

            

        }
        private void SaveCredentials(string usertype, string username, string password)//saving the details
        {
            Properties.Settings.Default[$"{usertype}_username"] = username;
            Properties.Settings.Default[$"{usertype}_password"] = null;
            Properties.Settings.Default[$"{usertype}_RememberMe"] = chRememberMe.Checked;
            Properties.Settings.Default.Save();


        }
        //load login details to particular user is selected
        private void LoadCredentials()
        {
            if (cmbType.SelectedItem != null)
            {
                string usertype = cmbType.SelectedItem.ToString();
                if (Properties.Settings.Default[$"{usertype}_RememberMe"] != null && (bool)Properties.Settings.Default[$"{usertype}_RememberMe"])
                {
                    txt_adminusername.Text = Properties.Settings.Default[$"{usertype}_username"]?.ToString();
                   
                    chRememberMe.Checked = true;
                }
                else
                {
                    txt_adminusername.Text = "";
                    
                    chRememberMe.Checked = false;
                }
            }


        }





        private void AdminLogin_Load(object sender, EventArgs e)
        {


        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            //going to login form
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login function works here
            string adminrole = cmbType.SelectedItem?.ToString();

            string username = txt_adminusername.Text;
            string password = txt_adminpassword.Text;
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(adminrole))
            {
                MessageBox.Show("Please Enter all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if(adminrole == "User")
           {
                MessageBox.Show("Invalid role.", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }


            CAdminLogin adminlogin = new CAdminLogin();


            Admin admin  = adminlogin.Login(adminrole,username, password);

            try
            {
                if (admin != null)
                {
                    MessageBox.Show("You have successfully logged in to the System.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (chRememberMe.Checked)
                    {
                        SaveCredentials(adminrole, username, password);
                    }
                    else
                    {
                        SaveCredentials(adminrole, "", "");
                    }
                    // Redirect to the appropriate dashboard based on the user's role
                    switch (admin.Role)
                    {
                        case "Ordinary":
                            AdminDashboard adminDashboard = new AdminDashboard();
                            adminDashboard.Show();
                            break;

                        case "Director":
                           
                        default:
                            MessageBox.Show("Invalid role.","Invalid Type",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            break;
                    }

                    this.Hide(); // Hide the adminlogin form
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    


            private void chShowPassword_CheckedChanged(object sender, EventArgs e)
            {
                //check if the password for show and hidden purpose
                if (chShowPassword.Checked == false)
                {
                    txt_adminpassword.UseSystemPasswordChar = false;


                }
                else
                {
                    txt_adminpassword.UseSystemPasswordChar = true;




                }
            }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //going to verification form 
            VerificationCode vc = new VerificationCode();
            vc.Show();
            this.Hide();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            //close the program
            Application.Exit();
        }

        private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //clear all the fields

            chRememberMe.Checked = false;
            txt_adminusername.Clear();
            txt_adminpassword.Clear();
        }

        private void cmbType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadCredentials();

            
        }
    }
    }
