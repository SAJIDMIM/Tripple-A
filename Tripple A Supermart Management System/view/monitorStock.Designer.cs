
namespace Tripple_A_Supermart_Management_System.view
{
    partial class monitorStock
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Stock_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Stock_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Stock_Qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Stock_Cost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Supplier_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Stock_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbStockType = new System.Windows.Forms.ComboBox();
            this.cmbStockWeight = new System.Windows.Forms.ComboBox();
            this.cmbReorderLevel = new System.Windows.Forms.ComboBox();
            this.dtp_Stock_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Last_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Add_Stock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Clear_Stock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Delete_Stock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Update_Stock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Search_Stock = new Guna.UI2.WinForms.Guna2Button();
            this.label13 = new System.Windows.Forms.Label();
            this.picGoBackStr = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackStr)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 711);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 153;
            this.label3.Text = "Stock Id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.txt_Stock_Id.Location = new System.Drawing.Point(201, 166);
            this.txt_Stock_Id.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Stock_Id.Name = "txt_Stock_Id";
            this.txt_Stock_Id.PasswordChar = '\0';
            this.txt_Stock_Id.PlaceholderText = "Enter Stock Id";
            this.txt_Stock_Id.SelectedText = "";
            this.txt_Stock_Id.Size = new System.Drawing.Size(244, 34);
            this.txt_Stock_Id.TabIndex = 152;
            this.txt_Stock_Id.TextChanged += new System.EventHandler(this.txt_Product_Id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 155;
            this.label1.Text = "Stock Name";
            // 
            // txt_Stock_Name
            // 
            this.txt_Stock_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Stock_Name.DefaultText = "";
            this.txt_Stock_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Stock_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Stock_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Name.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Stock_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Name.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.txt_Stock_Name.Location = new System.Drawing.Point(201, 293);
            this.txt_Stock_Name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Stock_Name.Name = "txt_Stock_Name";
            this.txt_Stock_Name.PasswordChar = '\0';
            this.txt_Stock_Name.PlaceholderText = "Enter Stock Name";
            this.txt_Stock_Name.SelectedText = "";
            this.txt_Stock_Name.Size = new System.Drawing.Size(244, 34);
            this.txt_Stock_Name.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 157;
            this.label2.Text = "Stock Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 29);
            this.label4.TabIndex = 159;
            this.label4.Text = "Stock Quantity";
            // 
            // txt_Stock_Qty
            // 
            this.txt_Stock_Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Stock_Qty.DefaultText = "";
            this.txt_Stock_Qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Stock_Qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Stock_Qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Qty.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Stock_Qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Qty.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.txt_Stock_Qty.Location = new System.Drawing.Point(201, 535);
            this.txt_Stock_Qty.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Stock_Qty.Name = "txt_Stock_Qty";
            this.txt_Stock_Qty.PasswordChar = '\0';
            this.txt_Stock_Qty.PlaceholderText = "Enter Stock Quantity";
            this.txt_Stock_Qty.SelectedText = "";
            this.txt_Stock_Qty.Size = new System.Drawing.Size(244, 34);
            this.txt_Stock_Qty.TabIndex = 158;
            this.txt_Stock_Qty.TextChanged += new System.EventHandler(this.txt_Stock_Qty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 161;
            this.label5.Text = "Stock Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 163;
            this.label6.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.txtLocation.Location = new System.Drawing.Point(549, 166);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderText = "Enter Location";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(244, 34);
            this.txtLocation.TabIndex = 162;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 29);
            this.label7.TabIndex = 165;
            this.label7.Text = "Cost";
            // 
            // txt_Stock_Cost
            // 
            this.txt_Stock_Cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Stock_Cost.DefaultText = "";
            this.txt_Stock_Cost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Stock_Cost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Stock_Cost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Cost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Cost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Cost.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Stock_Cost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Cost.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.txt_Stock_Cost.Location = new System.Drawing.Point(549, 293);
            this.txt_Stock_Cost.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Stock_Cost.Name = "txt_Stock_Cost";
            this.txt_Stock_Cost.PasswordChar = '\0';
            this.txt_Stock_Cost.PlaceholderText = "Enter Stock Cost";
            this.txt_Stock_Cost.SelectedText = "";
            this.txt_Stock_Cost.Size = new System.Drawing.Size(244, 34);
            this.txt_Stock_Cost.TabIndex = 164;
            this.txt_Stock_Cost.TextChanged += new System.EventHandler(this.txt_Stock_Cost_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 29);
            this.label8.TabIndex = 167;
            this.label8.Text = "Supplier Name";
            // 
            // txt_Supplier_Name
            // 
            this.txt_Supplier_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Supplier_Name.DefaultText = "";
            this.txt_Supplier_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Supplier_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Supplier_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Supplier_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Supplier_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Supplier_Name.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Supplier_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Supplier_Name.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.txt_Supplier_Name.Location = new System.Drawing.Point(549, 410);
            this.txt_Supplier_Name.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Supplier_Name.Name = "txt_Supplier_Name";
            this.txt_Supplier_Name.PasswordChar = '\0';
            this.txt_Supplier_Name.PlaceholderText = "Enter Supplier Name";
            this.txt_Supplier_Name.SelectedText = "";
            this.txt_Supplier_Name.Size = new System.Drawing.Size(244, 34);
            this.txt_Supplier_Name.TabIndex = 166;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(544, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 29);
            this.label9.TabIndex = 169;
            this.label9.Text = "Reorder Level";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(544, 597);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 29);
            this.label10.TabIndex = 171;
            this.label10.Text = "Stock Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(907, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 29);
            this.label11.TabIndex = 173;
            this.label11.Text = "Last Date Updated";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(907, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 29);
            this.label12.TabIndex = 175;
            this.label12.Text = "Stock Description";
            // 
            // txt_Stock_Description
            // 
            this.txt_Stock_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Stock_Description.DefaultText = "";
            this.txt_Stock_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Stock_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Stock_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stock_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Description.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Stock_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stock_Description.IconLeft = global::Tripple_A_Supermart_Management_System.Properties.Resources.ready_stock;
            this.txt_Stock_Description.Location = new System.Drawing.Point(912, 293);
            this.txt_Stock_Description.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_Stock_Description.Name = "txt_Stock_Description";
            this.txt_Stock_Description.PasswordChar = '\0';
            this.txt_Stock_Description.PlaceholderText = "Enter Stock Description";
            this.txt_Stock_Description.SelectedText = "";
            this.txt_Stock_Description.Size = new System.Drawing.Size(244, 116);
            this.txt_Stock_Description.TabIndex = 174;
            // 
            // cmbStockType
            // 
            this.cmbStockType.FormattingEnabled = true;
            this.cmbStockType.Items.AddRange(new object[] {
            "Fruit",
            "Vejetable",
            "Meat",
            "Beverage",
            "Diary",
            "Grain"});
            this.cmbStockType.Location = new System.Drawing.Point(201, 416);
            this.cmbStockType.Name = "cmbStockType";
            this.cmbStockType.Size = new System.Drawing.Size(109, 28);
            this.cmbStockType.TabIndex = 176;
            // 
            // cmbStockWeight
            // 
            this.cmbStockWeight.FormattingEnabled = true;
            this.cmbStockWeight.Items.AddRange(new object[] {
            "10kg",
            "5kg",
            "2kg",
            "500g",
            "2L",
            "1L"});
            this.cmbStockWeight.Location = new System.Drawing.Point(201, 648);
            this.cmbStockWeight.Name = "cmbStockWeight";
            this.cmbStockWeight.Size = new System.Drawing.Size(109, 28);
            this.cmbStockWeight.TabIndex = 177;
            // 
            // cmbReorderLevel
            // 
            this.cmbReorderLevel.FormattingEnabled = true;
            this.cmbReorderLevel.Items.AddRange(new object[] {
            "50",
            "30",
            "80",
            "25",
            "20",
            "40",
            "30"});
            this.cmbReorderLevel.Location = new System.Drawing.Point(549, 541);
            this.cmbReorderLevel.Name = "cmbReorderLevel";
            this.cmbReorderLevel.Size = new System.Drawing.Size(109, 28);
            this.cmbReorderLevel.TabIndex = 178;
            this.cmbReorderLevel.SelectedIndexChanged += new System.EventHandler(this.cmbReorderLevel_SelectedIndexChanged);
            // 
            // dtp_Stock_Date
            // 
            this.dtp_Stock_Date.Location = new System.Drawing.Point(549, 649);
            this.dtp_Stock_Date.Name = "dtp_Stock_Date";
            this.dtp_Stock_Date.Size = new System.Drawing.Size(244, 26);
            this.dtp_Stock_Date.TabIndex = 179;
            // 
            // dtp_Last_Date
            // 
            this.dtp_Last_Date.Location = new System.Drawing.Point(912, 166);
            this.dtp_Last_Date.Name = "dtp_Last_Date";
            this.dtp_Last_Date.Size = new System.Drawing.Size(244, 26);
            this.dtp_Last_Date.TabIndex = 180;
            this.dtp_Last_Date.ValueChanged += new System.EventHandler(this.dtp_Last_Date_ValueChanged);
            // 
            // btn_Add_Stock
            // 
            this.btn_Add_Stock.BorderThickness = 1;
            this.btn_Add_Stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_Stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_Stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add_Stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add_Stock.FillColor = System.Drawing.Color.Aqua;
            this.btn_Add_Stock.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Add_Stock.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_Stock.Location = new System.Drawing.Point(912, 441);
            this.btn_Add_Stock.Name = "btn_Add_Stock";
            this.btn_Add_Stock.Size = new System.Drawing.Size(108, 47);
            this.btn_Add_Stock.TabIndex = 181;
            this.btn_Add_Stock.Text = "Add";
            this.btn_Add_Stock.Click += new System.EventHandler(this.btn_Add_Stock_Click);
            // 
            // btn_Clear_Stock
            // 
            this.btn_Clear_Stock.BorderThickness = 1;
            this.btn_Clear_Stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear_Stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear_Stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Clear_Stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Clear_Stock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Clear_Stock.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Clear_Stock.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear_Stock.Location = new System.Drawing.Point(1048, 522);
            this.btn_Clear_Stock.Name = "btn_Clear_Stock";
            this.btn_Clear_Stock.Size = new System.Drawing.Size(108, 47);
            this.btn_Clear_Stock.TabIndex = 182;
            this.btn_Clear_Stock.Text = "Clear";
            // 
            // btn_Delete_Stock
            // 
            this.btn_Delete_Stock.BorderThickness = 1;
            this.btn_Delete_Stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete_Stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Delete_Stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Delete_Stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Delete_Stock.FillColor = System.Drawing.Color.Red;
            this.btn_Delete_Stock.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Delete_Stock.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete_Stock.Location = new System.Drawing.Point(912, 522);
            this.btn_Delete_Stock.Name = "btn_Delete_Stock";
            this.btn_Delete_Stock.Size = new System.Drawing.Size(108, 47);
            this.btn_Delete_Stock.TabIndex = 183;
            this.btn_Delete_Stock.Text = "Delete";
            this.btn_Delete_Stock.Click += new System.EventHandler(this.btn_Delete_Stock_Click);
            // 
            // btn_Update_Stock
            // 
            this.btn_Update_Stock.BorderThickness = 1;
            this.btn_Update_Stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update_Stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update_Stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update_Stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update_Stock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Update_Stock.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Update_Stock.ForeColor = System.Drawing.Color.Black;
            this.btn_Update_Stock.Location = new System.Drawing.Point(1048, 441);
            this.btn_Update_Stock.Name = "btn_Update_Stock";
            this.btn_Update_Stock.Size = new System.Drawing.Size(108, 47);
            this.btn_Update_Stock.TabIndex = 184;
            this.btn_Update_Stock.Text = "Update";
            this.btn_Update_Stock.Click += new System.EventHandler(this.btn_Update_Stock_Click);
            // 
            // btn_Search_Stock
            // 
            this.btn_Search_Stock.BorderThickness = 1;
            this.btn_Search_Stock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Stock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search_Stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search_Stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search_Stock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Search_Stock.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Search_Stock.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Stock.Location = new System.Drawing.Point(337, 109);
            this.btn_Search_Stock.Name = "btn_Search_Stock";
            this.btn_Search_Stock.Size = new System.Drawing.Size(108, 34);
            this.btn_Search_Stock.TabIndex = 185;
            this.btn_Search_Stock.Text = "Search ";
            this.btn_Search_Stock.Click += new System.EventHandler(this.btn_Search_Stock_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(557, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 44);
            this.label13.TabIndex = 186;
            this.label13.Text = "Monitor Stock";
            // 
            // picGoBackStr
            // 
            this.picGoBackStr.BackColor = System.Drawing.Color.Transparent;
            this.picGoBackStr.Image = global::Tripple_A_Supermart_Management_System.Properties.Resources.home;
            this.picGoBackStr.ImageRotate = 0F;
            this.picGoBackStr.Location = new System.Drawing.Point(21, 24);
            this.picGoBackStr.Name = "picGoBackStr";
            this.picGoBackStr.Size = new System.Drawing.Size(25, 42);
            this.picGoBackStr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGoBackStr.TabIndex = 187;
            this.picGoBackStr.TabStop = false;
            this.picGoBackStr.UseTransparentBackground = true;
            this.picGoBackStr.Click += new System.EventHandler(this.picGoBackStr_Click);
            // 
            // monitorStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 699);
            this.Controls.Add(this.picGoBackStr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_Search_Stock);
            this.Controls.Add(this.btn_Update_Stock);
            this.Controls.Add(this.btn_Delete_Stock);
            this.Controls.Add(this.btn_Clear_Stock);
            this.Controls.Add(this.btn_Add_Stock);
            this.Controls.Add(this.dtp_Last_Date);
            this.Controls.Add(this.dtp_Stock_Date);
            this.Controls.Add(this.cmbReorderLevel);
            this.Controls.Add(this.cmbStockWeight);
            this.Controls.Add(this.cmbStockType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Stock_Description);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Supplier_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Stock_Cost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Stock_Qty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Stock_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Stock_Id);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "monitorStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "monitorStock";
            this.Load += new System.EventHandler(this.monitorStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBackStr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Stock_Id;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Stock_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_Stock_Qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_Stock_Cost;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_Supplier_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_Stock_Description;
        private System.Windows.Forms.ComboBox cmbStockType;
        private System.Windows.Forms.ComboBox cmbStockWeight;
        private System.Windows.Forms.ComboBox cmbReorderLevel;
        private System.Windows.Forms.DateTimePicker dtp_Stock_Date;
        private System.Windows.Forms.DateTimePicker dtp_Last_Date;
        private Guna.UI2.WinForms.Guna2Button btn_Add_Stock;
        private Guna.UI2.WinForms.Guna2Button btn_Clear_Stock;
        private Guna.UI2.WinForms.Guna2Button btn_Delete_Stock;
        private Guna.UI2.WinForms.Guna2Button btn_Update_Stock;
        private Guna.UI2.WinForms.Guna2Button btn_Search_Stock;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2PictureBox picGoBackStr;
    }
}