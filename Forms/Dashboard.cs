using System;
using System.Windows.Forms;

using eventure.UIObj;

namespace eventure.Forms
{
    public partial class Dashboard: Form
    {
        LoadEvents loadEvents = new LoadEvents();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadEvents.LoadAllEvents(flowLayoutPanel1);
        }
    }
}
