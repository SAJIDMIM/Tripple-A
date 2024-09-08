using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class digitalMarketerDash : Form
    {
        public digitalMarketerDash()
        {
            InitializeComponent();
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketingPromotion newPromotion = new MarketingPromotion();
            newPromotion.Show();
            this.Hide();
        }

        private void promotionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewPromotion showPromotion = new viewPromotion();
            showPromotion.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }

        private void marketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monitorMarketing showDetails = new monitorMarketing();
            showDetails.Show();
            this.Hide();
        }

        private void marketingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewMarketing goBack = new viewMarketing();
            goBack.Show();
            this.Hide();
        }
    }
}
