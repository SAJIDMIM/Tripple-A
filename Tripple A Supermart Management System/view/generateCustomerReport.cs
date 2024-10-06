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
                string query = @"
            SELECT c.customerId, c.customerName, c.DoB, c.Gender, c.City, c.Street, c.PostalCode, c.mobile, c.Type
            FROM Customer c
            WHERE c.customerId IN (
                SELECT o.customerId
                FROM Order o
                WHERE o.approvalStatus = 'Approved'
            )
        ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                ReportDocument rprt = new ReportDocument();
                rprt.Load(@"C:\Users\Defaulter\source\repos\Tripple A Supermart Management System\Tripple A Supermart Management System\view\MonthlyCustomerReport.rpt");
                rprt.SetDataSource(dataTable);

                crystalReportViewer1.ReportSource = rprt;
            }
        }

        private void picGeneralDash_Click(object sender, EventArgs e)
        {
            GeneralDash back = new GeneralDash();
            back.Show();
            this.Hide();
        }
    }
}
