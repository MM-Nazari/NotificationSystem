using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Core.Entities
{
    /// <summary>
    /// Represents a notification message.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Person or address to receive the notification.
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        /// Title or subject of the notification.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Main content of the notification.
        /// </summary>
        public string Text { get; set; }
    }
}
