using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Core.Interfaces;
using Notification.Core.Entities;

namespace Notification.SendType.SMS
{
    /// <summary>
    /// Sends notifications via SMS.
    /// </summary>
    public class SMSNotificationSender : INotificationSender
    {
        /// <summary>
        /// Notification type identifier for SMS.
        /// </summary>
        public string Type => NotificationType.SMS;

        /// <summary>
        /// Sends the notification asynchronously.
        /// </summary>
        /// <param name="notification">Notification to send.</param>
        /// <returns>Task representing the send operation.</returns>
        public Task SendAsync(Core.Entities.Notification notification)
        {
            // TODO: Implement SMS sending logic here

            return Task.CompletedTask;
        }
    }
}
