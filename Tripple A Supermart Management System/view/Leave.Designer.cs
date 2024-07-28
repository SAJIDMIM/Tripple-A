
namespace Tripple_A_Supermart_Management_System.view
{
    partial class Leave
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_back_login = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_leaveId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_employeeId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpleaveStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLeaveEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLeaveType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_AddLeave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbuserType = new System.Windows.Forms.ComboBox();
            this.txtLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.pic_back_login);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-14, -21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 746);
            this.panel1.TabIndex = 0;
            // 
            // pic_back_login
            // 
            this.pic_back_login.BackColor = System.Drawing.Color.Transparent;
            this.pic_back_login.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.back;
            this.pic_back_login.ImageRotate = 0F;
            this.pic_back_login.Location = new System.Drawing.Point(26, 629);
            this.pic_back_login.Name = "pic_back_login";
            this.pic_back_login.Size = new System.Drawing.Size(33, 42);
            this.pic_back_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_back_login.TabIndex = 122;
            this.pic_back_login.TabStop = false;
            this.pic_back_login.UseTransparentBackground = true;
            this.pic_back_login.Click += new System.EventHandler(this.pic_back_login_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 44);
            this.label8.TabIndex = 85;
            this.label8.Text = "Request Leave";
            // 
            // txt_leaveId
            // 
            this.txt_leaveId.BorderColor = System.Drawing.Color.Black;
            this.txt_leaveId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_leaveId.DefaultText = "";
            this.txt_leaveId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_leaveId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_leaveId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_leaveId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_leaveId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_leaveId.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_leaveId.ForeColor = System.Drawing.Color.Black;
            this.txt_leaveId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_leaveId.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txt_leaveId.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_leaveId.Location = new System.Drawing.Point(278, 78);
            this.txt_leaveId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_leaveId.Name = "txt_leaveId";
            this.txt_leaveId.PasswordChar = '\0';
            this.txt_leaveId.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_leaveId.PlaceholderText = "";
            this.txt_leaveId.SelectedText = "";
            this.txt_leaveId.Size = new System.Drawing.Size(202, 44);
            this.txt_leaveId.TabIndex = 67;
            this.txt_leaveId.TextChanged += new System.EventHandler(this.txt_leaveId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 66;
            this.label1.Text = "Leave Request Id";
            // 
            // txt_employeeId
            // 
            this.txt_employeeId.BorderColor = System.Drawing.Color.Black;
            this.txt_employeeId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_employeeId.DefaultText = "";
            this.txt_employeeId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_employeeId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_employeeId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_employeeId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_employeeId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_employeeId.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_employeeId.ForeColor = System.Drawing.Color.Black;
            this.txt_employeeId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_employeeId.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txt_employeeId.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_employeeId.Location = new System.Drawing.Point(278, 190);
            this.txt_employeeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_employeeId.Name = "txt_employeeId";
            this.txt_employeeId.PasswordChar = '\0';
            this.txt_employeeId.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_employeeId.PlaceholderText = "Enter Employee Id";
            this.txt_employeeId.SelectedText = "";
            this.txt_employeeId.Size = new System.Drawing.Size(281, 44);
            this.txt_employeeId.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 68;
            this.label3.Text = "Employee Id";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BorderColor = System.Drawing.Color.Black;
            this.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstname.DefaultText = "";
            this.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstname.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtFirstname.ForeColor = System.Drawing.Color.Black;
            this.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstname.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.user;
            this.txtFirstname.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtFirstname.Location = new System.Drawing.Point(281, 395);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtFirstname.PlaceholderText = "Enter First Name";
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.Size = new System.Drawing.Size(281, 44);
            this.txtFirstname.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 70;
            this.label2.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 72;
            this.label4.Text = "Leave Start Date";
            // 
            // dtpleaveStartDate
            // 
            this.dtpleaveStartDate.Location = new System.Drawing.Point(283, 617);
            this.dtpleaveStartDate.Name = "dtpleaveStartDate";
            this.dtpleaveStartDate.Size = new System.Drawing.Size(276, 26);
            this.dtpleaveStartDate.TabIndex = 73;
            // 
            // dtpLeaveEndDate
            // 
            this.dtpLeaveEndDate.Location = new System.Drawing.Point(640, 78);
            this.dtpLeaveEndDate.Name = "dtpLeaveEndDate";
            this.dtpLeaveEndDate.Size = new System.Drawing.Size(276, 26);
            this.dtpLeaveEndDate.TabIndex = 75;
            this.dtpLeaveEndDate.ValueChanged += new System.EventHandler(this.dtpLeaveEndDate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 74;
            this.label5.Text = "Leave End Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "Leave Type";
            // 
            // cmbLeaveType
            // 
            this.cmbLeaveType.FormattingEnabled = true;
            this.cmbLeaveType.Items.AddRange(new object[] {
            "Annual",
            "Day"});
            this.cmbLeaveType.Location = new System.Drawing.Point(640, 171);
            this.cmbLeaveType.Name = "cmbLeaveType";
            this.cmbLeaveType.Size = new System.Drawing.Size(147, 28);
            this.cmbLeaveType.TabIndex = 77;
            this.cmbLeaveType.SelectedIndexChanged += new System.EventHandler(this.cmbLeaveType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 78;
            this.label7.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.BorderColor = System.Drawing.Color.Black;
            this.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.DefaultText = "";
            this.txtReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReason.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtReason.ForeColor = System.Drawing.Color.Black;
            this.txtReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReason.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.description;
            this.txtReason.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtReason.Location = new System.Drawing.Point(640, 270);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReason.Name = "txtReason";
            this.txtReason.PasswordChar = '\0';
            this.txtReason.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtReason.PlaceholderText = "Enter Reason";
            this.txtReason.SelectedText = "";
            this.txtReason.Size = new System.Drawing.Size(229, 100);
            this.txtReason.TabIndex = 79;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // btn_AddLeave
            // 
            this.btn_AddLeave.BackColor = System.Drawing.Color.Black;
            this.btn_AddLeave.BorderThickness = 1;
            this.btn_AddLeave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddLeave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddLeave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddLeave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddLeave.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_AddLeave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AddLeave.ForeColor = System.Drawing.Color.Black;
            this.btn_AddLeave.Location = new System.Drawing.Point(640, 420);
            this.btn_AddLeave.Name = "btn_AddLeave";
            this.btn_AddLeave.Size = new System.Drawing.Size(126, 45);
            this.btn_AddLeave.TabIndex = 80;
            this.btn_AddLeave.Text = "Add";
            this.btn_AddLeave.Click += new System.EventHandler(this.btn_AddLeave_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BorderThickness = 1;
            this.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Clear.FillColor = System.Drawing.Color.LightGray;
            this.btn_Clear.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(806, 420);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(124, 45);
            this.btn_Clear.TabIndex = 121;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(273, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 29);
            this.label9.TabIndex = 122;
            this.label9.Text = "User Type";
            // 
            // cmbuserType
            // 
            this.cmbuserType.FormattingEnabled = true;
            this.cmbuserType.Items.AddRange(new object[] {
            "HR",
            "General Manager",
            "Junior Manager",
            "Supervisor",
            "Digital Marketer",
            "Accountant",
            "Storekeeper",
            "Sale",
            "Cashier"});
            this.cmbuserType.Location = new System.Drawing.Point(282, 297);
            this.cmbuserType.Name = "cmbuserType";
            this.cmbuserType.Size = new System.Drawing.Size(121, 28);
            this.cmbuserType.TabIndex = 123;
            this.cmbuserType.SelectedIndexChanged += new System.EventHandler(this.cmbuserType_SelectedIndexChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.BorderColor = System.Drawing.Color.Black;
            this.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastname.DefaultText = "";
            this.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastname.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtLastname.ForeColor = System.Drawing.Color.Black;
            this.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastname.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.user;
            this.txtLastname.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtLastname.Location = new System.Drawing.Point(282, 510);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLastname.PlaceholderText = "Enter Last Name";
            this.txtLastname.SelectedText = "";
            this.txtLastname.Size = new System.Drawing.Size(281, 44);
            this.txtLastname.TabIndex = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 29);
            this.label10.TabIndex = 124;
            this.label10.Text = "Last Name";
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 662);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.cmbuserType);
            this.Controls.Add(this.btn_AddLeave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbLeaveType);
            this.Controls.Add(this.dtpLeaveEndDate);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpleaveStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_employeeId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_leaveId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_leaveId;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_employeeId;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpleaveStartDate;
        private System.Windows.Forms.DateTimePicker dtpLeaveEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLeaveType;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtReason;
        private Guna.UI2.WinForms.Guna2Button btn_AddLeave;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox pic_back_login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbuserType;
        private Guna.UI2.WinForms.Guna2TextBox txtLastname;
        private System.Windows.Forms.Label label10;
    }
}