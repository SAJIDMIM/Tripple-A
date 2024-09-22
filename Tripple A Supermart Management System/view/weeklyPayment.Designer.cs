
namespace Tripple_A_Supermart_Management_System.view
{
    partial class weeklyPayment
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
            this.pic_Cash_Dash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Generate_Weekly_Payment = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cash_Dash)).BeginInit();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(852, 611);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // pic_Cash_Dash
            // 
            this.pic_Cash_Dash.BackColor = System.Drawing.Color.Transparent;
            this.pic_Cash_Dash.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.pic_Cash_Dash.ImageRotate = 0F;
            this.pic_Cash_Dash.Location = new System.Drawing.Point(18, 519);
            this.pic_Cash_Dash.Name = "pic_Cash_Dash";
            this.pic_Cash_Dash.Size = new System.Drawing.Size(33, 42);
            this.pic_Cash_Dash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Cash_Dash.TabIndex = 153;
            this.pic_Cash_Dash.TabStop = false;
            this.pic_Cash_Dash.UseTransparentBackground = true;
            this.pic_Cash_Dash.Click += new System.EventHandler(this.pic_Cash_Dash_Click);
            // 
            // btn_Generate_Weekly_Payment
            // 
            this.btn_Generate_Weekly_Payment.BorderThickness = 1;
            this.btn_Generate_Weekly_Payment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Weekly_Payment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Weekly_Payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Generate_Weekly_Payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Generate_Weekly_Payment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Generate_Weekly_Payment.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Generate_Weekly_Payment.ForeColor = System.Drawing.Color.Black;
            this.btn_Generate_Weekly_Payment.Location = new System.Drawing.Point(52, 320);
            this.btn_Generate_Weekly_Payment.Name = "btn_Generate_Weekly_Payment";
            this.btn_Generate_Weekly_Payment.Size = new System.Drawing.Size(108, 45);
            this.btn_Generate_Weekly_Payment.TabIndex = 152;
            this.btn_Generate_Weekly_Payment.Text = "Generate ";
            this.btn_Generate_Weekly_Payment.Click += new System.EventHandler(this.btn_Generate_Weekly_Payment_Click);
            // 
            // weeklyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 611);
            this.Controls.Add(this.pic_Cash_Dash);
            this.Controls.Add(this.btn_Generate_Weekly_Payment);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "weeklyPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "weeklyPayment";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cash_Dash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Cash_Dash;
        private Guna.UI2.WinForms.Guna2Button btn_Generate_Weekly_Payment;
    }
}