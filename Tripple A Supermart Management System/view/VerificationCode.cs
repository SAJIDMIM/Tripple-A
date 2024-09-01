using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace Tripple_A_Supermart_Management_System.view
{
    public partial class VerificationCode : Form
    {
        public VerificationCode()
        {
            InitializeComponent();
        }

        private Dictionary<string, VerificationCodeInfo> verificationCodes = new Dictionary<string, VerificationCodeInfo>();

        private const int CodeExpirationMinutes = 1; // Set expiration time (in minutes)

        public int Code { get; set; }
        public DateTime ExpirationTime { get; set; }

        private void btn_Send_Email_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            Random randomCode = new Random();
            int vCode = randomCode.Next(100000, 999999);
            string to, from, pass, mail;
            to = txt_email.Text;
            from = "mohamedsajid450@gmail.com";
            mail = vCode.ToString();
            pass = "pjpt pqak ldxd gukn";//my app password 

            DateTime expirationTime = DateTime.Now.AddMinutes(CodeExpirationMinutes);
            VerificationCodeInfo codeInfo = new VerificationCodeInfo(vCode, expirationTime);




            // Store the verification code associated with the email



            if (verificationCodes.ContainsKey(to))
            {
                verificationCodes[to] = codeInfo; // Update the code if the email is already present
            }
            else
            {
                verificationCodes.Add(to, codeInfo); // Add a new entry if the email is not present
            }
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Subject = "Your Verification code for reset password";
            message.Body = mail;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Successfully sent a verificaton code to your gmail", "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_verificationCode.Enabled = true;
                btn_verify_Code.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btn_verify_Code_Click(object sender, EventArgs e)
        {


            string email = txt_email.Text;
            string enteredCode = txt_verificationCode.Text;


            if (string.IsNullOrEmpty(email))
            {


                MessageBox.Show("Please enter your email address", "Email Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (verificationCodes.ContainsKey(email))
            {
                VerificationCodeInfo codeInfo = verificationCodes[email];

                if (DateTime.Now > codeInfo.ExpirationTime)
                {
                    MessageBox.Show("Verification code has expired", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (enteredCode == codeInfo.Code.ToString())
                {
                    MessageBox.Show("Successfully Verified", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forgot_Password forgot = new Forgot_Password();
                    forgot.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid verification code", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email address not found", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {


        }

        public class VerificationCodeInfo
        {
            public int Code { get; set; }
            public DateTime ExpirationTime { get; set; }

            public VerificationCodeInfo(int code, DateTime expirationTime)
            {
                Code = code;
                ExpirationTime = expirationTime;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
