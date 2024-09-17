
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewLoyaltyCustomer
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
            this.dgvLoyaltyCustomers = new System.Windows.Forms.DataGridView();
            this.btn_Search_Loyalty_Customer = new Guna.UI2.WinForms.Guna2Button();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picGoBackGeneralManager = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyaltyCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackGeneralManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.dgvLoyaltyCustomers);
            this.panel1.Controls.Add(this.btn_Search_Loyalty_Customer);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(115, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 415);
            this.panel1.TabIndex = 150;
            // 
            // dgvLoyaltyCustomers
            // 
            this.dgvLoyaltyCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoyaltyCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoyaltyCustomers.Location = new System.Drawing.Point(32, 108);
            this.dgvLoyaltyCustomers.Name = "dgvLoyaltyCustomers";
            this.dgvLoyaltyCustomers.RowHeadersWidth = 62;
            this.dgvLoyaltyCustomers.RowTemplate.Height = 28;
            this.dgvLoyaltyCustomers.Size = new System.Drawing.Size(482, 285);
            this.dgvLoyaltyCustomers.TabIndex = 149;
            // 
            // btn_Search_Loyalty_Customer
            // 
            this.btn_Search_Loyalty_Customer.BorderThickness = 1;
            this.btn_Search_Loyalty_Customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Loyalty_Customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Loyalty_Customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Loyalty_Customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Loyalty_Customer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Loyalty_Customer.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Loyalty_Customer.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Loyalty_Customer.Location = new System.Drawing.Point(420, 49);
            this.btn_Search_Loyalty_Customer.Name = "btn_Search_Loyalty_Customer";
            this.btn_Search_Loyalty_Customer.Size = new System.Drawing.Size(94, 34);
            this.btn_Search_Loyalty_Customer.TabIndex = 148;
            this.btn_Search_Loyalty_Customer.Text = "Search ";
            this.btn_Search_Loyalty_Customer.Click += new System.EventHandler(this.btn_Search_Loyalty_Customer_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobile.DefaultText = "";
            this.txtMobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobile.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtMobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobile.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.mobile;
            this.txtMobile.Location = new System.Drawing.Point(151, 49);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.PlaceholderText = "Enter Mobile Number";
            this.txtMobile.SelectedText = "";
            this.txtMobile.Size = new System.Drawing.Size(230, 34);
            this.txtMobile.TabIndex = 147;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 94;
            this.label3.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 44);
            this.label7.TabIndex = 149;
            this.label7.Text = "View Loyalty Customer";
            // 
            // picGoBackGeneralManager
            // 
            this.picGoBackGeneralManager.BackColor = System.Drawing.Color.Transparent;
            this.picGoBackGeneralManager.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picGoBackGeneralManager.ImageRotate = 0F;
            this.picGoBackGeneralManager.Location = new System.Drawing.Point(28, 548);
            this.picGoBackGeneralManager.Name = "picGoBackGeneralManager";
            this.picGoBackGeneralManager.Size = new System.Drawing.Size(33, 42);
            this.picGoBackGeneralManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoBackGeneralManager.TabIndex = 151;
            this.picGoBackGeneralManager.TabStop = false;
            this.picGoBackGeneralManager.UseTransparentBackground = true;
            this.picGoBackGeneralManager.Click += new System.EventHandler(this.picGoBackGeneralManager_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources._113020_How_to_Deliver_Excellent_Customer_Experience_header;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // viewLoyaltyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picGoBackGeneralManager);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewLoyaltyCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewLoyaltyCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyaltyCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackGeneralManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLoyaltyCustomers;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Loyalty_Customer;
        private Guna.UI2.WinForms.Guna2TextBox txtMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackGeneralManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}