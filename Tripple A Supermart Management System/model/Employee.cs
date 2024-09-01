using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    public class Employee
    {
        protected string EmployeeId { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string EmpType { get; set; }
        protected string ActorId { get; set; }
        protected string Position { get; set; }
        protected string Department { get; set; }
        protected DateTime DateJoined { get; set; }
        protected float Salary { get; set; }
        protected string Retirement { get; set; }



        public virtual void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();

                string query = @"
                INSERT INTO Employee (employeeId, firstName, lastName, empType, actorId, position, department, DateJoined, Salary, Retirement, 
                                      supervisorId, digitalMarketerId, accountantId, storekeeperId, salesRepId, cashierId)
                VALUES (@employeeId, @firstName, @lastName, @empType, @actorId, @position, @department, @dateJoined, @salary, @retirement, 
                        CASE WHEN @empType = 'Supervisor' THEN @actorId ELSE NULL END, 
                        CASE WHEN @empType = 'DigitalMarketer' THEN @actorId ELSE NULL END, 
                        CASE WHEN @empType = 'Accountant' THEN @actorId ELSE NULL END, 
                        CASE WHEN @empType = 'Storekeeper' THEN @actorId ELSE NULL END, 
                        CASE WHEN @empType = 'SalesRepresentative' THEN @actorId ELSE NULL END, 
                        CASE WHEN @empType = 'Cashier' THEN @actorId ELSE NULL END)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@empType", empType);
                    command.Parameters.AddWithValue("@actorId", actorId);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@department", department);
                    command.Parameters.AddWithValue("@dateJoined", dateJoined);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@retirement", retirement);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Employee has been added successfully", "Employee Save Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Employee details have not been saved. An error occurred: " + ex.Message, "Invalid Employee Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }







    class Storekeeper : Employee
    {
        private string StorekeeperId { get; set; }

        public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            StorekeeperId = "ST" + employeeId; // Generate Storekeeper ID
            base.addEmployee(employeeId, firstName, lastName, empType, StorekeeperId, position, department, dateJoined, salary, retirement);

            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Storekeeper (storekeeperId, employeeId) VALUES (@storekeeperId, @employeeId)", con))
                {
                    cmd.Parameters.AddWithValue("@storekeeperId", StorekeeperId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    class Cashier : Employee
    {
        private string CashierId { get; set; }

        public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            CashierId = "C" + employeeId; // Generate Cashier ID
            base.addEmployee(employeeId, firstName, lastName, empType, CashierId, position, department, dateJoined, salary, retirement);

            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Cashier (cashierId, employeeId) VALUES (@cashierId, @employeeId)", con))
                {
                    cmd.Parameters.AddWithValue("@cashierId", CashierId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    class SalesRepresentative : Employee
    {
        private string SalesRepId { get; set; }

        public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            SalesRepId = "SR" + employeeId; // Generate Sales Representative ID
            base.addEmployee(employeeId, firstName, lastName, empType, SalesRepId, position, department, dateJoined, salary, retirement);

            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO SalesRepresentative (salesRepId, employeeId) VALUES (@salesRepId, @employeeId)", con))
                {
                    cmd.Parameters.AddWithValue("@salesRepId", SalesRepId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    class Supervisor : Employee
    {
        private string SupervisorId { get; set; }

        public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            SupervisorId = "SU" + employeeId; // Generate Supervisor ID
            base.addEmployee(employeeId, firstName, lastName, empType, SupervisorId, position, department, dateJoined, salary, retirement);

            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Supervisor (supervisorId, employeeId) VALUES (@supervisorId, @employeeId)", con))
                {
                    cmd.Parameters.AddWithValue("@supervisorId", SupervisorId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    class DigitalMarketer : Employee
    {
        private string DigitalMarketerId { get; set; }

        public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            DigitalMarketerId = "DM" + employeeId; // Generate Digital Marketer ID
            base.addEmployee(employeeId, firstName, lastName, empType, DigitalMarketerId, position, department, dateJoined, salary, retirement);

            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO DigitalMarketer (digitalMarketerId, employeeId) VALUES (@digitalMarketerId, @employeeId)", con))
                {
                    cmd.Parameters.AddWithValue("@digitalMarketerId", DigitalMarketerId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    class Accountant : Employee
    {
        private string AccountantId { get; set; }

        public override void addEmployee(string employeeId, string firstName, string lastName, string empType, string actorId, string position, string department, DateTime dateJoined, float salary, string retirement)
        {
            AccountantId = "A" + employeeId; // Generate Accountant ID
            base.addEmployee(employeeId, firstName, lastName, empType, AccountantId, position, department, dateJoined, salary, retirement);

            using (SqlConnection con = MDBConnection.createConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Accountant (accountantId, employeeId) VALUES (@accountantId, @employeeId)", con))
                {
                    cmd.Parameters.AddWithValue("@accountantId", AccountantId);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

