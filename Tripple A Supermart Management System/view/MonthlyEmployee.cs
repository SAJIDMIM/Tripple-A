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
    public partial class MonthlyEmployee : Form
    {
        public MonthlyEmployee()
        {
            InitializeComponent();
        }

        private void btn_Generate_Monthly_Employee_Click(object sender, EventArgs e)
        {
            if (MDBConnection.createConnection() == null)
            {
                MessageBox.Show("Failed to establish a connection to the database. Please check the connection settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = MDBConnection.createConnection())
            {
                string query = "select employeeId,firstName,lastName,empType,actorId,position,department,DateJoined,Salary,Retirement from Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();

                try
                {
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No employee data found. Please check the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ReportDocument rprt = new ReportDocument();
                try
                {
                    rprt.Load(@"C:\Users\Defaulter\source\repos\Tripple A Supermart Management System\Tripple A Supermart Management System\view\MonthlyEmployeeReport.rpt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rprt.SetDataSource(dataTable);
                crystalReportViewer1.ReportSource = rprt;
            }
        }

        private void HrDash_Click(object sender, EventArgs e)
        {
            HRManager back = new HRManager();
            back.Show();
            this.Hide();
        }
    }
}
