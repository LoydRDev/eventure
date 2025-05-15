using System;

namespace eventure.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string EventStart { get; set; }
        public string EventEnd { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int CreatorID { get; set; }
        public DateTime DateCreated { get; set; }
    }
}