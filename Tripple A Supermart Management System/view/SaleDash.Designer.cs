
namespace Tripple_A_Supermart_Management_System.view
{
    partial class SaleDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDash));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.monToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monToolStripMenuItem,
            this.createSaleToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // monToolStripMenuItem
            // 
            this.monToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveryToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.productToolStripMenuItem,
            this.itemToolStripMenuItem});
            this.monToolStripMenuItem.Name = "monToolStripMenuItem";
            this.monToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.monToolStripMenuItem.Text = "Monitor";
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            this.deliveryToolStripMenuItem.Click += new System.EventHandler(this.deliveryToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.itemToolStripMenuItem.Text = "Item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // createSaleToolStripMenuItem
            // 
            this.createSaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem1,
            this.saleReportToolStripMenuItem});
            this.createSaleToolStripMenuItem.Name = "createSaleToolStripMenuItem";
            this.createSaleToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.createSaleToolStripMenuItem.Text = "Create";
            // 
            // saleToolStripMenuItem1
            // 
            this.saleToolStripMenuItem1.Name = "saleToolStripMenuItem1";
            this.saleToolStripMenuItem1.Size = new System.Drawing.Size(204, 34);
            this.saleToolStripMenuItem1.Text = "Sale";
            this.saleToolStripMenuItem1.Click += new System.EventHandler(this.saleToolStripMenuItem1_Click);
            // 
            // saleReportToolStripMenuItem
            // 
            this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
            this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.saleReportToolStripMenuItem.Text = "Sale Report";
            this.saleReportToolStripMenuItem.Click += new System.EventHandler(this.saleReportToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerOrderToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.updateProfileToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // customerOrderToolStripMenuItem
            // 
            this.customerOrderToolStripMenuItem.Name = "customerOrderToolStripMenuItem";
            this.customerOrderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.customerOrderToolStripMenuItem.Text = "Customer Order";
            this.customerOrderToolStripMenuItem.Click += new System.EventHandler(this.customerOrderToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 44);
            this.label7.TabIndex = 83;
            this.label7.Text = "Sale Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.images__5_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 2;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(253, 186);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(298, 169);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 85;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // SaleDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(606, 514);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SaleDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleDash";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem monToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
    }
}