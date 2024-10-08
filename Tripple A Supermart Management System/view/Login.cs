﻿using System;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;






namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Login : Form
    {

        public Login()
        {

            InitializeComponent();

            //add items to the combobox 
            cmbType.Items.Add("HR");
            cmbType.Items.Add("General");
            cmbType.Items.Add("Junior");
            cmbType.Items.Add("Supervisor");
            cmbType.Items.Add("Digital");
            cmbType.Items.Add("Accountant");
            cmbType.Items.Add("Storekeeper");
            cmbType.Items.Add("Sale");
            cmbType.Items.Add("Cashier");
            LoadCredentials();


            //LoadCredentials();

        }
        //save login details of a particular user
        private void SaveCredentials(string usertype, string username, string password)//saving the details
        {
            Properties.Settings.Default[$"{usertype}_username"] = username;
            Properties.Settings.Default[$"{usertype}_password"] = null;
            Properties.Settings.Default[$"{usertype}_RememberMe"] = chRemberMe.Checked;
            Properties.Settings.Default.Save();


        }
        //load login details to particular user is selected
        private void LoadCredentials()
        {

            {
                if (cmbType.SelectedItem != null)
                {
                    string usertype = cmbType.SelectedItem.ToString();
                    if (Properties.Settings.Default[$"{usertype}_RememberMe"] != null && (bool)Properties.Settings.Default[$"{usertype}_RememberMe"])
                    {
                        txt_username.Text = Properties.Settings.Default[$"{usertype}_username"]?.ToString();

                        chRemberMe.Checked = true;
                    }
                    else
                    {
                        txt_username.Text = "";

                        chRemberMe.Checked = false;
                    }
                }
            }

        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMainActor_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            //select a particular user type and displaying the credentials automatically

            string username = txt_username.Text;
            string password = txt_password.Text;
            string role = cmbType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please Enter all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (role == "User")
            {
                MessageBox.Show("Invalid role.", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            CLogin CL = new CLogin();//callinbg package
            model.Users user = CL.Login(role, username, password);



            try
            {
                if (user != null)
                {
                    MessageBox.Show("You have successfully logged in to the System.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (chRemberMe.Checked)
                    {
                        SaveCredentials(role, username, password);
                    }
                    else
                    {
                        SaveCredentials(role, "", "");
                    }
                    // Redirect to the appropriate dashboard based on the user's role
                    switch (user.Role)
                    {
                        case "HR":
                            HRManager go = new HRManager();
                            go.Show();
                            this.Hide();
                            break;
                        case "General":
                            GeneralDash goBack = new GeneralDash();
                            goBack.Show();
                            this.Hide();
                            break;
                        // Add other roles as needed
                        case "Junior":
                            juniorManagerDash show = new juniorManagerDash();
                            show.Show();
                            this.Hide();   
                            break;
                        case "Supervisor":
                            supervisorDash showSup = new supervisorDash();
                            showSup.Show();
                            this.Hide();
                            break;
                        case "Digital":
                            digitalMarketerDash showDM = new digitalMarketerDash();
                            showDM.Show();
                            this.Hide();
                            break;
                        case "Accountant":
                            accountDash showAccount = new accountDash();
                            showAccount.Show();
                            this.Hide();
                            break;
                        case "Storekeeper":
                            StorekeeperDashboard showSKP = new StorekeeperDashboard();
                            showSKP.Show();
                            this.Hide();
                            break;
                        case "Sale":
                            SaleDash showSale = new SaleDash();
                            showSale.Show();
                            this.Hide();
                            break;
                        case "Cashier":
                            cashierDash showCashier = new cashierDash();
                            showCashier.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Invalid role.");
                            break;
                    }

                    this.Hide(); // Hide the login form
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
            if (chShowPassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false; // show password


            }
            else
            {
                txt_password.UseSystemPasswordChar = true; // hide password




            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //connect to the verification form if the password become blocked or not imagine what the password was quickly can change it
            VerificationCode v1 = new VerificationCode();
            v1.Show();
            this.Hide();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //link to connect the create account form
            CreateAccount account = new CreateAccount();
            account.Show();
            this.Hide();
        }

        private void cmb_user_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            //go to admin login form for authorized authentication purpose
            AdminLogin ad = new AdminLogin();
            ad.Show();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //clear all the fields
            txt_username.Clear();
            txt_password.Clear();

            chRemberMe.Checked = false;

        }

        private void chRemberMe_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCredentials();
        }

        private void picAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin goBack = new AdminLogin();
            goBack.Show();
            this.Hide();
        }
    }

}