using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Core.Entities
{
    /// <summary>
    /// Defines supported notification types.
    /// </summary>
    public static class NotificationType
    {
        /// <summary>
        /// Email notification.
        /// </summary>
        public const string Email = "email";

        /// <summary>
        /// SMS notification.
        /// </summary>
        public const string SMS = "SMS";

        /// <summary>
        /// Push notification.
        /// </summary>
        public const string Push = "push";
    }
}
