using System;

namespace eventure.Models
{
    class Attendee
    {
        public int AttendeeID { get; set; }
        public int EventID { get; set; }
        public string Status { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
