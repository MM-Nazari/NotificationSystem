using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Core.Interfaces;
using Notification.Core.Entities;

namespace Notification.SendType.Push
{
    /// <summary>
    /// Sends notifications via Push Notification.
    /// </summary>
    public class PushNotificationSender : INotificationSender
    {
        /// <summary>
        /// Notification type identifier for Push.
        /// </summary>
        public string Type => NotificationType.Push;

        /// <summary>
        /// Sends the notification asynchronously.
        /// </summary>
        /// <param name="notification">Notification to send.</param>
        /// <returns>Task representing the send operation.</returns>
        public Task SendAsync(Core.Entities.Notification notification)
        {
            // TODO: Implement push notification sending logic here

            return Task.CompletedTask;
        }
    }
}
