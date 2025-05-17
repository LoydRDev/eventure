using System.Windows.Forms;


using eventure.Models;
using eventure.DataAccess;


namespace eventure.Forms
{
    public partial class EventRegistration: Form
    {
        private EventDAO eventDAO = new EventDAO();
        private AttendeeDAO attendeeDAO = new AttendeeDAO();
        private NotificationDAO notif = new NotificationDAO();
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

        //RegisterEvent

        private void BtnRegisterEvent_Click(object sender, System.EventArgs e)
        {
            string eventStatus = evt.EventStatus;
            if (eventStatus == "Upcoming")
            {
                //Message wait for the Event Owner to approve
                var result = MessageBox.Show("You have successfully registered for the event! Please wait for the event owner to approve your registration.", "Registration Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new AttendeeDAO().RegisterEvent(evt.EventID, userID);
                if (result == DialogResult.OK)
                {
                    notif.SendNotifToEventOwner(evt.EventID, userID, evt.CreatorID);
                    MessageBox.Show("Event owner has been notified of your registration.", "Notification Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
