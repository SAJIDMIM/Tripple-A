﻿
namespace Tripple_A_Supermart_Management_System.view
{
    partial class Job
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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbjobType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Post = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.linkClear = new System.Windows.Forms.LinkLabel();
            this.txt_JobDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_jobTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_publishId = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-2, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 188);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 44);
            this.label7.TabIndex = 84;
            this.label7.Text = "Post Job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "Job Title";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "Post Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "Job Type";
            // 
            // cmbjobType
            // 
            this.cmbjobType.FormattingEnabled = true;
            this.cmbjobType.Items.AddRange(new object[] {
            "Senior Manager",
            "Junior Mnager",
            "Sale Representive",
            "Cashier",
            "Clerk"});
            this.cmbjobType.Location = new System.Drawing.Point(74, 491);
            this.cmbjobType.Name = "cmbjobType";
            this.cmbjobType.Size = new System.Drawing.Size(121, 28);
            this.cmbjobType.TabIndex = 69;
            this.cmbjobType.SelectedIndexChanged += new System.EventHandler(this.cmbjobType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "Job Description";
            // 
            // btn_Post
            // 
            this.btn_Post.BackColor = System.Drawing.Color.Black;
            this.btn_Post.BorderThickness = 1;
            this.btn_Post.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Post.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Post.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Post.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Post.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Post.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Post.ForeColor = System.Drawing.Color.Black;
            this.btn_Post.Location = new System.Drawing.Point(592, 213);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(126, 45);
            this.btn_Post.TabIndex = 72;
            this.btn_Post.Text = "Post";
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderThickness = 1;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(592, 292);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(124, 45);
            this.btn_Cancel.TabIndex = 119;
            this.btn_Cancel.Text = "Abort";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // linkClear
            // 
            this.linkClear.AutoSize = true;
            this.linkClear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkClear.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.linkClear.Location = new System.Drawing.Point(657, 372);
            this.linkClear.Name = "linkClear";
            this.linkClear.Size = new System.Drawing.Size(53, 24);
            this.linkClear.TabIndex = 124;
            this.linkClear.TabStop = true;
            this.linkClear.Text = "Clear";
            this.linkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
            // 
            // txt_JobDescription
            // 
            this.txt_JobDescription.BorderColor = System.Drawing.Color.Black;
            this.txt_JobDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_JobDescription.DefaultText = "";
            this.txt_JobDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_JobDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_JobDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_JobDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_JobDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_JobDescription.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_JobDescription.ForeColor = System.Drawing.Color.Black;
            this.txt_JobDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_JobDescription.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.description;
            this.txt_JobDescription.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_JobDescription.Location = new System.Drawing.Point(74, 577);
            this.txt_JobDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_JobDescription.Name = "txt_JobDescription";
            this.txt_JobDescription.PasswordChar = '\0';
            this.txt_JobDescription.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_JobDescription.PlaceholderText = "Enter Job Description";
            this.txt_JobDescription.SelectedText = "";
            this.txt_JobDescription.Size = new System.Drawing.Size(319, 81);
            this.txt_JobDescription.TabIndex = 71;
            this.txt_JobDescription.TextChanged += new System.EventHandler(this.txt_JobDescription_TextChanged);
            // 
            // txt_jobTitle
            // 
            this.txt_jobTitle.BorderColor = System.Drawing.Color.Black;
            this.txt_jobTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_jobTitle.DefaultText = "";
            this.txt_jobTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_jobTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_jobTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jobTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_jobTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jobTitle.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_jobTitle.ForeColor = System.Drawing.Color.Black;
            this.txt_jobTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_jobTitle.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.title;
            this.txt_jobTitle.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_jobTitle.Location = new System.Drawing.Point(74, 372);
            this.txt_jobTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_jobTitle.Name = "txt_jobTitle";
            this.txt_jobTitle.PasswordChar = '\0';
            this.txt_jobTitle.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_jobTitle.PlaceholderText = "Enter the Job Title";
            this.txt_jobTitle.SelectedText = "";
            this.txt_jobTitle.Size = new System.Drawing.Size(319, 44);
            this.txt_jobTitle.TabIndex = 67;
            this.txt_jobTitle.TextChanged += new System.EventHandler(this.txt_jobTitle_TextChanged);
            // 
            // txt_publishId
            // 
            this.txt_publishId.BorderColor = System.Drawing.Color.Black;
            this.txt_publishId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_publishId.DefaultText = "";
            this.txt_publishId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_publishId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_publishId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_publishId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_publishId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_publishId.Font = new System.Drawing.Font("Calibri", 9F);
            this.txt_publishId.ForeColor = System.Drawing.Color.Black;
            this.txt_publishId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_publishId.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txt_publishId.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_publishId.Location = new System.Drawing.Point(74, 255);
            this.txt_publishId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_publishId.Name = "txt_publishId";
            this.txt_publishId.PasswordChar = '\0';
            this.txt_publishId.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_publishId.PlaceholderText = "Enter Publish Id";
            this.txt_publishId.SelectedText = "";
            this.txt_publishId.Size = new System.Drawing.Size(159, 37);
            this.txt_publishId.TabIndex = 65;
            this.txt_publishId.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // PostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 709);
            this.Controls.Add(this.linkClear);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Post);
            this.Controls.Add(this.txt_JobDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbjobType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_jobTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_publishId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PostJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_publishId;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_jobTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbjobType;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_JobDescription;
        private Guna.UI2.WinForms.Guna2Button btn_Post;
        private Guna.UI2.WinForms.Guna2Button btn_Cancel;
        private System.Windows.Forms.LinkLabel linkClear;
    }
}