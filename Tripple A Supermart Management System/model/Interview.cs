using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace Tripple_A_Supermart_Management_System.model
{


    class Interview
    {

        private string employeeId;
        private string firstName;
        private string lastName;
        private DateTime Date;
        private DateTime endDate;
        private string Location;
        private string Type;
        private string Status;
        private string scheduleEmail;


        public void scheduleInterview(string employeeId, string firstName, string lastName, DateTime Date,DateTime endDate,string Location, string Type, string Status, string scheduleEmail)
        {

            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.Date = Date;
            this.endDate = endDate;
            this.Location = Location;
            this.Type = Type;
            this.Status = Status;
            this.scheduleEmail = scheduleEmail;

            using (SqlConnection con = MDBConnection.createConnection())
            {
                string query = "INSERT INTO Interview (employeeId, firstName, lastName, Date,endDate ,Location, Type, Status, scheduleEmail) VALUES (@employeeId, @firstName, @lastName, @Date,@endDate, @Location, @Type, @Status, @scheduleEmail)";


                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@employeeId", this.employeeId);
                command.Parameters.AddWithValue("@firstName", this.firstName);
                command.Parameters.AddWithValue("@lastName", this.lastName);
                command.Parameters.AddWithValue("@Date", this.Date);
                command.Parameters.AddWithValue("@endDate", this.endDate);

                command.Parameters.AddWithValue("@Location", this.Location);
                command.Parameters.AddWithValue("@Type", this.Type);
                command.Parameters.AddWithValue("@Status", this.Status);
                command.Parameters.AddWithValue("@scheduleEmail", this.scheduleEmail);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                   
                    MessageBox.Show("Successfuly Schedule an Interview", "Schedule Interview", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SendEmailToMultipleRecipients(scheduleEmail);



                }
                else
                {
                    MessageBox.Show("An error occurred during Scheduling an Interview", "Invalid Schedule Interview", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        // Method to get the next retirement ID
        public static int GetNextInterviewId()
        {
            int nextInterviewId = 1;
            try
            {
                using (SqlConnection con = MDBConnection.createConnection())
                {
                    con.Open();
                    string query = "SELECT ISNULL(MAX(InterviewId), 0) + 1 FROM Interview";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            nextInterviewId = (int)result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nextInterviewId;
        }
        public void SendEmailToMultipleRecipients(string recipientEmail)
        {

            Random random = new Random();
            int hour = random.Next(9, 17); // generate a random hour between 9am and 5pm
            int minute = random.Next(0, 60); // generate a random minute

            string scheduledTime = $"{hour}:{minute:00}"; // format the time as HH:mm
            DateTime scheduledDateTime = Date.AddHours(hour).AddMinutes(minute); // create a DateTime object for the scheduled time

            string emailBody = $"Dear {firstName} {lastName},\n\nYour interview has been scheduled for {Date} to {endDate} in {Type} at {Location} at {scheduledTime}.\n\nBest regards,\nTripple A Supermart Management System";

            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("mohamedsajid450@gmail.com", "pjpt pqak ldxd gukn");

                MailMessage mailMessage = new MailMessage("mohamedsajid450@gmail.com", recipientEmail);
                mailMessage.Subject = "Interview Scheduled for Employee";
                mailMessage.Body = emailBody;

                smtpClient.Send(mailMessage);
                MessageBox.Show("Email sent successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Set up a timer to send the reminder email 30 minutes before the scheduled meeting time
                TimeSpan timeSpan = scheduledDateTime.AddMinutes(-30) - DateTime.Now;
                Timer reminderTimer = new Timer();
                if (timeSpan.TotalMilliseconds > 0)
                {
                    reminderTimer.Interval = (int)timeSpan.TotalMilliseconds;
                    reminderTimer.Tick += (sender, e) =>
                    {
                        string reminderEmailBody = $"Dear {firstName} {lastName},\n\nThis is a reminder that your interview is scheduled for {scheduledTime} at {Location}.\n\nBest regards,\nTripple A Supermart Management System";
                        MailMessage reminderMailMessage = new MailMessage("mohamedsajid450@gmail.com", recipientEmail);
                        reminderMailMessage.Subject = "Interview Reminder";
                        reminderMailMessage.Body = reminderEmailBody;

                        smtpClient.Send(reminderMailMessage);
                        MessageBox.Show("Reminder email sent successfully", "Reminder Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reminderTimer.Stop(); // stop the timer after sending the reminder email
                    };
                    reminderTimer.Start();
                }
                else
                {
                    // scheduled date and time is in the past, handle accordingly
                    // ...
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable viewEmployee(string employeeId)
        {
            DataTable employeeDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Employee WHERE employeeId = @employeeId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(employeeDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving employee details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return employeeDetails; // Return the DataTable with user details
        }
        public DataTable viewInterview(int InterviewID)
        {
            DataTable interviewDetails = new DataTable(); // Create a DataTable to hold results

            using (SqlConnection connection = MDBConnection.createConnection())
            {
                string query = "SELECT * FROM Interview WHERE InterviewID = @InterviewID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InterviewID", InterviewID); // Use the userId parameter

                    try
                    {
                        connection.Open(); // Open the connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(interviewDetails); // Fill the DataTable with retrieved data
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions, such as connection errors or database issues
                        Console.WriteLine("Error retrieving Interview details: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Close the connection
                    }
                }
            }

            return interviewDetails; // Return the DataTable with user details
        }
    }
}


