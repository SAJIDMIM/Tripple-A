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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Interval = 100; // Set the timer interval to 100 milliseconds
            timer1.Enabled = true; // Start the timer
            progressBar1.Maximum = 120; // Set the maximum value for the progress bar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1); // Increment the progress bar by 1

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Enabled = false; // Stop the timer
                AdminLogin admin = new AdminLogin();
                admin.Show();
                this.Hide(); // Hide the current form (Splash form)
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
