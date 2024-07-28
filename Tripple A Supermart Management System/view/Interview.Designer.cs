
namespace Tripple_A_Supermart_Management_System.view
{
    partial class Interview
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Schedule_Interview = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_Status_Interview = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.dtp_Schedule_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Employee_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Location = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Employee_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Interview_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_Hr_Dashboard = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hr_Dashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.free_interview_scheduling_tool_ee8ad7c6c1;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 44);
            this.label7.TabIndex = 87;
            this.label7.Text = "Schedule Interview ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.btn_Schedule_Interview);
            this.panel1.Controls.Add(this.cmb_Status_Interview);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmb_Type);
            this.panel1.Controls.Add(this.dtp_Schedule_Date);
            this.panel1.Controls.Add(this.txt_Employee_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Location);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Employee_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Interview_Id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(44, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 471);
            this.panel1.TabIndex = 88;
            // 
            // btn_Schedule_Interview
            // 
            this.btn_Schedule_Interview.BorderThickness = 1;
            this.btn_Schedule_Interview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Schedule_Interview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Schedule_Interview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Schedule_Interview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Schedule_Interview.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Schedule_Interview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Schedule_Interview.ForeColor = System.Drawing.Color.Black;
            this.btn_Schedule_Interview.Location = new System.Drawing.Point(545, 405);
            this.btn_Schedule_Interview.Name = "btn_Schedule_Interview";
            this.btn_Schedule_Interview.Size = new System.Drawing.Size(138, 45);
            this.btn_Schedule_Interview.TabIndex = 151;
            this.btn_Schedule_Interview.Text = "Schedule";
            // 
            // cmb_Status_Interview
            // 
            this.cmb_Status_Interview.FormattingEnabled = true;
            this.cmb_Status_Interview.Items.AddRange(new object[] {
            "Scheduled",
            "Not"});
            this.cmb_Status_Interview.Location = new System.Drawing.Point(379, 314);
            this.cmb_Status_Interview.Name = "cmb_Status_Interview";
            this.cmb_Status_Interview.Size = new System.Drawing.Size(121, 28);
            this.cmb_Status_Interview.TabIndex = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(376, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 29);
            this.label8.TabIndex = 149;
            this.label8.Text = "Status";
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "Business",
            "Personal"});
            this.cmb_Type.Location = new System.Drawing.Point(381, 208);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(121, 28);
            this.cmb_Type.TabIndex = 148;
            // 
            // dtp_Schedule_Date
            // 
            this.dtp_Schedule_Date.Location = new System.Drawing.Point(30, 424);
            this.dtp_Schedule_Date.Name = "dtp_Schedule_Date";
            this.dtp_Schedule_Date.Size = new System.Drawing.Size(233, 26);
            this.dtp_Schedule_Date.TabIndex = 147;
            // 
            // txt_Employee_Id
            // 
            this.txt_Employee_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Employee_Id.DefaultText = "";
            this.txt_Employee_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Employee_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Employee_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Employee_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Employee_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Employee_Id.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txt_Employee_Id.ForeColor = System.Drawing.Color.Black;
            this.txt_Employee_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Employee_Id.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txt_Employee_Id.Location = new System.Drawing.Point(30, 197);
            this.txt_Employee_Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Employee_Id.Name = "txt_Employee_Id";
            this.txt_Employee_Id.PasswordChar = '\0';
            this.txt_Employee_Id.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txt_Employee_Id.PlaceholderText = "Enter Employee Id";
            this.txt_Employee_Id.SelectedText = "";
            this.txt_Employee_Id.Size = new System.Drawing.Size(143, 40);
            this.txt_Employee_Id.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 145;
            this.label1.Text = "Employee Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 29);
            this.label6.TabIndex = 143;
            this.label6.Text = "Type";
            // 
            // txt_Location
            // 
            this.txt_Location.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Location.DefaultText = "";
            this.txt_Location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Location.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Location.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txt_Location.ForeColor = System.Drawing.Color.Black;
            this.txt_Location.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Location.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.location1;
            this.txt_Location.Location = new System.Drawing.Point(381, 72);
            this.txt_Location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.PasswordChar = '\0';
            this.txt_Location.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txt_Location.PlaceholderText = "Enter Location";
            this.txt_Location.SelectedText = "";
            this.txt_Location.Size = new System.Drawing.Size(233, 40);
            this.txt_Location.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 141;
            this.label5.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 139;
            this.label3.Text = "Date";
            // 
            // txt_Employee_Name
            // 
            this.txt_Employee_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Employee_Name.DefaultText = "";
            this.txt_Employee_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Employee_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Employee_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Employee_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Employee_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Employee_Name.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txt_Employee_Name.ForeColor = System.Drawing.Color.Black;
            this.txt_Employee_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Employee_Name.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.user;
            this.txt_Employee_Name.Location = new System.Drawing.Point(30, 302);
            this.txt_Employee_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Employee_Name.Name = "txt_Employee_Name";
            this.txt_Employee_Name.PasswordChar = '\0';
            this.txt_Employee_Name.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txt_Employee_Name.PlaceholderText = "Enter Name";
            this.txt_Employee_Name.SelectedText = "";
            this.txt_Employee_Name.Size = new System.Drawing.Size(232, 40);
            this.txt_Employee_Name.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 137;
            this.label2.Text = "Name";
            // 
            // txt_Interview_Id
            // 
            this.txt_Interview_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Interview_Id.DefaultText = "";
            this.txt_Interview_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Interview_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Interview_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Interview_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Interview_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Interview_Id.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txt_Interview_Id.ForeColor = System.Drawing.Color.Black;
            this.txt_Interview_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Interview_Id.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txt_Interview_Id.Location = new System.Drawing.Point(30, 72);
            this.txt_Interview_Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Interview_Id.Name = "txt_Interview_Id";
            this.txt_Interview_Id.PasswordChar = '\0';
            this.txt_Interview_Id.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txt_Interview_Id.PlaceholderText = "Enter Interview Id";
            this.txt_Interview_Id.SelectedText = "";
            this.txt_Interview_Id.Size = new System.Drawing.Size(143, 40);
            this.txt_Interview_Id.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 133;
            this.label4.Text = "Interview Id";
            // 
            // pic_Hr_Dashboard
            // 
            this.pic_Hr_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.pic_Hr_Dashboard.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.back;
            this.pic_Hr_Dashboard.ImageRotate = 0F;
            this.pic_Hr_Dashboard.Location = new System.Drawing.Point(12, 12);
            this.pic_Hr_Dashboard.Name = "pic_Hr_Dashboard";
            this.pic_Hr_Dashboard.Size = new System.Drawing.Size(33, 42);
            this.pic_Hr_Dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hr_Dashboard.TabIndex = 129;
            this.pic_Hr_Dashboard.TabStop = false;
            this.pic_Hr_Dashboard.UseTransparentBackground = true;
            // 
            // Interview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 742);
            this.Controls.Add(this.pic_Hr_Dashboard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Interview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hr_Dashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Hr_Dashboard;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_Location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Employee_Name;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Interview_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Status_Interview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.DateTimePicker dtp_Schedule_Date;
        private Guna.UI2.WinForms.Guna2TextBox txt_Employee_Id;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Schedule_Interview;
    }
}