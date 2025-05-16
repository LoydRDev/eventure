using System.Collections.Generic;
using System.Web.Management;
using System.Windows.Forms;

using eventure.DataAccess;
using eventure.Forms;
using eventure.Models;


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
        public void LoadAllEvents(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();

            for (int i = 0; i < events.Count; i++)
            {
                Event evt = events[i];


                var guna2GradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
                guna2GradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                guna2GradientPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                guna2GradientPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
                guna2GradientPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
                guna2GradientPanel.Location = new System.Drawing.Point(17, 15);
                guna2GradientPanel.Margin = new System.Windows.Forms.Padding(7, 10, 3, 3);
                guna2GradientPanel.Name = "guna2GradientPanel" + i;
                guna2GradientPanel.Size = new System.Drawing.Size(175, 248);
                guna2GradientPanel.TabIndex = 1;

                var guna2ImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
                guna2ImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton8.Image")));
                guna2ImageButton.ImageOffset = new System.Drawing.Point(0, 0);
                guna2ImageButton.ImageRotate = 0F;
                guna2ImageButton.Location = new System.Drawing.Point(19, 32);
                guna2ImageButton.Name = "guna2ImageButton" + i;
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
                guna2Button.Name = "guna2Button" + i;
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
                guna2HtmlLabelEventName.Name = "guna2HtmlLabelEventName" + i;
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
                guna2HtmlLabelEventCategory.Name = "guna2HtmlLabelEventCategory" + i;
                guna2HtmlLabelEventCategory.Size = new System.Drawing.Size(169, 19);
                guna2HtmlLabelEventCategory.TabIndex = 2;
                guna2HtmlLabelEventCategory.Text = evt.EventCategory;
                guna2HtmlLabelEventCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

                var guna2HtmlLabelEventLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
                guna2HtmlLabelEventLocation.BackColor = System.Drawing.Color.Transparent;
                guna2HtmlLabelEventLocation.Location = new System.Drawing.Point(3, 169);
                guna2HtmlLabelEventLocation.Name = "guna2HtmlLabelEventLocation" + i;
                guna2HtmlLabelEventLocation.Size = new System.Drawing.Size(78, 15);
                guna2HtmlLabelEventLocation.TabIndex = 3;
                guna2HtmlLabelEventLocation.Text = evt.EventLocation;

                var guna2HtmlLabelEventStart = new Guna.UI2.WinForms.Guna2HtmlLabel();
                guna2HtmlLabelEventStart.BackColor = System.Drawing.Color.Transparent;
                guna2HtmlLabelEventStart.Location = new System.Drawing.Point(3, 190);
                guna2HtmlLabelEventStart.Name = "guna2HtmlLabelEventStart" + i;
                guna2HtmlLabelEventStart.Size = new System.Drawing.Size(59, 15);
                guna2HtmlLabelEventStart.TabIndex = 4;
                guna2HtmlLabelEventStart.Text = evt.EventStart.ToString("dd/MM/yy HH:MM");

                var guna2HtmlLabelEventEnd = new Guna.UI2.WinForms.Guna2HtmlLabel();
                guna2HtmlLabelEventEnd.BackColor = System.Drawing.Color.Transparent;
                guna2HtmlLabelEventEnd.Location = new System.Drawing.Point(113, 190);
                guna2HtmlLabelEventEnd.Name = "guna2HtmlLabelEventStart" + i;
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

                flowLayoutPanel.Controls.Add(guna2GradientPanel);
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

            }
            else if (cButton == "Join Event")
            {
                int selectedEventID = e.EventID;
                Event selectedEvent = new EventDAO().GetEventByID(selectedEventID);
                var eventRegistration = new EventRegistration(userID, selectedEvent);
                eventRegistration.Show();
            }
        }

        public void LoadAllConfirmations(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();
            var currentUser = new UserDAO().GetCurrentUser(userID);
            foreach (var ev in events)
            {
                if(currentUser != null && currentUser.UserID == ev.CreatorID)
                {
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
                            UserFullname.Click += (s, args) => ViewAttendeeDetails();

                            var EventName = new Guna.UI2.WinForms.Guna2HtmlLabel();
                            EventName.AutoSize = false;
                            EventName.BackColor = System.Drawing.Color.Transparent;
                            EventName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            EventName.Location = new System.Drawing.Point(3, 15);
                            EventName.Name = "EventName";
                            EventName.Size = new System.Drawing.Size(120, 15);
                            EventName.TabIndex = 1;
                            EventName.Text = evt.EventName;

                            var BtnApprove = new Guna.UI2.WinForms.Guna2ImageButton();
                            BtnApprove.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
                            BtnApprove.HoverState.ImageSize = new System.Drawing.Size(64, 64);
                            BtnApprove.Image = ((System.Drawing.Image)(resources.GetObject("BtnApprove.Image")));
                            BtnApprove.ImageOffset = new System.Drawing.Point(0, 0);
                            BtnApprove.ImageRotate = 0F;
                            BtnApprove.Location = new System.Drawing.Point(293, 13);
                            BtnApprove.Name = "BtnApprove";
                            BtnApprove.PressedState.ImageSize = new System.Drawing.Size(64, 64);
                            BtnApprove.Size = new System.Drawing.Size(22, 21);
                            BtnApprove.TabIndex = 1;
                            BtnApprove.Click += (s, args) => ConfirmRegistration(attendee.EventID, attendee.AttendeeID);

                            var BtnReject = new Guna.UI2.WinForms.Guna2ImageButton();
                            BtnReject.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
                            BtnReject.HoverState.ImageSize = new System.Drawing.Size(64, 64);
                            BtnReject.Image = ((System.Drawing.Image)(resources.GetObject("BtnReject.Image")));
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
                        else if (attendee.Status == "Rejected")
                        {
                            continue;
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
            else
            {
                MessageBox.Show("Registration not approved.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void ViewAttendeeDetails()
        {

        }
    }
}
