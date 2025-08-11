using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Core.Entities
{
    /// <summary>
    /// Stores log details for a sent notification.
    /// </summary>
    public class NotificationLog
    {
        /// <summary>
        /// Time when the notification was sent.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Content of the sent notification.
        /// </summary>
        public string MessageContent { get; set; }

        /// <summary>
        /// True if sending was successful.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Error message if sending failed.
        /// </summary>
        public string? ErrorMessage { get; set; }
    }
}
