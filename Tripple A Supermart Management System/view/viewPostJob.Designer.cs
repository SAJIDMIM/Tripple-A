
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewPostJob
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPostJobId = new System.Windows.Forms.ComboBox();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picHRDish = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHRDish)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 134;
            this.label4.Text = "Post Job Id";
            // 
            // cmbPostJobId
            // 
            this.cmbPostJobId.FormattingEnabled = true;
            this.cmbPostJobId.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3",
            "P4",
            "P5"});
            this.cmbPostJobId.Location = new System.Drawing.Point(369, 150);
            this.cmbPostJobId.Name = "cmbPostJobId";
            this.cmbPostJobId.Size = new System.Drawing.Size(195, 28);
            this.cmbPostJobId.TabIndex = 135;
            this.cmbPostJobId.SelectedIndexChanged += new System.EventHandler(this.cmbPostJobId_SelectedIndexChanged);
            // 
            // dgvJobs
            // 
            this.dgvJobs.BackgroundColor = System.Drawing.Color.White;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(56, 214);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 62;
            this.dgvJobs.RowTemplate.Height = 28;
            this.dgvJobs.Size = new System.Drawing.Size(508, 334);
            this.dgvJobs.TabIndex = 136;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.How_to_post_a_job_on_Twitter_Blog_Image_1280x720;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 113);
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 44);
            this.label7.TabIndex = 138;
            this.label7.Text = "View Account";
            // 
            // picHRDish
            // 
            this.picHRDish.BackColor = System.Drawing.Color.Transparent;
            this.picHRDish.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picHRDish.ImageRotate = 0F;
            this.picHRDish.Location = new System.Drawing.Point(564, 38);
            this.picHRDish.Name = "picHRDish";
            this.picHRDish.Size = new System.Drawing.Size(33, 42);
            this.picHRDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHRDish.TabIndex = 145;
            this.picHRDish.TabStop = false;
            this.picHRDish.UseTransparentBackground = true;
            this.picHRDish.Click += new System.EventHandler(this.picHRDish_Click);
            // 
            // viewPostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 573);
            this.Controls.Add(this.picHRDish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.cmbPostJobId);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewPostJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewPostJob";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHRDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPostJobId;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox picHRDish;
    }
}