
namespace Tripple_A_Supermart_Management_System.view
{
    partial class CashFlow
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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btn_Search_Cash_Flow = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.picGoBackAccDash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackAccDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.dgvAccount);
            this.panel1.Controls.Add(this.btn_Search_Cash_Flow);
            this.panel1.Controls.Add(this.txtAccountNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(95, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 415);
            this.panel1.TabIndex = 154;
            // 
            // dgvAccount
            // 
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(32, 108);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.RowTemplate.Height = 28;
            this.dgvAccount.Size = new System.Drawing.Size(550, 285);
            this.dgvAccount.TabIndex = 149;
            // 
            // btn_Search_Cash_Flow
            // 
            this.btn_Search_Cash_Flow.BorderThickness = 1;
            this.btn_Search_Cash_Flow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Cash_Flow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Cash_Flow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Cash_Flow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Cash_Flow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Cash_Flow.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Cash_Flow.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Cash_Flow.Location = new System.Drawing.Point(488, 49);
            this.btn_Search_Cash_Flow.Name = "btn_Search_Cash_Flow";
            this.btn_Search_Cash_Flow.Size = new System.Drawing.Size(94, 34);
            this.btn_Search_Cash_Flow.TabIndex = 148;
            this.btn_Search_Cash_Flow.Text = "Search ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 94;
            this.label3.Text = "Account Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 44);
            this.label7.TabIndex = 153;
            this.label7.Text = "Show Cash Flow";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.business;
            this.txtAccountNumber.Location = new System.Drawing.Point(237, 49);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderText = "Enter Account Number";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.Size = new System.Drawing.Size(230, 34);
            this.txtAccountNumber.TabIndex = 147;
            // 
            // picGoBackAccDash
            // 
            this.picGoBackAccDash.BackColor = System.Drawing.Color.Transparent;
            this.picGoBackAccDash.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picGoBackAccDash.ImageRotate = 0F;
            this.picGoBackAccDash.Location = new System.Drawing.Point(23, 515);
            this.picGoBackAccDash.Name = "picGoBackAccDash";
            this.picGoBackAccDash.Size = new System.Drawing.Size(33, 42);
            this.picGoBackAccDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoBackAccDash.TabIndex = 155;
            this.picGoBackAccDash.TabStop = false;
            this.picGoBackAccDash.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.images__4_1;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 152;
            this.pictureBox1.TabStop = false;
            // 
            // CashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picGoBackAccDash);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashFlow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackAccDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Cash_Flow;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackAccDash;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}