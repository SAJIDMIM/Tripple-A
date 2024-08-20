
namespace Tripple_A_Supermart_Management_System.view
{
    partial class Account
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picGoBackAdminLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Search_Account = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAccountDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackAdminLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.pasted_image_0;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAccountDetails);
            this.panel1.Controls.Add(this.picGoBackAdminLogin);
            this.panel1.Controls.Add(this.btn_Search_Account);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(111, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 458);
            this.panel1.TabIndex = 1;
            // 
            // picGoBackAdminLogin
            // 
            this.picGoBackAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.picGoBackAdminLogin.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources._return;
            this.picGoBackAdminLogin.ImageRotate = 0F;
            this.picGoBackAdminLogin.Location = new System.Drawing.Point(22, 15);
            this.picGoBackAdminLogin.Name = "picGoBackAdminLogin";
            this.picGoBackAdminLogin.Size = new System.Drawing.Size(33, 42);
            this.picGoBackAdminLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoBackAdminLogin.TabIndex = 146;
            this.picGoBackAdminLogin.TabStop = false;
            this.picGoBackAdminLogin.UseTransparentBackground = true;
            this.picGoBackAdminLogin.Click += new System.EventHandler(this.picGoBackAdminLogin_Click);
            // 
            // btn_Search_Account
            // 
            this.btn_Search_Account.BorderThickness = 1;
            this.btn_Search_Account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Account.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Account.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Account.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Account.Location = new System.Drawing.Point(460, 114);
            this.btn_Search_Account.Name = "btn_Search_Account";
            this.btn_Search_Account.Size = new System.Drawing.Size(94, 34);
            this.btn_Search_Account.TabIndex = 105;
            this.btn_Search_Account.Text = "Search ";
            this.btn_Search_Account.Click += new System.EventHandler(this.btn_Search_Account_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 93;
            this.label3.Text = "User Id";
            // 
            // txtUserId
            // 
            this.txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserId.DefaultText = "";
            this.txtUserId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserId.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtUserId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserId.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txtUserId.Location = new System.Drawing.Point(133, 114);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '\0';
            this.txtUserId.PlaceholderText = "Enter User Id";
            this.txtUserId.SelectedText = "";
            this.txtUserId.Size = new System.Drawing.Size(309, 34);
            this.txtUserId.TabIndex = 83;
            this.txtUserId.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 44);
            this.label7.TabIndex = 82;
            this.label7.Text = "View Account";
            // 
            // dgvAccountDetails
            // 
            this.dgvAccountDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountDetails.Location = new System.Drawing.Point(40, 172);
            this.dgvAccountDetails.Name = "dgvAccountDetails";
            this.dgvAccountDetails.RowHeadersWidth = 62;
            this.dgvAccountDetails.RowTemplate.Height = 28;
            this.dgvAccountDetails.Size = new System.Drawing.Size(514, 253);
            this.dgvAccountDetails.TabIndex = 147;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackAdminLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Account;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackAdminLogin;
        private System.Windows.Forms.DataGridView dgvAccountDetails;
    }
}