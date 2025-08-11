using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification.Core.Interfaces;
using Notification.Core.Entities;

namespace Notification.SendType.Email
{
    /// <summary>
    /// Sends notifications via Email.
    /// </summary>
    public class EmailNotificationSender : INotificationSender
    {
        /// <summary>
        /// Notification type identifier for Email.
        /// </summary>
        public string Type => NotificationType.Email;

        /// <summary>
        /// Sends the notification asynchronously.
        /// </summary>
        /// <param name="notification">Notification to send.</param>
        /// <returns>Task representing the send operation.</returns>
        public Task SendAsync(Core.Entities.Notification notification)
        {
            // TODO: Implement email sending logic here

            return Task.CompletedTask;
        }
    }
}
