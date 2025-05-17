using System;

namespace eventure.Models
{
    class Notification
    {
        public int UserID { get; set; }
        public int EventID { get; set; }
        public int OwnerID { get; set; }
        public string NotificationMessage { get; set; }
        public bool isRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
