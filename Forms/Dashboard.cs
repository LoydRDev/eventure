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
            eventCon.LoadCurrentUserRegisteredEvents(FLPEventsRegistered);
        }
        private void FilterEvents()
        {
            string selectedCategory = CBCategory.SelectedItem != null ? CBCategory.SelectedItem.ToString() : "";
            string selectedStatus = CBStatus.SelectedItem != null ? CBStatus.SelectedItem.ToString() : "";

            EventController eventCon = new EventController(userID);
            eventCon.LoadEventSorted(FLPBrowseEvents, selectedCategory, selectedStatus);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterEvents();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterEvents();
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Perform the search
                string searchText = SearchBar.Text;
                EventController eventCon = new EventController(userID);
                eventCon.SearchEvents(FLPBrowseEvents, searchText);
            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
