using eventure.Models;
using eventure.Database;
using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;


namespace eventure.DataAccess
{
    public class EventDAO
    {
        public void CreateEvent(Event eventObj)
        {
            bool isSuccess = true;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(DatabaseHelper.connectionString))
                {
                    string query = "INSERT INTO Events (EventName, Description, EventStart, EventEnd, Status, Location, Capacity, Category, CreatorID, DateCreated) " +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {

                        DateTime now = DateTime.Now;
                        string es = "Default";
                        if (now < eventObj.EventStart)
                            es = "Upcoming";
                        else if (now >= eventObj.EventStart && now <= eventObj.EventEnd)
                            es = "Ongoing";
                        else
                            es = "Finished";

                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = eventObj.EventName;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = eventObj.EventDescription;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = eventObj.EventStart;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = eventObj.EventEnd;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = eventObj.EventStatus = es;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = eventObj.EventLocation;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = eventObj.EventMaxCapacity;
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = eventObj.EventCategory;
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = eventObj.CreatorID;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;


                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (OleDbException ex)
            {
                isSuccess = false;
                MessageBox.Show($"Event Database error occurred: {ex.Message}\nError code: {ex.ErrorCode}");
            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show($"Event An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                if (isSuccess)
                {
                    var result = MessageBox.Show("Event created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.connectionString))
            {
                string query = "SELECT EventID, EventName, Category, Description, EventStart, EventEnd, Location, Capacity, CreatorID,  Status  FROM Events";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Event evt = new Event
                    {
                        EventID = Convert.ToInt32(reader["EventID"]),
                        EventName = reader["EventName"].ToString(),
                        EventCategory = reader["Category"].ToString(),
                        EventDescription = reader["Description"].ToString(),
                        EventStart = Convert.ToDateTime(reader["EventStart"].ToString()),
                        EventEnd = Convert.ToDateTime(reader["EventEnd"].ToString()),
                        EventStatus = reader["Status"].ToString(),
                        EventLocation = reader["Location"].ToString(),
                        EventMaxCapacity = Convert.ToInt32(reader["Capacity"]),
                        CreatorID = Convert.ToInt32(reader["CreatorID"])
                    };
                    events.Add(evt);
                }
                reader.Close();
            }
            return events;
        }

        public List<Event> getCurrentUserEvents(int userID)
        {
            List<Event> events = new List<Event>();

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.connectionString))
            {
                string query = "SELECT * FROM Events WHERE CreatorID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", userID);

                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event evt = new Event()
                            {
                                EventID = Convert.ToInt32(reader["EventID"]),
                                EventName = reader["EventName"].ToString(),
                                EventCategory = reader["Category"].ToString(),
                                EventDescription = reader["Description"].ToString(),
                                EventStart = Convert.ToDateTime(reader["EventStart"].ToString()),
                                EventEnd = Convert.ToDateTime(reader["EventEnd"].ToString()),
                                EventStatus = reader["Status"].ToString(),
                                EventLocation = reader["Location"].ToString(),
                                EventMaxCapacity = Convert.ToInt32(reader["Capacity"]),
                            };
                            events.Add(evt);
                        }
                    }
                }
            }
            return events;
        }
        public Event GetEventByID(int eventID)
        {
            Event evt = null;
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.connectionString))
            {
                string query = "SELECT * FROM Events WHERE EventID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", eventID);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            evt = new Event()
                            {
                                EventID = Convert.ToInt32(reader["EventID"]),
                                EventName = reader["EventName"].ToString(),
                                EventCategory = reader["Category"].ToString(),
                                EventDescription = reader["Description"].ToString(),
                                EventStart = Convert.ToDateTime(reader["EventStart"].ToString()),
                                EventEnd = Convert.ToDateTime(reader["EventEnd"].ToString()),
                                EventStatus = reader["Status"].ToString(),
                                EventLocation = reader["Location"].ToString(),
                                EventMaxCapacity = Convert.ToInt32(reader["Capacity"]),
                            };
                        }
                    }
                }
            }
            return evt;
        }

        public string GetEventCreatorName(int eventID)
        {
            string creatorName = "";
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.connectionString))
            {
                string query = "SELECT Users.FirstName, Users.LastName FROM Users INNER JOIN Events ON Users.UserID = Events.CreatorID WHERE Events.EventID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", eventID);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            creatorName = $"{reader["FirstName"]} {reader["LastName"]}";
                        }
                    }
                }
            }
            return creatorName;
        }

        //Sort update by Category and Status
        public List<Event> GetEventSorted(string category, string status)
        {
            List<Event> events = new List<Event>();

            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.connectionString))
            {
                List<string> conditions = new List<string>();
                List<OleDbParameter> parameters = new List<OleDbParameter>();
                string query = "SELECT * FROM Events";

                if (!string.IsNullOrEmpty(category))
                {
                    conditions.Add("Category = ?");
                    parameters.Add(new OleDbParameter("Category", category));
                }

                if (!string.IsNullOrEmpty(status))
                {
                    conditions.Add("Status = ?");
                    parameters.Add(new OleDbParameter("Status", status));
                }

                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    conn.Open();

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event evt = new Event()
                            {
                                EventID = Convert.ToInt32(reader["EventID"]),
                                EventName = reader["EventName"].ToString(),
                                EventCategory = reader["Category"].ToString(),
                                EventDescription = reader["Description"].ToString(),
                                EventStart = Convert.ToDateTime(reader["EventStart"]),
                                EventEnd = Convert.ToDateTime(reader["EventEnd"]),
                                EventStatus = reader["Status"].ToString(),
                                EventLocation = reader["Location"].ToString(),
                                EventMaxCapacity = Convert.ToInt32(reader["Capacity"]),
                            };
                            events.Add(evt);
                        }
                    }
                }
            }
            return events;
        }

        //search event by event name
        public List<Event> SearchEvent(string eventName)
        {
            List<Event> events = new List<Event>();
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.connectionString))
            {
                string query = "SELECT * FROM Events WHERE EventName LIKE ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", "%" + eventName + "%");
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event evt = new Event()
                            {
                                EventID = Convert.ToInt32(reader["EventID"]),
                                EventName = reader["EventName"].ToString(),
                                EventCategory = reader["Category"].ToString(),
                                EventDescription = reader["Description"].ToString(),
                                EventStart = Convert.ToDateTime(reader["EventStart"]),
                                EventEnd = Convert.ToDateTime(reader["EventEnd"]),
                                EventStatus = reader["Status"].ToString(),
                                EventLocation = reader["Location"].ToString(),
                                EventMaxCapacity = Convert.ToInt32(reader["Capacity"]),
                            };
                            events.Add(evt);
                        }
                    }
                }
            }
            return events;
        }

        //Get Current User Registered Events
        public List<Event> GetCurrentUserRegisteredEvents(int userID)
        {
            List<Event> events = new List<Event>();
            using (OleDbConnection conn = new OleDbConnection(DatabaseHelper.connectionString))
            {
                string query = "SELECT Events.* FROM Events INNER JOIN Attendees ON Events.EventID = Attendees.EventID WHERE Attendees.AttendeeID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", userID);
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event evt = new Event()
                            {
                                EventID = Convert.ToInt32(reader["EventID"]),
                                EventName = reader["EventName"].ToString(),
                                EventCategory = reader["Category"].ToString(),
                                EventDescription = reader["Description"].ToString(),
                                EventStart = Convert.ToDateTime(reader["EventStart"]),
                                EventEnd = Convert.ToDateTime(reader["EventEnd"]),
                                EventStatus = reader["Status"].ToString(),
                                EventLocation = reader["Location"].ToString(),
                                EventMaxCapacity = Convert.ToInt32(reader["Capacity"]),
                            };
                            events.Add(evt);
                        }
                    }
                }
            }
            return events;
        }
    }
}