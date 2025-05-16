using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventure.Models
{
    class Notification
    {
        public int UserID { get; set; }
        public int EventID { get; set; }
        public int CreatorID { get; set; }
        public string Message { get; set; }
        public bool isRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
