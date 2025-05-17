using System;
using System.Windows.Forms;
using System.Data.OleDb;

using eventure.Models;
using eventure.Database;

namespace eventure.DataAccess
{
    class NotificationDAO
    {
        //Sent Notification to Event Owner whenever a user register for an event
        public void SendNotifToEventOwner(int eventID, int userID, int CreatorID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.connectionString))
                {
                    string query = "INSERT INTO Notifications ( UserID, EventID, CreatorID, Message, NotificationDate) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = userID;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = eventID;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = CreatorID;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "A user has registered to your event";
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
    }
}
