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
                con.Open(); // Open the connection

                string query = "select saleId,productId,productName,price,Quantity,saleStartDate,saleEndDate,priceCalculate,discount,payMethod,customerName from Sale";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Check if the query returned any results
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No sales data found for the monthly sale report", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ReportDocument rprt = new ReportDocument();
                rprt.Load(@"C:\Users\Defaulter\source\repos\Tripple A Supermart Management System\Tripple A Supermart Management System\view\MonthlySaleReport.rpt"); // Correct report file path
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
