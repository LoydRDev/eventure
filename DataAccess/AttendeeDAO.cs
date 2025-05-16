using eventure.Database;
using eventure.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace eventure.DataAccess
{
    class AttendeeDAO
    {
        public void RegisterEvent(int eventID, int userID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.connectionString))
                {
                    string query = "INSERT INTO Attendees (EventID, AttendeeID, Status, RegistrationDate) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = eventID;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userID;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "Pending";
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Database error occurred: {ex.Message}\nError code: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        public List<Attendee> GetAttendees(int eventID, int userID)
        {
            List<Attendee> attendees = new List<Attendee>();
            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.connectionString))
                {
                    string query = "SELECT * FROM Attendees WHERE EventID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = eventID;
                        connection.Open();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Attendee attendee = new Attendee
                                {
                                    AttendeeID = reader.GetInt32(0),
                                    EventID = reader.GetInt32(1),
                                    Status = reader.GetString(2),
                                    RegistrationDate = reader.GetDateTime(3)
                                };
                                attendees.Add(attendee);
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Attendee Database error occurred: {ex.Message}\nError code: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Attendee An unexpected error occurred: {ex.Message}");
            }
            return attendees;
        }

        public void ApproveRegistration(int eventID, int userID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.connectionString))
                {
                    string query = "UPDATE Attendees SET Status = ? WHERE EventID = ? AND AttendeeID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "Approved";
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = eventID;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userID;
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Attende1 Database error occurred: {ex.Message}\nError code: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Attendee1 An unexpected error occurred: {ex.Message}");
            }
        }
        public void RejectRegistration(int eventID, int userID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.connectionString))
                {
                    string query = "UPDATE Attendees SET Status = ? WHERE EventID = ? AND AttendeeID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "Rejected";
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = eventID;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userID;
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Attende2 Database error occurred: {ex.Message}\nError code: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Attende2 An unexpected error occurred: {ex.Message}");
            }
        }

        public int GetAllEventConfirmations(int userID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.connectionString))
                {
                    string query = "SELECT * FROM Attendees WHERE AttendeeID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = userID;
                        connection.Open();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Process each row
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Attendee3 Database error occurred: {ex.Message}\nError code: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Attendee3 An unexpected error occurred: {ex.Message}");
            }
            return userID;
        }
    }
}
