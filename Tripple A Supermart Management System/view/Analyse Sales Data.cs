﻿using System;
using System.Data;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class Analyse_Sales_Data : Form
    {
        public Analyse_Sales_Data()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Analyze_Sale_Click(object sender, EventArgs e)
        {

            Tripple_A_Supermart_Management_System.controller.CSale saleController = new Tripple_A_Supermart_Management_System.controller.CSale();

            DataTable saleData = saleController.analyzeSale(); // Call the controller's analyzeSale method

            if (saleData.Rows.Count > 0)
            {
                dgvSale_Details.DataSource = saleData; // Bind the DataTable to the DataGridView
                dgvSale_Details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Optional: adjust column widths
            }
            else
            {
                MessageBox.Show("No data found for given Sale Id!","Invalid Sale Search",MessageBoxButtons.OK,MessageBoxIcon.Error); // Display a message if no data is found
            }



        }

        private void picGoBackAdminLogin_Click(object sender, EventArgs e)
        {
            DirectorAdminDashboard goBack = new DirectorAdminDashboard();
            goBack.Show();
            this.Hide();
        }
    }
}
