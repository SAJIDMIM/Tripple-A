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
    public partial class viewItems : Form
    {
        public viewItems()
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
            string itemId = txt_Item_Id.Text;

            if (itemId == null)
            {
                MessageBox.Show("Please enter valid Item Id to be process", "Invalid Item Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CItem viewItem = new CItem();


                DataTable itemDetails = viewItem.viewItem(itemId);



                dgvItems.DataSource = itemDetails;
            }
        }
    }
}
