using Notification.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Core.Interfaces
{
    /// <summary>
    /// Contract for logging notifications.
    /// </summary>
    public interface INotificationLogger
    {
        /// <summary>
        /// Logs notification details.
        /// </summary>
        /// <param name="log">Notification log</param>
        void Log(NotificationLog log);
    }
}
