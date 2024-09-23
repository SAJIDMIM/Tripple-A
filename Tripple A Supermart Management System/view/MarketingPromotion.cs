using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.controller;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class MarketingPromotion : Form
    {
        public MarketingPromotion()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Marketing_Promotion_Click(object sender, EventArgs e)
        {
            string markPromotion_Id = txt_MP_Id.Text;
            string marketPromotionName = txt_Marketing_Name.Text;
            DateTime startDate = dtp_Start_Date.Value;
            DateTime endDate = dtp_End_Date.Value;
            double discount;
            if (double.TryParse(txt_Discount.Text, out discount))
            {
                // The conversion was successful, you can use the discount value
            }
            else
            {
                // The conversion failed, display an error message to the user
                MessageBox.Show("Invalid discount value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string offer = cmb_Offer_Type.SelectedItem.ToString();
            string emailMarketing = txtEmail.Text;
            string contentMarketing = cmb_Marketing.SelectedItem.ToString();
            string inStorePromotion = cmbStore.SelectedItem.ToString();
            string condition = txtCondition.Text;

            // Create an instance of the CMarketingPromotion controller
            CMarketingPromotion cMarketingPromotion = new CMarketingPromotion();

            // Call the addPromotionMarketing method to add a new promotion
            cMarketingPromotion.addPromotionMarketing(markPromotion_Id, marketPromotionName, startDate, endDate, discount, offer, emailMarketing, contentMarketing, inStorePromotion, condition);
            // Clear or reset the fields if no marketing promotion is found
            txt_Marketing_Name.Text = "";
            dtp_Start_Date.Value = DateTime.Now; // Or a default date
            dtp_End_Date.Value = DateTime.Now; // Or a default date
            txt_Discount.Text = "";
            cmb_Offer_Type.SelectedIndex = -1; // Reset the combobox
            txtEmail.Text = "";
            cmb_Marketing.SelectedIndex = -1;
            cmbStore.SelectedIndex = -1;
            txtCondition.Text = "";

        }

        private void btn_Update_Marketing_Promotion_Click(object sender, EventArgs e)
        {
            string markPromotionId = txt_MP_Id.Text;
            string marketPromotionName = txt_Marketing_Name.Text;
            DateTime startDate = dtp_Start_Date.Value;
            DateTime endDate = dtp_End_Date.Value;
            double discount;

            if (string.IsNullOrWhiteSpace(markPromotionId))
            {
                MessageBox.Show("Marketing Promotion ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(marketPromotionName))
            {
                MessageBox.Show("Marketing Promotion Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txt_Discount.Text, out discount))
            {
                MessageBox.Show("Invalid discount value. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string offer = cmb_Offer_Type.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(offer))
            {
                MessageBox.Show("Offer type is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailMarketing = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(emailMarketing))
            {
                MessageBox.Show("Email marketing is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contentMarketing = cmb_Marketing.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(contentMarketing))
            {
                MessageBox.Show("Content marketing is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string inStorePromotion = cmbStore.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(inStorePromotion))
            {
                MessageBox.Show("In-store promotion is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string condition = txtCondition.Text;
            if (string.IsNullOrWhiteSpace(condition))
            {
                MessageBox.Show("Condition is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of the CMarketingPromotion controller
            CMarketingPromotion cMarketingPromotion = new CMarketingPromotion();

            cMarketingPromotion.updatePromotionMarketing(markPromotionId, marketPromotionName, startDate, endDate, discount, offer, emailMarketing, contentMarketing, inStorePromotion, condition);

            // Clear or reset the fields if no marketing promotion is found
            txt_Marketing_Name.Text = "";
            dtp_Start_Date.Value = DateTime.Now; // Or a default date
            dtp_End_Date.Value = DateTime.Now; // Or a default date
            txt_Discount.Text = "";
            cmb_Offer_Type.SelectedIndex = -1; // Reset the combobox
            txtEmail.Text = "";
            cmb_Marketing.SelectedIndex = -1;
            cmbStore.SelectedIndex = -1;
            txtCondition.Text = "";

        }

        private void btn_Delete_Marketing_Promotion_Click(object sender, EventArgs e)
        {
            string markPromotionId = txt_MP_Id.Text;

            if (string.IsNullOrWhiteSpace(markPromotionId))
            {
                MessageBox.Show("Marketing Promotion ID is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of the CMarketingPromotion controller
            CMarketingPromotion cMarketingPromotion = new CMarketingPromotion();

            cMarketingPromotion.removePromotionMarketing(markPromotionId);

            // Clear or reset the fields if no marketing promotion is found
            txt_Marketing_Name.Text = "";
            dtp_Start_Date.Value = DateTime.Now; // Or a default date
            dtp_End_Date.Value = DateTime.Now; // Or a default date
            txt_Discount.Text = "";
            cmb_Offer_Type.SelectedIndex = -1; // Reset the combobox
            txtEmail.Text = "";
            cmb_Marketing.SelectedIndex = -1;
            cmbStore.SelectedIndex = -1;
            txtCondition.Text = "";

        }

        private void btn_Search_Marketing_Promotion_Click(object sender, EventArgs e)
        {
            string markPromotion_Id = txt_MP_Id.Text;

            CMarketingPromotion showDetails = new CMarketingPromotion();
            DataTable getDetails = showDetails.viewMarketingPromotion(markPromotion_Id);

            if (getDetails.Rows.Count > 0)
            {
                DataRow row = getDetails.Rows[0];

                
                txt_Marketing_Name.Text = row["markertPromotionName"].ToString();
                dtp_Start_Date.Value = Convert.ToDateTime(row["startDate"]);
                dtp_End_Date.Value = Convert.ToDateTime(row["endDate"]);
                txt_Discount.Text = row["discount"].ToString();
                cmb_Offer_Type.SelectedItem = row["offer"].ToString();
                txtEmail.Text = row["emailMarketing"].ToString();
                cmb_Marketing.SelectedItem = row["contentMarketing"].ToString();
                cmbStore.SelectedItem = row["inStorePromotion"].ToString();
                txtCondition.Text = row["condition"].ToString();

            }
            else
            {
                MessageBox.Show("No marketing promotion found with the provided ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear or reset the fields if no marketing promotion is found
                txt_Marketing_Name.Text = "";
                dtp_Start_Date.Value = DateTime.Now; // Or a default date
                dtp_End_Date.Value = DateTime.Now; // Or a default date
                txt_Discount.Text = "";
                cmb_Offer_Type.SelectedIndex = -1; // Reset the combobox
                txtEmail.Text = "";
                cmb_Marketing.SelectedIndex = -1;
                cmbStore.SelectedIndex = -1;
                txtCondition.Text = "";

            }
        }

        private void btn_Clear_Employee_Click(object sender, EventArgs e)
        {
            txt_Marketing_Name.Text = "";
            dtp_Start_Date.Value = DateTime.Now; // Or a default date
            dtp_End_Date.Value = DateTime.Now; // Or a default date
            txt_Discount.Text = "";
            cmb_Offer_Type.SelectedIndex = -1; // Reset the combobox
            txtEmail.Text = "";
            cmb_Marketing.SelectedIndex = -1;
            cmbStore.SelectedIndex = -1;
            txtCondition.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Marketing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Offer_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dtp_End_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtp_Start_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Marketing_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MP_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_DM_Dashboard_Click(object sender, EventArgs e)
        {
            digitalMarketerDash back = new digitalMarketerDash();
            back.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
