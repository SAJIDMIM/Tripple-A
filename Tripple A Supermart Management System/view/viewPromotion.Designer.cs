
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPromo = new System.Windows.Forms.DataGridView();
            this.txt_Promotion_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search_Promotion = new Guna.UI2.WinForms.Guna2Button();
            this.picDMDash = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDMDash)).BeginInit();
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
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.panel1.Controls.Add(this.dgvPromo);
            this.panel1.Controls.Add(this.txt_Promotion_Id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Search_Promotion);
            this.panel1.Location = new System.Drawing.Point(101, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 498);
            this.panel1.TabIndex = 85;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPromo
            // 
            this.dgvPromo.BackgroundColor = System.Drawing.Color.White;
            this.dgvPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromo.Location = new System.Drawing.Point(8, 169);
            this.dgvPromo.Name = "dgvPromo";
            this.dgvPromo.RowHeadersWidth = 62;
            this.dgvPromo.RowTemplate.Height = 28;
            this.dgvPromo.Size = new System.Drawing.Size(622, 309);
            this.dgvPromo.TabIndex = 112;
            this.dgvPromo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromo_CellContentClick);
            // 
            // txt_Promotion_Id
            // 
            this.txt_Promotion_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Promotion_Id.DefaultText = "";
            this.txt_Promotion_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Promotion_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Promotion_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Promotion_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Promotion_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Promotion_Id.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Promotion_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Promotion_Id.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txt_Promotion_Id.Location = new System.Drawing.Point(258, 110);
            this.txt_Promotion_Id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Promotion_Id.Name = "txt_Promotion_Id";
            this.txt_Promotion_Id.PasswordChar = '\0';
            this.txt_Promotion_Id.PlaceholderText = "Enter Promotion Id";
            this.txt_Promotion_Id.SelectedText = "";
            this.txt_Promotion_Id.Size = new System.Drawing.Size(228, 34);
            this.txt_Promotion_Id.TabIndex = 109;
            this.txt_Promotion_Id.TextChanged += new System.EventHandler(this.txt_Promotion_Id_TextChanged);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Search_Promotion
            // 
            this.btn_Search_Promotion.BorderThickness = 1;
            this.btn_Search_Promotion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Promotion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Promotion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Promotion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Promotion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Promotion.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Promotion.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Promotion.Location = new System.Drawing.Point(522, 99);
            this.btn_Search_Promotion.Name = "btn_Search_Promotion";
            this.btn_Search_Promotion.Size = new System.Drawing.Size(108, 45);
            this.btn_Search_Promotion.TabIndex = 110;
            this.btn_Search_Promotion.Text = "Search ";
            this.btn_Search_Promotion.Click += new System.EventHandler(this.btn_Search_Promotion_Click);
            // 
            // picDMDash
            // 
            this.picDMDash.BackColor = System.Drawing.Color.Transparent;
            this.picDMDash.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picDMDash.ImageRotate = 0F;
            this.picDMDash.Location = new System.Drawing.Point(12, 30);
            this.picDMDash.Name = "picDMDash";
            this.picDMDash.Size = new System.Drawing.Size(33, 42);
            this.picDMDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDMDash.TabIndex = 148;
            this.picDMDash.TabStop = false;
            this.picDMDash.UseTransparentBackground = true;
            this.picDMDash.Click += new System.EventHandler(this.picDMDash_Click);
            // 
            // viewPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 566);
            this.Controls.Add(this.picDMDash);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDMDash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPromo;
        private Guna.UI2.WinForms.Guna2TextBox txt_Promotion_Id;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Promotion;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox picDMDash;
    }
}