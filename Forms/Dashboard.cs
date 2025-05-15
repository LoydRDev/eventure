using System;
using System.Windows.Forms;

using eventure.Controller;

namespace eventure.Forms
{
    public partial class Dashboard: Form
    {
        EventController eventCon = new EventController();
        string username;
        public Dashboard(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            eventCon.LoadAllEvents(flowLayoutPanel1);   

        }

        private void BtnCreateEvent_Click(object sender, EventArgs e)
        {
            var createEventForm = new CreateEvent(username);
            createEventForm.FormClosed += (s, args) => this.Close();
            createEventForm.Show();
        }
    }
}
