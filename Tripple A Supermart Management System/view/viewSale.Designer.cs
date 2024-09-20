
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewSale
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
            this.dgvSaleDetails = new System.Windows.Forms.DataGridView();
            this.picGoBackSaleDash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Search_Sale = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaleId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackSaleDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.dgvSaleDetails);
            this.panel1.Controls.Add(this.picGoBackSaleDash);
            this.panel1.Controls.Add(this.btn_Search_Sale);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSaleId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(72, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 458);
            this.panel1.TabIndex = 3;
            // 
            // dgvSaleDetails
            // 
            this.dgvSaleDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleDetails.Location = new System.Drawing.Point(40, 172);
            this.dgvSaleDetails.Name = "dgvSaleDetails";
            this.dgvSaleDetails.RowHeadersWidth = 62;
            this.dgvSaleDetails.RowTemplate.Height = 28;
            this.dgvSaleDetails.Size = new System.Drawing.Size(514, 253);
            this.dgvSaleDetails.TabIndex = 147;
            // 
            // picGoBackSaleDash
            // 
            this.picGoBackSaleDash.BackColor = System.Drawing.Color.Transparent;
            this.picGoBackSaleDash.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picGoBackSaleDash.ImageRotate = 0F;
            this.picGoBackSaleDash.Location = new System.Drawing.Point(22, 15);
            this.picGoBackSaleDash.Name = "picGoBackSaleDash";
            this.picGoBackSaleDash.Size = new System.Drawing.Size(33, 42);
            this.picGoBackSaleDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoBackSaleDash.TabIndex = 146;
            this.picGoBackSaleDash.TabStop = false;
            this.picGoBackSaleDash.UseTransparentBackground = true;
            this.picGoBackSaleDash.Click += new System.EventHandler(this.picGoBackSaleDash_Click);
            // 
            // btn_Search_Sale
            // 
            this.btn_Search_Sale.BorderThickness = 1;
            this.btn_Search_Sale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Sale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Sale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Sale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Sale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Sale.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Sale.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Sale.Location = new System.Drawing.Point(460, 114);
            this.btn_Search_Sale.Name = "btn_Search_Sale";
            this.btn_Search_Sale.Size = new System.Drawing.Size(94, 34);
            this.btn_Search_Sale.TabIndex = 105;
            this.btn_Search_Sale.Text = "Search ";
            this.btn_Search_Sale.Click += new System.EventHandler(this.btn_Search_Sale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 93;
            this.label3.Text = "Sale Id";
            // 
            // txtSaleId
            // 
            this.txtSaleId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaleId.DefaultText = "";
            this.txtSaleId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSaleId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSaleId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSaleId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSaleId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSaleId.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSaleId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSaleId.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.shop;
            this.txtSaleId.Location = new System.Drawing.Point(133, 114);
            this.txtSaleId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaleId.Name = "txtSaleId";
            this.txtSaleId.PasswordChar = '\0';
            this.txtSaleId.PlaceholderText = "Enter Sale Id";
            this.txtSaleId.SelectedText = "";
            this.txtSaleId.Size = new System.Drawing.Size(309, 34);
            this.txtSaleId.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(207, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 44);
            this.label7.TabIndex = 82;
            this.label7.Text = "View Sale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.Sale_label_PNG_pngimagesfree_com__1;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // viewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewSale";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackSaleDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSaleDetails;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackSaleDash;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Sale;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSaleId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}