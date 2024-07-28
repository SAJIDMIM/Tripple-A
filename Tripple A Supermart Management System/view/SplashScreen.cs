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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(guna2VProgressBar1.Value == 100)
            {
                guna2VProgressBar1.Value += 1;
                guna2VProgressBar1.Text = guna2VProgressBar1.Value.ToString() + "%";
                

            }
            else
            {
                timer1.Stop();
                AdminLogin adminlogin = new AdminLogin();
                adminlogin.Show();
                this.Hide();
            }
        }
    }
}
