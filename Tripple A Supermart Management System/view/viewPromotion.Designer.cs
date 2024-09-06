
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewPromotion
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
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search_Employee = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Employee_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 44);
            this.label7.TabIndex = 83;
            this.label7.Text = "View Promotion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.PngItem_30169631;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvEmployee);
            this.panel1.Controls.Add(this.txt_Employee_Id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Search_Employee);
            this.panel1.Location = new System.Drawing.Point(101, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 498);
            this.panel1.TabIndex = 85;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(8, 169);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.RowTemplate.Height = 28;
            this.dgvEmployee.Size = new System.Drawing.Size(622, 309);
            this.dgvEmployee.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 111;
            this.label3.Text = "Marketing Promotion Id";
            // 
            // btn_Search_Employee
            // 
            this.btn_Search_Employee.BorderThickness = 1;
            this.btn_Search_Employee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Employee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Employee.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Employee.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Employee.Location = new System.Drawing.Point(522, 99);
            this.btn_Search_Employee.Name = "btn_Search_Employee";
            this.btn_Search_Employee.Size = new System.Drawing.Size(108, 45);
            this.btn_Search_Employee.TabIndex = 110;
            this.btn_Search_Employee.Text = "Search ";
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
            this.txt_Employee_Id.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Employee_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Employee_Id.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txt_Employee_Id.Location = new System.Drawing.Point(258, 110);
            this.txt_Employee_Id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Employee_Id.Name = "txt_Employee_Id";
            this.txt_Employee_Id.PasswordChar = '\0';
            this.txt_Employee_Id.PlaceholderText = "Enter Promotion Id";
            this.txt_Employee_Id.SelectedText = "";
            this.txt_Employee_Id.Size = new System.Drawing.Size(228, 34);
            this.txt_Employee_Id.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 44);
            this.label1.TabIndex = 113;
            this.label1.Text = "View Promotion";
            // 
            // viewPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewPromotion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txt_Employee_Id;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Employee;
        private System.Windows.Forms.Label label1;
    }
}