using Notification.Core.Entities;
using Notification.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Infrastructure.Log
{
    /// <summary>
    /// Logs notification details (e.g., to console, file, or DB).
    /// </summary>
    public class NotificationLogger : INotificationLogger
    {
        /// <summary>
        /// Logs the given notification.
        /// </summary>
        /// <param name="log">Notification log detail</param>
        public void Log(NotificationLog log)
        {
            // TODO: Implement logging (e.g., console, file, or database)
        }
    }
}
