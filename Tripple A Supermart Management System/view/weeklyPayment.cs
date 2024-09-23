using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.model;

namespace Tripple_A_Supermart_Management_System.view
{
    public partial class weeklyPayment : Form
    {
        public weeklyPayment()
        {
            InitializeComponent();
        }

        private void btn_Generate_Weekly_Payment_Click(object sender, EventArgs e)
        {
           

            using (SqlConnection con = MDBConnection.createConnection())
            {
                // Check if the connection is open
                if (con.State != ConnectionState.Open)
                {
                    MessageBox.Show("Failed to open database connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "select * from CustomerOrder";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Check if the query returned any results
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for weekly payment report", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ReportDocument rprt = new ReportDocument();
                rprt.Load(@"C:\Users\Defaulter\source\repos\Tripple A Supermart Management System\Tripple A Supermart Management System\view\weeklyPaymentReport.rpt");
                rprt.SetDataSource(dataTable);

                crystalReportViewer1.ReportSource = rprt;
            }
        }

        private void pic_Cash_Dash_Click(object sender, EventArgs e)
        {
            cashierDash back = new cashierDash();
            back.Show();
            this.Hide();
        }
    }
}
