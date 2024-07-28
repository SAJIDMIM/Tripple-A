using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    public class Employee
    {
        protected string EmployeeId { get; set; }
        protected string EmpType { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string ActorId { get; set; }
        protected string Position { get; set; }
        protected string Department { get; set; }
        protected DateTime DateJoined { get; set; }
        protected float Salary { get; set; }
        protected bool Retirement { get; set; }

        public virtual void addEmployee(string employeeId, string firstName, string lastName, string empType, string position, string department, DateTime dateJoined, float salary, string retirement)

        {

            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("sp_InsertEmployee", con))
                {
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@firstName", firstName); // Corrected line: Added @ before firstName
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@empType", empType);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@department", department);
                    cmd.Parameters.AddWithValue("@DateJoined", dateJoined);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@Retirement", retirement);

                    // Execute the command to insert the employee data
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error adding employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        class Storekeeper : Employee
        {
            public Employee Employee { get; private set; }
            private string StorekeeperId { get; set; }

            public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string position, string department, DateTime dateJoined, float salary, string retirement)
            {


                base.addEmployee(employeeId, firstName, lastName, empType, position, department, dateJoined, salary, retirement);

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Storekeeper (employeeId, storekeeperId) VALUES (@employeeId, @storekeeperId)", MDBConnection.createConnection()))
                {
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.Parameters.AddWithValue("@storekeeperId", "ST" + StorekeeperId.Substring(1));
                    cmd.ExecuteNonQuery();
                }
            }


        }

        class Cashier : Employee
        {
            public Employee Employee { get; private set; }
            private string CashierId { get; set; }

            public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string position, string department, DateTime dateJoined, float salary, string retirement)
            {
                base.addEmployee(employeeId, firstName, lastName, empType, position, department, dateJoined, salary, retirement);

                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Cashier (employeeId, cashierId) VALUES (@employeeId, @cashierId)", con))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        cmd.Parameters.AddWithValue("@cashierId", "C" + CashierId.Substring(1));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }



        class SalesRepresentative : Employee
        {
            public Employee Employee { get; private set; }
            private string salesRepId { get; set; }

            public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string position, string department, DateTime dateJoined, float salary, string retirement)
            {
                base.addEmployee(employeeId, firstName, lastName, empType, position, department, dateJoined, salary, retirement);

                // Set salesRepId
                salesRepId = "SR" + employeeId.Substring(1);

                // Insert record into SalesRepresentative table
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERT INTO SalesRepresentative (employeeId, salesRepId) VALUES (@employeeId, @salesRepId)", con))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        cmd.Parameters.AddWithValue("@salesRepId", salesRepId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}