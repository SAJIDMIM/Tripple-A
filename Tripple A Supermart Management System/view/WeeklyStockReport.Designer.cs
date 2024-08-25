
namespace Tripple_A_Supermart_Management_System.view
{
    partial class WeeklyStockReport
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
            this.btn_Generate_Weekly_Stock = new Guna.UI2.WinForms.Guna2Button();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(805, 599);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btn_Generate_Weekly_Stock
            // 
            this.btn_Generate_Weekly_Stock.BorderThickness = 1;
            this.btn_Generate_Weekly_Stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Weekly_Stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Generate_Weekly_Stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Generate_Weekly_Stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Generate_Weekly_Stock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Generate_Weekly_Stock.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Generate_Weekly_Stock.ForeColor = System.Drawing.Color.Black;
            this.btn_Generate_Weekly_Stock.Location = new System.Drawing.Point(46, 307);
            this.btn_Generate_Weekly_Stock.Name = "btn_Generate_Weekly_Stock";
            this.btn_Generate_Weekly_Stock.Size = new System.Drawing.Size(108, 45);
            this.btn_Generate_Weekly_Stock.TabIndex = 150;
            this.btn_Generate_Weekly_Stock.Text = "Generate ";
            this.btn_Generate_Weekly_Stock.Click += new System.EventHandler(this.btn_Generate_Weekly_Stock_Click);
            // 
            // WeeklyStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 599);
            this.Controls.Add(this.btn_Generate_Weekly_Stock);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WeeklyStockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI2.WinForms.Guna2Button btn_Generate_Weekly_Stock;
    }
}