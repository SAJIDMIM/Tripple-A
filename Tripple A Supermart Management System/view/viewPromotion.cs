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
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class viewPromotion : Form
    {
        public viewPromotion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Promotion_Click(object sender, EventArgs e)
        {
            string markPromotion_Id = txt_Promotion_Id.Text;

            if (markPromotion_Id == null)
            {
                MessageBox.Show("Please enter valid Promotion Id to be process", "Invalid Retirement Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CMarketingPromotion viewPromoDetails = new CMarketingPromotion();


                DataTable promoDetails = viewPromoDetails.viewMarketingPromotion(markPromotion_Id);
                


                dgvPromo.DataSource = promoDetails;
            }

        }

        private void picDMDash_Click(object sender, EventArgs e)
        {
            digitalMarketerDash back = new digitalMarketerDash();
            back.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Promotion_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
