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
    public partial class monitorMarketing : Form
    {
        public monitorMarketing()
        {
            InitializeComponent();
        }

        private void btn_Add_Marketing_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string marketingId = txt_Mark_Id.Text;
                string marketingName = txt_Marketing_Name.Text;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                string type = cmb_Marketing_Type.SelectedItem.ToString();
                string USP = cmbUSP.SelectedItem.ToString();
                double pricing = double.Parse(txtPrice.Text);
                string FAQs = txtFAQs.Text;
                string contactNumber = txt_Contact_Number.Text;

                CMarketing newMarketing = new CMarketing();
                newMarketing.addMarketing(marketingId, marketingName, startDate, endDate, type, USP, pricing, FAQs, contactNumber);

                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Marketing_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string marketingId = txt_Mark_Id.Text;
                string marketingName = txt_Marketing_Name.Text;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                string type = cmb_Marketing_Type.SelectedItem.ToString();
                string USP = cmbUSP.SelectedItem.ToString();
                double pricing = double.Parse(txtPrice.Text);
                string FAQs = txtFAQs.Text;
                string contactNumber = txt_Contact_Number.Text;

                CMarketing newMarketing = new CMarketing();
                newMarketing.updateMarketing(marketingId, marketingName, startDate, endDate, type, USP, pricing, FAQs, contactNumber);

                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Marketing_Click(object sender, EventArgs e)
        {
            string marketingId = txt_Mark_Id.Text;
            


            CMarketing newMarketing = new CMarketing();
            newMarketing.removeMarketing(marketingId);

        }

        private void btn_Clear_Marketing_Click(object sender, EventArgs e)
        {
            txt_Mark_Id.Clear();
            txt_Marketing_Name.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            cmb_Marketing_Type.SelectedIndex = -1;
            cmbUSP.SelectedIndex = -1;
            txtPrice.Clear();
            txtFAQs.Clear();
            txt_Contact_Number.Clear();
        }

        private void btn_Search_Marketing_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Mark_Id.Text))
            {
                string marketingId = txt_Mark_Id.Text;

                CMarketing showDetails = new CMarketing();
                DataTable getDetails = showDetails.viewMarketing(marketingId);

                if (getDetails.Rows.Count > 0)
                {
                    DataRow row = getDetails.Rows[0];

                    txt_Marketing_Name.Text = row["marketingName"].ToString();
                    dtpStartDate.Value = Convert.ToDateTime(row["startDate"]);
                    dtpEndDate.Value = Convert.ToDateTime(row["endDate"]);
                    cmb_Marketing_Type.SelectedItem = row["type"].ToString();
                    cmbUSP.SelectedItem = row["USP"].ToString();
                    txtPrice.Text = row["pricing"].ToString();
                    txtFAQs.Text = row["FAQs"].ToString();
                    txt_Contact_Number.Text = row["contactNumber"].ToString();
                }
                else
                {
                    MessageBox.Show("No marketing found with the provided ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please enter a marketing ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateFields()
        {
            return !string.IsNullOrEmpty(txt_Mark_Id.Text) &&
                   !string.IsNullOrEmpty(txt_Marketing_Name.Text) &&
                   dtpStartDate.Value != DateTime.MinValue &&
                   dtpEndDate.Value != DateTime.MinValue &&
                   cmb_Marketing_Type.SelectedIndex != -1 &&
                   cmbUSP.SelectedIndex != -1 &&
                   !string.IsNullOrEmpty(txtPrice.Text) &&
                   !string.IsNullOrEmpty(txtFAQs.Text) &&
                   !string.IsNullOrEmpty(txt_Contact_Number.Text);
        }

        private void ClearFields()
        {
            txt_Mark_Id.Clear();
            txt_Marketing_Name.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            cmb_Marketing_Type.SelectedIndex = -1;
            cmbUSP.SelectedIndex = -1;
            txtPrice.Clear();
            txtFAQs.Clear();
            txt_Contact_Number.Clear();
        }

        private void pic_DM_Dash_Click(object sender, EventArgs e)
        {
            digitalMarketerDash back = new digitalMarketerDash();
            back.Show();
            this.Hide();
        }
    }
}
