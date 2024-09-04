
namespace Tripple_A_Supermart_Management_System.view
{
    partial class viewHealthInsurance
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
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search_Health = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHealth = new System.Windows.Forms.DataGridView();
            this.txtHealthId = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picGoBackHR = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackHR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.dgvHealth);
            this.panel1.Controls.Add(this.btn_Search_Health);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHealthId);
            this.panel1.Location = new System.Drawing.Point(2, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 526);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-3, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 44);
            this.label8.TabIndex = 143;
            this.label8.Text = "View Health Insurance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 94;
            this.label3.Text = "Health Id";
            // 
            // btn_Search_Health
            // 
            this.btn_Search_Health.BorderThickness = 1;
            this.btn_Search_Health.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Health.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Health.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Health.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Health.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Health.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Health.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Health.Location = new System.Drawing.Point(565, 70);
            this.btn_Search_Health.Name = "btn_Search_Health";
            this.btn_Search_Health.Size = new System.Drawing.Size(94, 34);
            this.btn_Search_Health.TabIndex = 106;
            this.btn_Search_Health.Text = "Search ";
            this.btn_Search_Health.Click += new System.EventHandler(this.btn_Search_Health_Click);
            // 
            // dgvHealth
            // 
            this.dgvHealth.BackgroundColor = System.Drawing.Color.White;
            this.dgvHealth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealth.Location = new System.Drawing.Point(114, 136);
            this.dgvHealth.Name = "dgvHealth";
            this.dgvHealth.RowHeadersWidth = 62;
            this.dgvHealth.RowTemplate.Height = 28;
            this.dgvHealth.Size = new System.Drawing.Size(545, 319);
            this.dgvHealth.TabIndex = 107;
            // 
            // txtHealthId
            // 
            this.txtHealthId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHealthId.DefaultText = "";
            this.txtHealthId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHealthId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHealthId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHealthId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHealthId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHealthId.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtHealthId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHealthId.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.identification;
            this.txtHealthId.Location = new System.Drawing.Point(260, 70);
            this.txtHealthId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHealthId.Name = "txtHealthId";
            this.txtHealthId.PasswordChar = '\0';
            this.txtHealthId.PlaceholderText = "Enter Health Id";
            this.txtHealthId.SelectedText = "";
            this.txtHealthId.Size = new System.Drawing.Size(231, 34);
            this.txtHealthId.TabIndex = 84;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.health_insurance_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picGoBackHR
            // 
            this.picGoBackHR.BackColor = System.Drawing.Color.Transparent;
            this.picGoBackHR.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picGoBackHR.ImageRotate = 0F;
            this.picGoBackHR.Location = new System.Drawing.Point(738, 28);
            this.picGoBackHR.Name = "picGoBackHR";
            this.picGoBackHR.Size = new System.Drawing.Size(33, 42);
            this.picGoBackHR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoBackHR.TabIndex = 148;
            this.picGoBackHR.TabStop = false;
            this.picGoBackHR.UseTransparentBackground = true;
            this.picGoBackHR.Click += new System.EventHandler(this.picGoBackHR_Click);
            // 
            // viewHealthInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.picGoBackHR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewHealthInsurance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewHealthInsurance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackHR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtHealthId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHealth;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Health;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackHR;
    }
}