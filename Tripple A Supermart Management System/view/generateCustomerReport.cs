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
    public partial class generateCustomerReport : Form
    {
        public generateCustomerReport()
        {
            InitializeComponent();
        }

        private void btn_Generate_Customer_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open(); // Open the connection

                string query = "select * from Customer";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ReportDocument rprt = new ReportDocument();
                rprt.Load(@"C:\Users\Defaulter\source\repos\Tripple A Supermart Management System\Tripple A Supermart Management System\view\MonthlyCustomerReport.rpt");
                rprt.SetDataSource(dataTable);

                crystalReportViewer1.ReportSource = rprt;
            } // Closing brace for the using statement
        }

        private void picGeneralDash_Click(object sender, EventArgs e)
        {
            GeneralDash back = new GeneralDash();
            back.Show();
            this.Hide();
        }
    }
}
