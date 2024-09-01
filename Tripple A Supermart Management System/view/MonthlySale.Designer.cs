
namespace Tripple_A_Supermart_Management_System.view
{
    partial class MonthlySale
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
            this.btn_Generate_Monthly_Sale = new Guna.UI2.WinForms.Guna2Button();
            this.dirAdminDash = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dirAdminDash)).BeginInit();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 605);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btn_Generate_Monthly_Sale
            // 
            this.btn_Generate_Monthly_Sale.BorderThickness = 1;
            this.btn_Generate_Monthly_Sale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Monthly_Sale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Monthly_Sale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Generate_Monthly_Sale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Generate_Monthly_Sale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Generate_Monthly_Sale.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Generate_Monthly_Sale.ForeColor = System.Drawing.Color.Black;
            this.btn_Generate_Monthly_Sale.Location = new System.Drawing.Point(39, 294);
            this.btn_Generate_Monthly_Sale.Name = "btn_Generate_Monthly_Sale";
            this.btn_Generate_Monthly_Sale.Size = new System.Drawing.Size(108, 45);
            this.btn_Generate_Monthly_Sale.TabIndex = 151;
            this.btn_Generate_Monthly_Sale.Text = "Generate ";
            this.btn_Generate_Monthly_Sale.Click += new System.EventHandler(this.btn_Generate_Monthly_Sale_Click);
            // 
            // dirAdminDash
            // 
            this.dirAdminDash.BackColor = System.Drawing.Color.Transparent;
            this.dirAdminDash.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.dirAdminDash.ImageRotate = 0F;
            this.dirAdminDash.Location = new System.Drawing.Point(12, 513);
            this.dirAdminDash.Name = "dirAdminDash";
            this.dirAdminDash.Size = new System.Drawing.Size(33, 42);
            this.dirAdminDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dirAdminDash.TabIndex = 152;
            this.dirAdminDash.TabStop = false;
            this.dirAdminDash.UseTransparentBackground = true;
            this.dirAdminDash.Click += new System.EventHandler(this.dirAdminDash_Click);
            // 
            // MonthlySale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.dirAdminDash);
            this.Controls.Add(this.btn_Generate_Monthly_Sale);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlySale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthlySale";
            ((System.ComponentModel.ISupportInitialize)(this.dirAdminDash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI2.WinForms.Guna2Button btn_Generate_Monthly_Sale;
        private Guna.UI2.WinForms.Guna2PictureBox dirAdminDash;
    }
}