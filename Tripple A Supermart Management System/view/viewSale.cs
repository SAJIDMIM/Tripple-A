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
    public partial class viewSale : Form
    {
        public viewSale()
        {
            InitializeComponent();
        }

        private void btn_Search_Sale_Click(object sender, EventArgs e)
        {
            string saleId = txtSaleId.Text;

            if (saleId == null)
            {
                MessageBox.Show("Please enter valid Product Id to be process", "Invalid Product Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CSale viewSale = new CSale();


                DataTable saleDetails = viewSale.viewSale(saleId);



                dgvSaleDetails.DataSource = saleDetails;
            }
        }

        private void picGoBackSaleDash_Click(object sender, EventArgs e)
        {
            SaleDash back = new SaleDash();
            back.Show();
            this.Hide();
        }
    }
}
