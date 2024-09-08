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
    public partial class supervisorDash : Form
    {
        public supervisorDash()
        {
            InitializeComponent();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void assignCustomerServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assignCustomerService newService = new assignCustomerService();
            newService.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }
    }
}
