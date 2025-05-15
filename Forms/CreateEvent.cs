using System;
using System.Drawing;
using System.Windows.Forms;

using eventure.Models;
using eventure.DataAccess;
using eventure.Controller;


namespace eventure.Forms
{
    public partial class CreateEvent : Form
    {
        private EventController eventCon = new EventController();
        private Event eventData;
        string username;
        public CreateEvent(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            TCCreateEvent.SelectedTab = TCCreateEvent.TabPages[1];
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            eventData.EventName = TBEventName.Text;
            eventData.EventCategory = CBEventType.SelectedItem.ToString();
            eventData.EventDescription = TBEventDescription.Text;
            eventData.EventLocation = TBEventLocation.Text;
            eventData.EventStart = eventCon.ConvertDateTimeToString(DTPEventStart.Value);
            eventData.EventEnd = eventCon.ConvertDateTimeToString(DTPEventEnd.Value);
            eventData.EventMaxCapacity = Convert.ToInt32(NUPEventMaxCapacity.Text);
            TCCreateEvent.SelectedTab = TCCreateEvent.TabPages[2];
            LblEventName.Text = eventData.EventName;
            LblEventType.Text = eventData.EventCategory;
            LblEventLocation.Text = eventData.EventLocation;
            LblEventStart.Text = eventData.EventStart;
            LblEventEnd.Text = eventData.EventEnd;
            LblEventMaxCapacity.Text = eventData.EventMaxCapacity.ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TCCreateEvent.SelectedTab = TCCreateEvent.TabPages[0];
        }

        private void BtnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            var currentUser = new UserDAO().GetCurrentUser(username);

            if (Validations())
            {
                Event events = new Event
                {
                    EventName = TBEventName.Text,
                    EventDescription = TBEventDescription.Text,
                    EventLocation = TBEventLocation.Text,
                    EventStart = eventCon.ConvertDateTimeToString(DTPEventStart.Value),
                    EventEnd = eventCon.ConvertDateTimeToString(DTPEventEnd.Value),
                    EventMaxCapacity = Convert.ToInt32(NUPEventMaxCapacity.Text),
                    EventCategory = CBEventType.SelectedItem.ToString(),
                    CreatorID = currentUser.UserID
                };
            }
        }

        private bool Validations()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(TBEventName.Text))
            {
                TBEventName.BorderColor = Color.Red;
                isValid = false;
            }


            return isValid;
        }
    }
}
