using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tripple_A_Supermart_Management_System.model
{
    public class BankAccount
    {
        private string accountNumber;
        private string accountType;
        private double salary;
        private string employeeId;
        private string employeeName;
        private string bankName;
        private string branch;
        private DateTime openingDate;
        private string accountStatus;

        public void addBankAccount(string accountNumber, string accountType, double salary, string employeeId, string employeeName, string bankName, string branch, DateTime openingDate, string accountStatus)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.salary = salary;
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.bankName = bankName;
            this.branch = branch;
            this.openingDate = openingDate;
            this.accountStatus = accountStatus;

           
            using (SqlConnection connection = MDBConnection.createConnection())
            {
                connection.Open();
                string query = "INSERT INTO BankAccount (accountNumber, accountType, Salary, employeeId, employeeName, bankName, branch, openingDate, accountStatus) VALUES (@AccountNumber, @AccountType, @Salary, @EmployeeId, @EmployeeName, @BankName, @Branch, @OpeningDate, @AccountStatus)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    command.Parameters.AddWithValue("@AccountType", accountType);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    command.Parameters.AddWithValue("@BankName", bankName);
                    command.Parameters.AddWithValue("@Branch", branch);
                    command.Parameters.AddWithValue("@OpeningDate", openingDate);
                    command.Parameters.AddWithValue("@AccountStatus", accountStatus);
                    int count = command.ExecuteNonQuery();
                    if(count > 0)
                    {
                        MessageBox.Show("Account has been successfully added ","Account Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Account has not been requested yet ", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        public DataTable getEmployeeDetails(string employeeId)
        {
            DataTable employeeDetails = new DataTable();

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT firstName, lastName,Salary FROM Employee WHERE employeeId = @employeeId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(employeeDetails);

                            // Combine firstName and lastName into a single employeeName field
                            if (employeeDetails.Rows.Count > 0)
                            {
                                string firstName = employeeDetails.Rows[0]["firstName"].ToString();
                                string lastName = employeeDetails.Rows[0]["lastName"].ToString();
                                string employeeName = $"{firstName} {lastName}";

                                // Update the employeeName field in the DataTable
                                employeeDetails.Columns.Add("employeeName", typeof(string));
                                employeeDetails.Rows[0]["employeeName"] = employeeName;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error retrieving employee details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return employeeDetails;
        }
    }
}