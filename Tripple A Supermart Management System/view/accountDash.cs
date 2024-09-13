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
    public partial class accountDash : Form
    {
        public accountDash()
        {
            InitializeComponent();
        }

        private void bankAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankAccount newBank = new BankAccount();
            newBank.Show();
            this.Hide();
        }

        private void cashFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void financialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }
    }
}
