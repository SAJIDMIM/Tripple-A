
namespace Tripple_A_Supermart_Management_System.view
{
    partial class generateCustomerReport
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
            this.btn_Generate_Customer = new Guna.UI2.WinForms.Guna2Button();
            this.picGeneralDash = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGeneralDash)).BeginInit();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 597);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btn_Generate_Customer
            // 
            this.btn_Generate_Customer.BorderThickness = 1;
            this.btn_Generate_Customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Generate_Customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Generate_Customer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Generate_Customer.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Generate_Customer.ForeColor = System.Drawing.Color.Black;
            this.btn_Generate_Customer.Location = new System.Drawing.Point(42, 275);
            this.btn_Generate_Customer.Name = "btn_Generate_Customer";
            this.btn_Generate_Customer.Size = new System.Drawing.Size(112, 41);
            this.btn_Generate_Customer.TabIndex = 149;
            this.btn_Generate_Customer.Text = "Generate";
            this.btn_Generate_Customer.Click += new System.EventHandler(this.btn_Generate_Customer_Click);
            // 
            // picGeneralDash
            // 
            this.picGeneralDash.BackColor = System.Drawing.Color.Transparent;
            this.picGeneralDash.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picGeneralDash.ImageRotate = 0F;
            this.picGeneralDash.Location = new System.Drawing.Point(12, 505);
            this.picGeneralDash.Name = "picGeneralDash";
            this.picGeneralDash.Size = new System.Drawing.Size(33, 42);
            this.picGeneralDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGeneralDash.TabIndex = 152;
            this.picGeneralDash.TabStop = false;
            this.picGeneralDash.UseTransparentBackground = true;
            this.picGeneralDash.Click += new System.EventHandler(this.picGeneralDash_Click);
            // 
            // generateCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.picGeneralDash);
            this.Controls.Add(this.btn_Generate_Customer);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "generateCustomerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "generateCustomerReport";
            ((System.ComponentModel.ISupportInitialize)(this.picGeneralDash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI2.WinForms.Guna2Button btn_Generate_Customer;
        private Guna.UI2.WinForms.Guna2PictureBox picGeneralDash;
    }
}