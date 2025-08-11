using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Core.Entities;

namespace Notification.Core.Interfaces
{
    /// <summary>
    /// Interface for sending notifications.
    /// </summary>
    public interface INotificationSender
    {
        /// <summary>
        /// Type of notification (e.g., "email", "sms", "push").
        /// Used by factory to select sender.
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Sends the notification asynchronously.
        /// </summary>
        /// <param name="notification">Notification to send</param>
        Task SendAsync(Notification.Core.Entities.Notification notification);
    }
}
