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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            chShowPassword.Checked = true;
            
           

        }

        private void cmb_user_type_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            /*

            string username = txt_username.Text.Trim();//removes leading and trailing whitespaces

            //check if the username is not empty
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be blank", "Invalid Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if the username is length between less than 8 and less or equal to 25 characters
            else if (username.Length < 8 || username.Length > 25)
            {

                MessageBox.Show("Username should be length between 08 and > 25", "Invalid Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //check if the username exist with alphanumeric characters and underscores
            bool isValid = true;
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    isValid = false;
                    break;
                }
            }

            //Display validation result
            if (isValid)
            {
                MessageBox.Show("Username is Invalid", "Invalid Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Username must contain characters", "Invalid Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            */

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();//cannot have white spaces 

            //check if the email is not empty
            if (!string.IsNullOrWhiteSpace(email))
            {
                //check if the email contain any character like "@"
                if (email.Contains("@"))
                {
                    //check if the email does not contain @ at first or end of the email
                    if (email.IndexOf("@") != 0 && email.LastIndexOf("@") != email.Length - 1)
                    {
                        MessageBox.Show("Email is valid", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Email is invalid format: '@' is missing", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Email is cannot be blank", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (!ch_agree_term.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string user_type = cmb_user_type.SelectedItem?.ToString();
            string username = txt_username.Text;
            string email = txt_email.Text;
            string password = txt_password.Text;
            string confirm_password = txt_confirm_password.Text;

            if (password != confirm_password)
            {
                MessageBox.Show("Passwords do not match. Please enter the same password in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chShowPassword.Checked == false)
            {
                MessageBox.Show("You cannot create any account unless you hide your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            CCreateAccount account = new CCreateAccount();
            account.createAccount(user_type, username, email, password, confirm_password);



        }

        private void ch_agree_term_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_agree_term.Checked)
            {
                btn_Create.Enabled = true;
            }
        }

        private void pic_back_login_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pic_show_password_Click(object sender, EventArgs e)
        {
            
        }

        private void chShowPassword_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chShowPassword.Checked == false)
            {
                txt_password.UseSystemPasswordChar = false;

                
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                



            }
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmb_user_type.Items.Clear();
            txt_username.Clear();
            txt_email.Clear();
            txt_password.Clear();
            txt_confirm_password.Clear();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

