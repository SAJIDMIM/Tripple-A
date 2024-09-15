
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewItems
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.picGoBackStr = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Search_Item = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Item_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.dgvItems);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.picGoBackStr);
            this.panel3.Controls.Add(this.btn_Search_Item);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_Item_Id);
            this.panel3.Location = new System.Drawing.Point(42, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 478);
            this.panel3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(230, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 44);
            this.label7.TabIndex = 148;
            this.label7.Text = "View Item";
            // 
            // picGoBackStr
            // 
            this.picGoBackStr.BackColor = System.Drawing.Color.Transparent;
            this.picGoBackStr.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picGoBackStr.ImageRotate = 0F;
            this.picGoBackStr.Location = new System.Drawing.Point(17, 28);
            this.picGoBackStr.Name = "picGoBackStr";
            this.picGoBackStr.Size = new System.Drawing.Size(33, 42);
            this.picGoBackStr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoBackStr.TabIndex = 146;
            this.picGoBackStr.TabStop = false;
            this.picGoBackStr.UseTransparentBackground = true;
            this.picGoBackStr.Click += new System.EventHandler(this.picGoBackStr_Click);
            // 
            // btn_Search_Item
            // 
            this.btn_Search_Item.BorderThickness = 1;
            this.btn_Search_Item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Item.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Item.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Item.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Item.Location = new System.Drawing.Point(471, 115);
            this.btn_Search_Item.Name = "btn_Search_Item";
            this.btn_Search_Item.Size = new System.Drawing.Size(108, 45);
            this.btn_Search_Item.TabIndex = 105;
            this.btn_Search_Item.Text = "Search ";
            this.btn_Search_Item.Click += new System.EventHandler(this.btn_Search_Item_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 93;
            this.label3.Text = "Item Id";
            // 
            // txt_Item_Id
            // 
            this.txt_Item_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Item_Id.DefaultText = "";
            this.txt_Item_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Item_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Item_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Item_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Item_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Item_Id.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Item_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Item_Id.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.list_items;
            this.txt_Item_Id.Location = new System.Drawing.Point(162, 126);
            this.txt_Item_Id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Item_Id.Name = "txt_Item_Id";
            this.txt_Item_Id.PasswordChar = '\0';
            this.txt_Item_Id.PlaceholderText = "Enter Item Id";
            this.txt_Item_Id.SelectedText = "";
            this.txt_Item_Id.Size = new System.Drawing.Size(267, 34);
            this.txt_Item_Id.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.pngtree_vector_modern_new_item_label_png_image_6527461;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvItems
            // 
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(51, 193);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.RowTemplate.Height = 28;
            this.dgvItems.Size = new System.Drawing.Size(528, 268);
            this.dgvItems.TabIndex = 149;
            // 
            // viewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewItems";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackStr;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Item;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Item_Id;
        private System.Windows.Forms.DataGridView dgvItems;
    }
}