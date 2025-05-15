using System.Collections.Generic;
using System.Windows.Forms;

using eventure.DataAccess;
using eventure.Forms;
using eventure.Models;

namespace eventure.Controller
{
    class EventController
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
        public void LoadAllEvents(FlowLayoutPanel flowLayoutPanel)
        {
            List<Event> events = new EventDAO().GetEvents();
            flowLayoutPanel.Controls.Clear();
            foreach (Event e in events)
            {
                var guna2GradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
                guna2GradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                guna2GradientPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
                guna2GradientPanel.ForeColor = System.Drawing.SystemColors.ControlDark;
                guna2GradientPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
                guna2GradientPanel.Location = new System.Drawing.Point(17, 15);
                guna2GradientPanel.Margin = new System.Windows.Forms.Padding(7, 10, 3, 3);
                guna2GradientPanel.Name = "guna2GradientPanel3";
                guna2GradientPanel.Size = new System.Drawing.Size(175, 248);
                guna2GradientPanel.TabIndex = 1;

                var guna2ImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
                guna2ImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
                guna2ImageButton.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton8.Image")));
                guna2ImageButton.ImageOffset = new System.Drawing.Point(0, 0);
                guna2ImageButton.ImageRotate = 0F;
                guna2ImageButton.Location = new System.Drawing.Point(19, 32);
                guna2ImageButton.Name = "guna2ImageButton8";
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
                guna2Button.Name = "guna2Button1";
                guna2Button.Size = new System.Drawing.Size(169, 18);
                guna2Button.TabIndex = 6;
                guna2Button.Text = "Join Event";
                guna2Button.Click += new System.EventHandler(JoinEvent());

                var guna2HtmlLabelEventName = new Guna.UI2.WinForms.Guna2HtmlLabel();
                guna2HtmlLabelEventName.BackColor = System.Drawing.Color.Transparent;
                guna2HtmlLabelEventName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                guna2HtmlLabelEventName.ForeColor = System.Drawing.Color.Black;
                guna2HtmlLabelEventName.Location = new System.Drawing.Point(49, 7);
                guna2HtmlLabelEventName.Name = "guna2HtmlLabel6";
                guna2HtmlLabelEventName.Size = new System.Drawing.Size(78, 19);
                guna2HtmlLabelEventName.TabIndex = 1;
                guna2HtmlLabelEventName.Text = "Event_Name";

                var guna2HtmlLabelEventCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
                guna2HtmlLabelEventCategory.BackColor = System.Drawing.Color.Transparent;
                guna2HtmlLabelEventCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                guna2HtmlLabelEventCategory.ForeColor = System.Drawing.Color.Black;
                guna2HtmlLabelEventCategory.Location = new System.Drawing.Point(40, 144);
                guna2HtmlLabelEventCategory.Name = "guna2HtmlLabel7";
                guna2HtmlLabelEventCategory.Size = new System.Drawing.Size(97, 19);
                guna2HtmlLabelEventCategory.TabIndex = 2;
                guna2HtmlLabelEventCategory.Text = "Event_Category";

                var guna2HtmlLabelEventLocation = new Guna.UI2.WinForms.Guna2HtmlLabel();
                guna2HtmlLabelEventLocation.BackColor = System.Drawing.Color.Transparent;
                guna2HtmlLabelEventLocation.Location = new System.Drawing.Point(3, 169);
                guna2HtmlLabelEventLocation.Name = "guna2HtmlLabel8";
                guna2HtmlLabelEventLocation.Size = new System.Drawing.Size(78, 15);
                guna2HtmlLabelEventLocation.TabIndex = 3;
                guna2HtmlLabelEventLocation.Text = "Event_Location";

                var guna2HtmlLabelEventStart = new Guna.UI2.WinForms.Guna2HtmlLabel();
                guna2HtmlLabelEventStart.BackColor = System.Drawing.Color.Transparent;
                guna2HtmlLabelEventStart.Location = new System.Drawing.Point(3, 190);
                guna2HtmlLabelEventStart.Name = "guna2HtmlLabel9";
                guna2HtmlLabelEventStart.Size = new System.Drawing.Size(59, 15);
                guna2HtmlLabelEventStart.TabIndex = 4;
                guna2HtmlLabelEventStart.Text = "Event_Start";

                var guna2HtmlLabelEventEnd = new Guna.UI2.WinForms.Guna2HtmlLabel();
                guna2HtmlLabelEventEnd.BackColor = System.Drawing.Color.Transparent;
                guna2HtmlLabelEventEnd.Location = new System.Drawing.Point(113, 190);
                guna2HtmlLabelEventEnd.Name = "guna2HtmlLabel10";
                guna2HtmlLabelEventEnd.Size = new System.Drawing.Size(56, 15);
                guna2HtmlLabelEventEnd.TabIndex = 5;
                guna2HtmlLabelEventEnd.Text = "Event_End";

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
        public void JoinEvent() 
        { 
            
        }
    }
}
