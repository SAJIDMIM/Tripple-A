
namespace Tripple_A_Supermart_Management_System.view
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_user_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Create = new Guna.UI2.WinForms.Guna2Button();
            this.ch_agree_term = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chShowPassword = new System.Windows.Forms.CheckBox();
            this.pic_back_login = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_confirm_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_close = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, -30);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(402, 844);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 1;
            this.guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.Aaa_Supermart;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(41, 146);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(298, 169);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 44);
            this.label7.TabIndex = 15;
            this.label7.Text = "Create Account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 29);
            this.label8.TabIndex = 116;
            this.label8.Text = "User Type";
            // 
            // cmb_user_type
            // 
            this.cmb_user_type.FormattingEnabled = true;
            this.cmb_user_type.Items.AddRange(new object[] {
            "HR",
            "General",
            "Junior",
            "Supervisor",
            "Digital",
            "Accountant",
            "Sale",
            "Cashier"});
            this.cmb_user_type.Location = new System.Drawing.Point(471, 145);
            this.cmb_user_type.Name = "cmb_user_type";
            this.cmb_user_type.Size = new System.Drawing.Size(121, 28);
            this.cmb_user_type.TabIndex = 115;
            this.cmb_user_type.SelectedIndexChanged += new System.EventHandler(this.cmb_user_type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 19);
            this.label5.TabIndex = 106;
            this.label5.Text = "By clicking Create,you agree to our Terms and Conditions";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 105;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 104;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 103;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "Username";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Black;
            this.btn_Create.BorderThickness = 1;
            this.btn_Create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Create.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Create.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Create.ForeColor = System.Drawing.Color.Black;
            this.btn_Create.Location = new System.Drawing.Point(460, 696);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(411, 45);
            this.btn_Create.TabIndex = 101;
            this.btn_Create.Text = "Create";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // ch_agree_term
            // 
            this.ch_agree_term.AutoSize = true;
            this.ch_agree_term.Location = new System.Drawing.Point(472, 617);
            this.ch_agree_term.Name = "ch_agree_term";
            this.ch_agree_term.Size = new System.Drawing.Size(43, 24);
            this.ch_agree_term.TabIndex = 100;
            this.ch_agree_term.Text = "  ";
            this.ch_agree_term.UseVisualStyleBackColor = true;
            this.ch_agree_term.CheckedChanged += new System.EventHandler(this.ch_agree_term_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.linkLabel1.Location = new System.Drawing.Point(818, 644);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 24);
            this.linkLabel1.TabIndex = 117;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clear";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chShowPassword
            // 
            this.chShowPassword.AutoSize = true;
            this.chShowPassword.Location = new System.Drawing.Point(853, 513);
            this.chShowPassword.Name = "chShowPassword";
            this.chShowPassword.Size = new System.Drawing.Size(22, 21);
            this.chShowPassword.TabIndex = 118;
            this.chShowPassword.UseVisualStyleBackColor = true;
            this.chShowPassword.CheckedChanged += new System.EventHandler(this.chShowPassword_CheckedChanged);
            // 
            // pic_back_login
            // 
            this.pic_back_login.BackColor = System.Drawing.Color.Transparent;
            this.pic_back_login.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.back;
            this.pic_back_login.ImageRotate = 0F;
            this.pic_back_login.Location = new System.Drawing.Point(429, 15);
            this.pic_back_login.Name = "pic_back_login";
            this.pic_back_login.Size = new System.Drawing.Size(33, 42);
            this.pic_back_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_back_login.TabIndex = 111;
            this.pic_back_login.TabStop = false;
            this.pic_back_login.UseTransparentBackground = true;
            this.pic_back_login.Click += new System.EventHandler(this.pic_back_login_Click);
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.BorderColor = System.Drawing.Color.Black;
            this.txt_confirm_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confirm_password.DefaultText = "";
            this.txt_confirm_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confirm_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confirm_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirm_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirm_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirm_password.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_password.ForeColor = System.Drawing.Color.Black;
            this.txt_confirm_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirm_password.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.padlock;
            this.txt_confirm_password.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_confirm_password.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txt_confirm_password.Location = new System.Drawing.Point(473, 559);
            this.txt_confirm_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.PasswordChar = '●';
            this.txt_confirm_password.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_confirm_password.PlaceholderText = "Enter Confirm Password";
            this.txt_confirm_password.SelectedText = "";
            this.txt_confirm_password.Size = new System.Drawing.Size(398, 44);
            this.txt_confirm_password.TabIndex = 110;
            this.txt_confirm_password.UseSystemPasswordChar = true;
            // 
            // txt_password
            // 
            this.txt_password.BorderColor = System.Drawing.Color.Black;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.padlock;
            this.txt_password.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_password.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txt_password.Location = new System.Drawing.Point(474, 445);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_password.PlaceholderText = "Enter Password";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(397, 44);
            this.txt_password.TabIndex = 109;
            // 
            // txt_email
            // 
            this.txt_email.BorderColor = System.Drawing.Color.Black;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.mail;
            this.txt_email.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_email.Location = new System.Drawing.Point(474, 339);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_email.PlaceholderText = "Enter Email";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(401, 44);
            this.txt_email.TabIndex = 108;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.BorderColor = System.Drawing.Color.Black;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.user;
            this.txt_username.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_username.Location = new System.Drawing.Point(474, 232);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_username.PlaceholderText = "Enter Username";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(401, 44);
            this.txt_username.TabIndex = 107;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.cross_mark_8369334;
            this.pic_close.ImageRotate = 0F;
            this.pic_close.Location = new System.Drawing.Point(891, 15);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(33, 42);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 99;
            this.pic_close.TabStop = false;
            this.pic_close.UseTransparentBackground = true;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 798);
            this.Controls.Add(this.chShowPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_user_type);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.ch_agree_term);
            this.Controls.Add(this.pic_back_login);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_user_type;
        private Guna.UI2.WinForms.Guna2PictureBox pic_back_login;
        private Guna.UI2.WinForms.Guna2TextBox txt_confirm_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Create;
        private Guna.UI2.WinForms.Guna2PictureBox pic_close;
        private System.Windows.Forms.CheckBox ch_agree_term;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox chShowPassword;
    }
}