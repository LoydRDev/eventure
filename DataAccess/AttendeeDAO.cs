using eventure.Database;
using System;
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
                    string query = "INSERT INTO Attendees (EventID, UserID) VALUES (?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
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
                MessageBox.Show($"Database error occurred: {ex.Message}\nError code: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

    }
}
