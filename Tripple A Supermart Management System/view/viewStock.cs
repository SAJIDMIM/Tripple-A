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
    public partial class viewStock : Form
    {
        public viewStock()
        {
            InitializeComponent();
        }

        private void picGoBackStr_Click(object sender, EventArgs e)
        {
            StorekeeperDashboard back = new StorekeeperDashboard();
            back.Show();
            this.Hide();
        }

        private void btn_Search_Item_Click(object sender, EventArgs e)
        {
            string stockId = txt_Stock_Id.Text;

            if (stockId == null)
            {
                MessageBox.Show("Please enter valid Stock Id to be process", "Invalid Stock Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CStock viewStock = new CStock();


                DataTable stockDetails = viewStock.viewStock(stockId);



                dgvStock.DataSource = stockDetails;
            }
        }
    }
}
