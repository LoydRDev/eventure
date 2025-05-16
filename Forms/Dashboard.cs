using System;
using System.Windows.Forms;

using eventure.Controller;

namespace eventure.Forms
{
    public partial class Dashboard: Form
    {
        int userID;

        public Dashboard(int userID)
        {
            this.userID = userID;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            EventController eventCon = new EventController(userID);
            eventCon.LoadAllEvents(FLPBrowseEvents);
            eventCon.LoadAllConfirmations(FLPConfirmation);
            eventCon.LoadCurrentUserEvents(FLPManageEvents);
        }

        private void BtnCreateEvent_Click(object sender, EventArgs e)
        {
            EventController eventCon = new EventController(userID);
            var createEventForm = new CreateEvent(userID);
            createEventForm.FormClosed += (s, args) => this.Close();
            createEventForm.Show();
        }

        private void tcDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventController eventCon = new EventController(userID);
            eventCon.LoadAllEvents(FLPBrowseEvents);
            eventCon.LoadAllConfirmations(FLPConfirmation);
            eventCon.LoadCurrentUserEvents(FLPManageEvents);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
