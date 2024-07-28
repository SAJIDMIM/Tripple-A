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

using System.Data.SqlClient;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_confirm_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void chForgotPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

            string username,password, confirm_password;
            username = txt_username.Text;
            password = txt_New_Password.Text;
            confirm_password = txt_confirm_password.Text;
            
            CForgotPassword cforgot = new CForgotPassword();
            cforgot.ForgotPassword(username,password,confirm_password);
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
