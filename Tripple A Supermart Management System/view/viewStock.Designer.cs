﻿
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewStock
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.picGoBackStr = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Search_Item = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Stock_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.dgvStock);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.picGoBackStr);
            this.panel1.Controls.Add(this.btn_Search_Item);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Stock_Id);
            this.panel1.Location = new System.Drawing.Point(185, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 613);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 44);
            this.label7.TabIndex = 154;
            this.label7.Text = "View Stock ";
            // 
            // picGoBackStr
            // 
            this.picGoBackStr.BackColor = System.Drawing.Color.Transparent;
            this.picGoBackStr.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picGoBackStr.ImageRotate = 0F;
            this.picGoBackStr.Location = new System.Drawing.Point(31, 22);
            this.picGoBackStr.Name = "picGoBackStr";
            this.picGoBackStr.Size = new System.Drawing.Size(33, 42);
            this.picGoBackStr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoBackStr.TabIndex = 153;
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
            this.btn_Search_Item.Location = new System.Drawing.Point(424, 150);
            this.btn_Search_Item.Name = "btn_Search_Item";
            this.btn_Search_Item.Size = new System.Drawing.Size(108, 34);
            this.btn_Search_Item.TabIndex = 152;
            this.btn_Search_Item.Text = "Search ";
            this.btn_Search_Item.Click += new System.EventHandler(this.btn_Search_Item_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 151;
            this.label3.Text = "Stock Id";
            // 
            // txt_Stock_Id
            // 
            this.txt_Stock_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Stock_Id.DefaultText = "";
            this.txt_Stock_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Stock_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Stock_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Id.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Stock_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Id.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.txt_Stock_Id.Location = new System.Drawing.Point(148, 150);
            this.txt_Stock_Id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Stock_Id.Name = "txt_Stock_Id";
            this.txt_Stock_Id.PasswordChar = '\0';
            this.txt_Stock_Id.PlaceholderText = "Enter Stock Id";
            this.txt_Stock_Id.SelectedText = "";
            this.txt_Stock_Id.Size = new System.Drawing.Size(244, 34);
            this.txt_Stock_Id.TabIndex = 150;
            // 
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(31, 203);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(501, 385);
            this.dgvStock.TabIndex = 155;
            // 
            // viewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewStock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackStr;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Item;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Stock_Id;
        private System.Windows.Forms.DataGridView dgvStock;
    }
}