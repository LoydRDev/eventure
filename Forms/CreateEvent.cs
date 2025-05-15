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
        private EventDAO eventDAO = new EventDAO();
        private Event eventData = new Event();
        int userID;
        public CreateEvent(int userID)
        {
            this.userID = userID;
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
            eventData.EventStart = DTPEventStart.Value;
            eventData.EventEnd = DTPEventEnd.Value;
            eventData.EventMaxCapacity = Convert.ToInt32(NUPEventMaxCapacity.Text);
            TCCreateEvent.SelectedTab = TCCreateEvent.TabPages[2];
            LblEventName.Text = eventData.EventName;
            LblEventType.Text = eventData.EventCategory;
            LblEventLocation.Text = eventData.EventLocation;
            LblEventStart.Text = eventData.EventStart.ToString("dd/MM/yy HH:MM");
            LblEventEnd.Text = eventData.EventEnd.ToString("dd/MM/yy HH:MM");
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
            var currentUser = new UserDAO().GetCurrentUser(userID);

            if (Validations())
            {
                var result = MessageBox.Show("Are you sure you want to create this event?", "Create Event", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Event events = new Event
                    {
                        EventName = TBEventName.Text,
                        EventDescription = TBEventDescription.Text,
                        EventLocation = TBEventLocation.Text,
                        EventStart = DTPEventStart.Value,
                        EventEnd = DTPEventEnd.Value,
                        EventMaxCapacity = Convert.ToInt32(NUPEventMaxCapacity.Text),
                        EventCategory = CBEventType.SelectedItem.ToString(),
                        CreatorID = currentUser.UserID
                    };
                    eventDAO.CreateEvent(events);
                    this.Hide();
                }
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
