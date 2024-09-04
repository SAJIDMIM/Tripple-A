
namespace Tripple_A_Supermart_Management_System.view
{
    partial class MonthlyEmployee
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Generate_Monthly_Employee = new Guna.UI2.WinForms.Guna2Button();
            this.HrDash = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HrDash)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 635);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btn_Generate_Monthly_Employee
            // 
            this.btn_Generate_Monthly_Employee.BorderThickness = 1;
            this.btn_Generate_Monthly_Employee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Monthly_Employee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Monthly_Employee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Generate_Monthly_Employee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Generate_Monthly_Employee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Generate_Monthly_Employee.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Generate_Monthly_Employee.ForeColor = System.Drawing.Color.Black;
            this.btn_Generate_Monthly_Employee.Location = new System.Drawing.Point(42, 308);
            this.btn_Generate_Monthly_Employee.Name = "btn_Generate_Monthly_Employee";
            this.btn_Generate_Monthly_Employee.Size = new System.Drawing.Size(108, 45);
            this.btn_Generate_Monthly_Employee.TabIndex = 152;
            this.btn_Generate_Monthly_Employee.Text = "Generate ";
            this.btn_Generate_Monthly_Employee.Click += new System.EventHandler(this.btn_Generate_Monthly_Employee_Click);
            // 
            // HrDash
            // 
            this.HrDash.BackColor = System.Drawing.Color.Transparent;
            this.HrDash.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.HrDash.ImageRotate = 0F;
            this.HrDash.Location = new System.Drawing.Point(12, 546);
            this.HrDash.Name = "HrDash";
            this.HrDash.Size = new System.Drawing.Size(33, 42);
            this.HrDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HrDash.TabIndex = 153;
            this.HrDash.TabStop = false;
            this.HrDash.UseTransparentBackground = true;
            this.HrDash.Click += new System.EventHandler(this.HrDash_Click);
            // 
            // MonthlyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.HrDash);
            this.Controls.Add(this.btn_Generate_Monthly_Employee);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeReport";
            ((System.ComponentModel.ISupportInitialize)(this.HrDash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI2.WinForms.Guna2Button btn_Generate_Monthly_Employee;
        private Guna.UI2.WinForms.Guna2PictureBox HrDash;
    }
}