
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewCustomerOrder
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
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.picGoBackSaleDash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Search_Order = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackSaleDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.dgvOrderDetails);
            this.panel1.Controls.Add(this.picGoBackSaleDash);
            this.panel1.Controls.Add(this.btn_Search_Order);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOrderId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(47, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 480);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(40, 172);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 62;
            this.dgvOrderDetails.RowTemplate.Height = 28;
            this.dgvOrderDetails.Size = new System.Drawing.Size(514, 294);
            this.dgvOrderDetails.TabIndex = 147;
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
            // 
            // btn_Search_Order
            // 
            this.btn_Search_Order.BorderThickness = 1;
            this.btn_Search_Order.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Order.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Order.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Order.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Order.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Order.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Order.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Order.Location = new System.Drawing.Point(460, 114);
            this.btn_Search_Order.Name = "btn_Search_Order";
            this.btn_Search_Order.Size = new System.Drawing.Size(94, 34);
            this.btn_Search_Order.TabIndex = 105;
            this.btn_Search_Order.Text = "Search ";
            this.btn_Search_Order.Click += new System.EventHandler(this.btn_Search_Order_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 93;
            this.label3.Text = "Order Id";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderId.DefaultText = "";
            this.txtOrderId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrderId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrderId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderId.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtOrderId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderId.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.package;
            this.txtOrderId.Location = new System.Drawing.Point(150, 114);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.PasswordChar = '\0';
            this.txtOrderId.PlaceholderText = "Enter Order Id";
            this.txtOrderId.SelectedText = "";
            this.txtOrderId.Size = new System.Drawing.Size(289, 34);
            this.txtOrderId.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 44);
            this.label7.TabIndex = 82;
            this.label7.Text = "View Customer Order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.pngtree_transparent_order_now_png_png_image_61170141;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 575);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // viewCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewCustomerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewCustomerOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackSaleDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackSaleDash;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Order;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}