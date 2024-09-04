
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewInterview
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterviewId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Search_Interview = new Guna.UI2.WinForms.Guna2Button();
            this.dgvInterview = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.picHrManager = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHrManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources._32791e5dea5ad5c47a84ca6070e22707;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 702);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.picHrManager);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgvInterview);
            this.panel1.Controls.Add(this.btn_Search_Interview);
            this.panel1.Controls.Add(this.txtInterviewId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(95, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 548);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 27);
            this.label4.TabIndex = 135;
            this.label4.Text = "Interview Id";
            // 
            // txtInterviewId
            // 
            this.txtInterviewId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInterviewId.DefaultText = "";
            this.txtInterviewId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInterviewId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInterviewId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInterviewId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInterviewId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInterviewId.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtInterviewId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInterviewId.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txtInterviewId.Location = new System.Drawing.Point(233, 103);
            this.txtInterviewId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInterviewId.Name = "txtInterviewId";
            this.txtInterviewId.PasswordChar = '\0';
            this.txtInterviewId.PlaceholderText = "Enter Interview Id";
            this.txtInterviewId.SelectedText = "";
            this.txtInterviewId.Size = new System.Drawing.Size(201, 34);
            this.txtInterviewId.TabIndex = 136;
            // 
            // btn_Search_Interview
            // 
            this.btn_Search_Interview.BorderThickness = 1;
            this.btn_Search_Interview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Interview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Interview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Interview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Interview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Interview.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Interview.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Interview.Location = new System.Drawing.Point(479, 103);
            this.btn_Search_Interview.Name = "btn_Search_Interview";
            this.btn_Search_Interview.Size = new System.Drawing.Size(94, 34);
            this.btn_Search_Interview.TabIndex = 137;
            this.btn_Search_Interview.Text = "Search ";
            this.btn_Search_Interview.Click += new System.EventHandler(this.btn_Search_Interview_Click);
            // 
            // dgvInterview
            // 
            this.dgvInterview.BackgroundColor = System.Drawing.Color.White;
            this.dgvInterview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterview.Location = new System.Drawing.Point(59, 177);
            this.dgvInterview.Name = "dgvInterview";
            this.dgvInterview.RowHeadersWidth = 62;
            this.dgvInterview.RowTemplate.Height = 28;
            this.dgvInterview.Size = new System.Drawing.Size(514, 330);
            this.dgvInterview.TabIndex = 138;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(388, 44);
            this.label7.TabIndex = 139;
            this.label7.Text = "View Schedule Interview";
            // 
            // picHrManager
            // 
            this.picHrManager.BackColor = System.Drawing.Color.Transparent;
            this.picHrManager.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picHrManager.ImageRotate = 0F;
            this.picHrManager.Location = new System.Drawing.Point(29, 25);
            this.picHrManager.Name = "picHrManager";
            this.picHrManager.Size = new System.Drawing.Size(33, 42);
            this.picHrManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHrManager.TabIndex = 147;
            this.picHrManager.TabStop = false;
            this.picHrManager.UseTransparentBackground = true;
            this.picHrManager.Click += new System.EventHandler(this.picHrManager_Click);
            // 
            // viewInterview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewInterview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewInterview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHrManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtInterviewId;
        private System.Windows.Forms.DataGridView dgvInterview;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Interview;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox picHrManager;
    }
}