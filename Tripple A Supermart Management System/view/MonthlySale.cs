using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
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
    }
}
