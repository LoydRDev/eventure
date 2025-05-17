using System.Windows.Forms;

using eventure.Controller;
using eventure.DataAccess;
using eventure.Models;

namespace eventure.Forms
{
    public partial class AttendeeDetails: Form
    {
        private EventDAO eventDAO = new EventDAO();
        private AttendeeDAO attendeeDAO = new AttendeeDAO();
        Event evt = new Event();
        Attendee attendee = new Attendee();
        int userID;

        public AttendeeDetails(int userID, Event evt)
        {
            InitializeComponent();
            this.userID = userID;
            this.evt = evt;
        }

        private void AttendeeDetails_Load(object sender, System.EventArgs e)
        {
            EventName.Text = evt.EventName;
            EventCategory.Text = evt.EventCategory;
            EventDescription.Text = evt.EventDescription;
            AttendeeFullname.Text = attendeeDAO.GetAttendeeFullname(evt.EventID,userID);
            AttendeeEmail.Text = attendeeDAO.GetAttendeeEmail(evt.EventID, userID);
        }

        private void BtnConfirmEvent_Click(object sender, System.EventArgs e)
        {
            var eventCon = new EventController(userID);
            eventCon.ConfirmRegistration(evt.EventID, userID);
            var result = MessageBox.Show("You have successfully confirmed this registration for the event!", "Registration Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Attendee has been notified of the confirmation.", "Notification Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void BtnRejectRegister_Click(object sender, System.EventArgs e)
        {
            var eventCon = new EventController(userID);
            eventCon.RejectRegistration(evt.EventID, userID);
            var result = MessageBox.Show("You have successfully rejected this registration for the event!", "Registration Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Attendee has been notified of the rejection.", "Notification Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
