using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tripple_A_Supermart_Management_System.model;


namespace Tripple_A_Supermart_Management_System.view
{
    public partial class MonthlySale : Form
    {
        public MonthlySale()
        {
            InitializeComponent();
        }

        private void btn_Generate_Monthly_Sale_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                string query = "select * from Sale";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                ReportDocument rprt = new ReportDocument();
                rprt.Load(@"C:\Users\Defaulter\source\repos\Tripple A Supermart Management System\Tripple A Supermart Management System\view\WeeklyStock.rpt");
                rprt.SetDataSource(dataTable);

                crystalReportViewer1.ReportSource = rprt;
            }
        }

        private void dirAdminDash_Click(object sender, EventArgs e)
        {
            DirectorAdminDashboard back = new DirectorAdminDashboard();
            back.Show();
            this.Hide();
        }
    }
}
