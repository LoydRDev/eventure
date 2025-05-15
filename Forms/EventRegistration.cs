using System.Windows.Forms;
using System.Collections.Generic;

using eventure.Models;
using eventure.DataAccess;


namespace eventure.Forms
{
    public partial class EventRegistration: Form
    {
        private EventDAO eventDAO = new EventDAO();
        private AttendeeDAO attendeeDAO = new AttendeeDAO();
        Event evt = new Event();
        int userID;

        public EventRegistration(int userID, Event evt)
        {
            InitializeComponent();
            this.userID = userID;
            this.evt = evt;
        }

        private void EventRegistration_Load(object sender, System.EventArgs e)
        { 
            EventName.Text = evt.EventName;
            EventCategory.Text = evt.EventCategory;
            EventOwner.Text = eventDAO.GetEventCreatorName(evt.EventID);
            EventDescription.Text = evt.EventDescription;
            EventLocation.Text = evt.EventLocation;
            EventStart.Text = evt.EventStart.ToString("dd/MM/yy HH:mm");
            EventEnd.Text = evt.EventEnd.ToString("dd/MM/yy HH:mm");
            EventCapacity.Text = $"0/{evt.EventMaxCapacity}";
        }

        private void BtnRegisterEvent_Click(object sender, System.EventArgs e)
        {
            string eventStatus = evt.EventStatus;
            MessageBox.Show($"DEBUG: Event status is '{evt.EventStatus}'");
            if (eventStatus == "Upcoming")
            {
                attendeeDAO.RegisterEvent(evt.EventID, userID);
                MessageBox.Show("You have successfully registered for the event!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (evt.EventStatus == "Ongoing")
            {
                MessageBox.Show("Event is currently ongoing. You cannot register.");
            }
            else if (evt.EventStatus == "Completed")
            {
                MessageBox.Show("Event has already completed. You cannot register.");
            }
            else
            {
                MessageBox.Show("This event is not available for registration.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
