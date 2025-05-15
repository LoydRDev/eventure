using System;
using System.Windows.Forms;

using eventure.Controller;

namespace eventure.Forms
{
    public partial class Dashboard: Form
    {
        EventController eventCon = new EventController();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            eventCon.LoadAllEvents(flowLayoutPanel1);   

        }
    }
}
