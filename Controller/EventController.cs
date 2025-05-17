using System.Collections.Generic;
using System.Windows.Forms;

using eventure.DataAccess;
using eventure.Forms;
using eventure.Models;
using Guna.UI2.WinForms;


namespace eventure.Controller
{
    class EventController
    {
        private EventDAO eventDAO = new EventDAO();
        private List<Event> events = new EventDAO().GetEvents();
        Event evt = new Event();


        int userID;

        public EventController(int userID)
        {
            this.userID = userID;
        }

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
        public List<Guna2GradientPanel> GetEvents(Event evt)
        {
            var guna2GradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2GradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            guna2GradientPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            guna2GradientPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
            guna2GradientPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            guna2GradientPanel.Location = new System.Drawing.Point(17, 15);
            guna2GradientPanel.Margin = new System.Windows.Forms.Padding(7, 10, 3, 3);
            guna2GradientPanel.Name = "guna2GradientPanel";
            guna2GradientPanel.Size = new System.Drawing.Size(175, 248);
            guna2GradientPanel.TabIndex = 1;

            var guna2ImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2ImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            guna2ImageButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            guna2ImageButton.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton8.Image")));
            guna2ImageButton.ImageOffset = new System.Drawing.Point(0, 0);
            guna2ImageButton.ImageRotate = 0F;
            guna2ImageButton.Location = new System.Drawing.Point(19, 32);
            guna2ImageButton.Name = "guna2ImageButton";
            guna2ImageButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            guna2ImageButton.Size = new System.Drawing.Size(134, 106);
            guna2ImageButton.TabIndex = 8;

            var guna2Button = new Guna.UI2.WinForms.Guna2Button();
            guna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            guna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            guna2Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            guna2Button.ForeColor = System.Drawing.Color.White;
            guna2Button.Location = new System.Drawing.Point(3, 219);
            guna2Button.Name = "guna2Button";
            guna2Button.Size = new System.Drawing.Size(169, 18);
            guna2Button.TabIndex = 6;
            guna2Button.Text = CustomizeButton(evt);
            guna2Button.Tag = evt;
            guna2Button.Click += (s, args) => EventButton(evt);

            var guna2HtmlLabelEventName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabelEventName.AutoSize = false;
            guna2HtmlLabelEventName.BackColor = System.Drawing.Color.Transparent;
            guna2HtmlLabelEventName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guna2HtmlLabelEventName.ForeColor = System.Drawing.Color.Black;
            guna2HtmlLabelEventName.Location = new System.Drawing.Point(3, 7);
            guna2HtmlLabelEventName.Name = "guna2HtmlLabelEventName";
            guna2HtmlLabelEventName.Size = new System.Drawing.Size(169, 19);
            guna2HtmlLabelEventName.TabIndex = 1;
            guna2HtmlLabelEventName.Text = evt.EventName;
            guna2HtmlLabelEventName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            var guna2HtmlLabelEventCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabelEventCategory.AutoSize = false;
            guna2HtmlLabelEventCategory.BackColor = System.Drawing.Color.Transparent;
            guna2HtmlLabelEventCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guna2HtmlLabelEventCategory.ForeColor = System.Drawing.Color.Black;
            guna2HtmlLabelEventCategory.Location = new System.Drawing.Point(3, 144);
            guna2HtmlLabelEventCategory.Name = "guna2HtmlLabelEventCategory";
            guna2HtmlLabelEventCategory.Size = new System.Drawing.Size(169, 19);
            guna2HtmlLabelEventCategory.TabIndex = 2;
            guna2HtmlLabelEventCategory.Text = evt.EventCategory;
            guna2HtmlLabelEventCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            var guna2HtmlLabelEventLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabelEventLocation.BackColor = System.Drawing.Color.Transparent;
            guna2HtmlLabelEventLocation.Location = new System.Drawing.Point(3, 169);
            guna2HtmlLabelEventLocation.Name = "guna2HtmlLabelEventLocation";
            guna2HtmlLabelEventLocation.Size = new System.Drawing.Size(78, 15);
            guna2HtmlLabelEventLocation.TabIndex = 3;
            guna2HtmlLabelEventLocation.Text = evt.EventLocation;

            var guna2HtmlLabelEventStart = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabelEventStart.BackColor = System.Drawing.Color.Transparent;
            guna2HtmlLabelEventStart.Location = new System.Drawing.Point(3, 190);
            guna2HtmlLabelEventStart.Name = "guna2HtmlLabelEventStart";
            guna2HtmlLabelEventStart.Size = new System.Drawing.Size(59, 15);
            guna2HtmlLabelEventStart.TabIndex = 4;
            guna2HtmlLabelEventStart.Text = evt.EventStart.ToString("dd/MM/yy HH:MM");

            var guna2HtmlLabelEventEnd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabelEventEnd.BackColor = System.Drawing.Color.Transparent;
            guna2HtmlLabelEventEnd.Location = new System.Drawing.Point(113, 190);
            guna2HtmlLabelEventEnd.Name = "guna2HtmlLabelEventEnd";
            guna2HtmlLabelEventEnd.Size = new System.Drawing.Size(56, 15);
            guna2HtmlLabelEventEnd.TabIndex = 5;
            guna2HtmlLabelEventEnd.Text = evt.EventEnd.ToString("dd/MM/yy HH:MM");

            guna2GradientPanel.Controls.Add(guna2ImageButton);
            guna2GradientPanel.Controls.Add(guna2Button);
            guna2GradientPanel.Controls.Add(guna2HtmlLabelEventName);
            guna2GradientPanel.Controls.Add(guna2HtmlLabelEventCategory);
            guna2GradientPanel.Controls.Add(guna2HtmlLabelEventLocation);
            guna2GradientPanel.Controls.Add(guna2HtmlLabelEventStart);
            guna2GradientPanel.Controls.Add(guna2HtmlLabelEventEnd);

            return new List<Guna2GradientPanel> { guna2GradientPanel };
        }

        public void LoadAllEvents(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();

            for (int i = 0; i < events.Count; i++)
            {
                Event evt = events[i];
                var eventPanels = GetEvents(evt);
                foreach (var panel in eventPanels)
                {
                    flowLayoutPanel.Controls.Add(panel);
                }
            }
        }

        private string CustomizeButton(Event e)
        {
            var currentUser = new UserDAO().GetCurrentUser(userID);
            var guna2Button = new Guna.UI2.WinForms.Guna2Button();

            if (currentUser != null)
            {
                if (currentUser.UserID == e.CreatorID)
                {
                    guna2Button.Text = "Edit Event";
                }
                else
                {
                    guna2Button.Text = "Join Event";
                }
            }
            else
            {
                guna2Button.Text = "Join Event";
            }

            return guna2Button.Text;
        }

        private void EventButton(Event e)
        {
            string cButton = CustomizeButton(e);
            if (cButton == "Edit Event")
            {
                int selectedEventID = e.EventID;
                Event selectedEvent = new EventDAO().GetEventByID(selectedEventID);
            }
            else if (cButton == "Join Event")
            {
                int selectedEventID = e.EventID;
                Event selectedEvent = new EventDAO().GetEventByID(selectedEventID);
                var eventRegistration = new EventRegistration(userID, selectedEvent);
                eventRegistration.Show();
            }
        }

        public void ViewAttendeeDetails(Attendee attendee, Event e)
        {
            int selectedEventID = e.EventID;
            Event selectedEvent = new EventDAO().GetEventByID(selectedEventID);
            var viewAttendeeDetails = new AttendeeDetails(attendee.AttendeeID, selectedEvent);
            viewAttendeeDetails.Show();
        }

        public void LoadAllConfirmations(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();
            var currentUser = new UserDAO().GetCurrentUser(userID);
            foreach (var ev in events)
            {
                if (currentUser != null && currentUser.UserID == ev.CreatorID)
                {
                    flowLayoutPanel.Controls.Clear();
                    var attendeeList = new AttendeeDAO().GetAttendees(ev.EventID, userID);
                    //If status is Approved, skip
                    for (int i = 0; i < attendeeList.Count; i++)
                    {
                        Attendee attendee = attendeeList[i];

                        if (attendee.Status != "Approved")
                        {
                            Event evt = new EventDAO().GetEventByID(attendee.EventID);
                            User user = new UserDAO().GetUserByID(attendee.AttendeeID);

                            var PanelConfirmation = new Guna.UI2.WinForms.Guna2GradientPanel();
                            PanelConfirmation.BackColor = System.Drawing.Color.Transparent;
                            PanelConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                            PanelConfirmation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                            PanelConfirmation.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
                            PanelConfirmation.Location = new System.Drawing.Point(8, 8);
                            PanelConfirmation.Name = "PanelConfirmation" + i;
                            PanelConfirmation.Size = new System.Drawing.Size(358, 49);
                            PanelConfirmation.TabIndex = 0;

                            var UserFullname = new Guna.UI2.WinForms.Guna2HtmlLabel();
                            UserFullname.AutoSize = false;
                            UserFullname.BackColor = System.Drawing.Color.Transparent;
                            UserFullname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            UserFullname.Location = new System.Drawing.Point(114, 15);
                            UserFullname.Name = "UserFullname" + i;
                            UserFullname.Size = new System.Drawing.Size(152, 15);
                            UserFullname.TabIndex = 2;
                            UserFullname.Text = user.FirstName + " " + user.LastName;
                            UserFullname.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
                            UserFullname.Click += (s, args) => ViewAttendeeDetails(attendee, evt);

                            var EventName = new Guna.UI2.WinForms.Guna2HtmlLabel();
                            EventName.AutoSize = false;
                            EventName.BackColor = System.Drawing.Color.Transparent;
                            EventName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            EventName.Location = new System.Drawing.Point(3, 15);
                            EventName.Name = "EventName";
                            EventName.Size = new System.Drawing.Size(120, 15);
                            EventName.TabIndex = 1;
                            EventName.Text = evt.EventName;

                            var BtnApprove = new Guna.UI2.WinForms.Guna2PictureBox();
                            BtnApprove.BackColor = System.Drawing.Color.Transparent;
                            BtnApprove.FillColor = System.Drawing.Color.Black;
                            BtnApprove.Image = global::eventure.Properties.Resources.check2;
                            BtnApprove.ImageRotate = 0F;
                            BtnApprove.Location = new System.Drawing.Point(312, 8);
                            BtnApprove.Name = "BtnApprove";
                            BtnApprove.Size = new System.Drawing.Size(30, 31);
                            BtnApprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                            BtnApprove.TabIndex = 3;
                            BtnApprove.TabStop = false;
                            BtnApprove.Click += (s, args) => ConfirmRegistration(attendee.EventID, attendee.AttendeeID);

                            var BtnReject = new Guna.UI2.WinForms.Guna2ImageButton();
                            BtnReject.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
                            BtnReject.HoverState.ImageSize = new System.Drawing.Size(64, 64);
                            BtnReject.Image = global::eventure.Properties.Resources.cancel;
                            BtnReject.ImageOffset = new System.Drawing.Point(0, 0);
                            BtnReject.ImageRotate = 0F;
                            BtnReject.Location = new System.Drawing.Point(321, 13);
                            BtnReject.Name = "BtnReject";
                            BtnReject.PressedState.ImageSize = new System.Drawing.Size(64, 64);
                            BtnReject.Size = new System.Drawing.Size(22, 21);
                            BtnReject.TabIndex = 3;
                            BtnReject.Click += (s, args) => RejectRegistration(attendee.EventID, attendee.AttendeeID);

                            PanelConfirmation.Controls.Add(BtnReject);
                            PanelConfirmation.Controls.Add(UserFullname);
                            PanelConfirmation.Controls.Add(BtnApprove);
                            PanelConfirmation.Controls.Add(EventName);

                            flowLayoutPanel.Controls.Add(PanelConfirmation);
                        }
                    }
                }
            }
        }

        public void ConfirmRegistration(int eventID, int userID)
        {
            var result = MessageBox.Show("Do you want to approve this registration?", "Approve Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Registration approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new AttendeeDAO().ApproveRegistration(eventID, userID);
            }
        }

        public void RejectRegistration(int eventID, int userID)
        {
            var result = MessageBox.Show("Do you want to reject this registration?", "Reject Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                new AttendeeDAO().RejectRegistration(eventID, userID);
                MessageBox.Show("Registration rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registration not rejected.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //getCurrentUserEvents

        public void LoadCurrentUserEvents(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();
            var currentUser = new UserDAO().GetCurrentUser(userID);
            foreach (var e in events)
            {
                if (currentUser != null && currentUser.UserID == e.CreatorID)
                {
                    flowLayoutPanel.Controls.Clear();
                    var userEvents = new EventDAO().getCurrentUserEvents(currentUser.UserID);
                    for (int i = 0; i < userEvents.Count; i++)
                    {
                        Event events = userEvents[i];

                        var guna2GradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
                        guna2GradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
                        guna2GradientPanel.FillColor2 = System.Drawing.Color.Silver;
                        guna2GradientPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
                        guna2GradientPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
                        guna2GradientPanel.Location = new System.Drawing.Point(7, 10);
                        guna2GradientPanel.Margin = new System.Windows.Forms.Padding(7, 10, 3, 3);
                        guna2GradientPanel.Name = "guna2GradientPanel4" + i;
                        guna2GradientPanel.Size = new System.Drawing.Size(181, 217);
                        guna2GradientPanel.TabIndex = 2;

                        var guna2ImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
                        guna2ImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
                        guna2ImageButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
                        guna2ImageButton.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton9.Image")));
                        guna2ImageButton.ImageOffset = new System.Drawing.Point(0, 0);
                        guna2ImageButton.ImageRotate = 0F;
                        guna2ImageButton.Location = new System.Drawing.Point(46, 32);
                        guna2ImageButton.Name = "guna2ImageButton9" + i;
                        guna2ImageButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
                        guna2ImageButton.Size = new System.Drawing.Size(89, 78);
                        guna2ImageButton.TabIndex = 8;

                        var guna2Button = new Guna.UI2.WinForms.Guna2Button();
                        guna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
                        guna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
                        guna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
                        guna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
                        guna2Button.Font = new System.Drawing.Font("Segoe UI", 9F);
                        guna2Button.ForeColor = System.Drawing.Color.White;
                        guna2Button.Location = new System.Drawing.Point(4, 189);
                        guna2Button.Name = "guna2Button2" + i;
                        guna2Button.Size = new System.Drawing.Size(169, 18);
                        guna2Button.TabIndex = 6;
                        guna2Button.Text = CustomizeButton(e);
                        guna2Button.Click += (s, args) => EventButton(e);

                        var LblEventEnd = new Guna.UI2.WinForms.Guna2HtmlLabel();
                        LblEventEnd.BackColor = System.Drawing.Color.Transparent;
                        LblEventEnd.Location = new System.Drawing.Point(115, 161);
                        LblEventEnd.Name = "guna2HtmlLabel11" + i;
                        LblEventEnd.Size = new System.Drawing.Size(56, 15);
                        LblEventEnd.TabIndex = 5;
                        LblEventEnd.Text = events.EventEnd.ToString();

                        var LblEventStart = new Guna.UI2.WinForms.Guna2HtmlLabel();
                        LblEventStart.BackColor = System.Drawing.Color.Transparent;
                        LblEventStart.Location = new System.Drawing.Point(3, 162);
                        LblEventStart.Name = "guna2HtmlLabel12" + i;
                        LblEventStart.Size = new System.Drawing.Size(59, 15);
                        LblEventStart.TabIndex = 4;
                        LblEventStart.Text = events.EventStart.ToString();

                        var LblEventLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
                        LblEventLocation.BackColor = System.Drawing.Color.Transparent;
                        LblEventLocation.Location = new System.Drawing.Point(3, 141);
                        LblEventLocation.Name = "guna2HtmlLabel13" + i;
                        LblEventLocation.Size = new System.Drawing.Size(78, 15);
                        LblEventLocation.TabIndex = 3;
                        LblEventLocation.Text = events.EventLocation;

                        var LblEventCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
                        LblEventCategory.AutoSize = false;
                        LblEventCategory.BackColor = System.Drawing.Color.Transparent;
                        LblEventCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        LblEventCategory.ForeColor = System.Drawing.Color.Black;
                        LblEventCategory.Location = new System.Drawing.Point(4, 115);
                        LblEventCategory.Name = "guna2HtmlLabel14" + i;
                        LblEventCategory.Size = new System.Drawing.Size(169, 19);
                        LblEventCategory.TabIndex = 2;
                        LblEventCategory.Text = events.EventCategory;
                        LblEventCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                        var LblEventName = new Guna.UI2.WinForms.Guna2HtmlLabel();
                        LblEventName.AutoSize = false;
                        LblEventName.BackColor = System.Drawing.Color.Transparent;
                        LblEventName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        LblEventName.ForeColor = System.Drawing.Color.Black;
                        LblEventName.Location = new System.Drawing.Point(4, 13);
                        LblEventName.Name = "guna2HtmlLabel15" + i;
                        LblEventName.Size = new System.Drawing.Size(172, 19);
                        LblEventName.TabIndex = 1;
                        LblEventName.Text = events.EventName;
                        LblEventName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                        guna2GradientPanel.Controls.Add(guna2ImageButton);
                        guna2GradientPanel.Controls.Add(guna2Button);
                        guna2GradientPanel.Controls.Add(LblEventEnd);
                        guna2GradientPanel.Controls.Add(LblEventStart);
                        guna2GradientPanel.Controls.Add(LblEventLocation);
                        guna2GradientPanel.Controls.Add(LblEventCategory);
                        guna2GradientPanel.Controls.Add(LblEventName);

                        flowLayoutPanel.Controls.Add(guna2GradientPanel);
                    }
                }
            }
        }

        public void LoadEventSorted(FlowLayoutPanel flowLayoutPanel, string selectedCategory, string selectedStatus)
        {
            flowLayoutPanel.Controls.Clear();
            var evt = new EventDAO().GetEventSorted(selectedCategory, selectedStatus);
            for (int i = 0; i < evt.Count; i++)
            {
                Event events = evt[i];
                var eventPanels = GetEvents(events);
                foreach (var panel in eventPanels)
                {
                    flowLayoutPanel.Controls.Add(panel);
                }
            }
        }

        public void SearchEvents(FlowLayoutPanel flowLayoutPanel, string searchBar) 
        {
            flowLayoutPanel.Controls.Clear();
            var evt = new EventDAO().SearchEvent(searchBar);
            for (int i = 0; i < evt.Count; i++)
            {
                Event events = evt[i];
                var eventPanels = GetEvents(events);
                foreach (var panel in eventPanels)
                {
                    flowLayoutPanel.Controls.Add(panel);
                }
            }
        }
      
        public void LoadCurrentUserRegisteredEvents(FlowLayoutPanel flowLayoutPanel)
        {
           flowLayoutPanel.Controls.Clear();
            var currentUser = new UserDAO().GetCurrentUser(userID);
            foreach (var e in events)
            {
                if (currentUser != null && currentUser.UserID == e.CreatorID)
                {
                    var userEvents = new EventDAO().GetCurrentUserRegisteredEvents(currentUser.UserID);
                    for (int i = 0; i < userEvents.Count; i++)
                    {
                        Event events = userEvents[i];
                        
                        var guna2GradientPanel22 = new Guna.UI2.WinForms.Guna2GradientPanel();
                        guna2GradientPanel22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                        guna2GradientPanel22.FillColor2 = System.Drawing.Color.Silver;
                        guna2GradientPanel22.Location = new System.Drawing.Point(13, 8);
                        guna2GradientPanel22.Name = "guna2GradientPanel22";
                        guna2GradientPanel22.Size = new System.Drawing.Size(362, 49);
                        guna2GradientPanel22.TabIndex = 1;
                        
                        var guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
                        guna2HtmlLabel21.AutoSize = false;
                        guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
                        guna2HtmlLabel21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        guna2HtmlLabel21.Location = new System.Drawing.Point(137, 16);
                        guna2HtmlLabel21.Name = "guna2HtmlLabel21";
                        guna2HtmlLabel21.Size = new System.Drawing.Size(81, 15);
                        guna2HtmlLabel21.TabIndex = 4;
                        guna2HtmlLabel21.Text = events.EventName;

                        guna2GradientPanel22.Controls.Add(guna2HtmlLabel21);

                        flowLayoutPanel.Controls.Add(guna2GradientPanel22);
                    }
                }
            }
        }
    }
}
