using Notification.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Service.Services
{
    /// <summary>
    /// Coordinates sending notifications and logging results.
    /// </summary>
    public class NotificationService
    {
        private readonly INotificationSenderFactory _factory;
        private readonly INotificationLogger _logger;

        public NotificationService(INotificationSenderFactory factory, INotificationLogger logger)
        {
            _factory = factory;
            _logger = logger;
        }

        /// <summary>
        /// Sends notification using specified type, then logs the result.
        /// </summary>
        /// <param name="notification">Notification details</param>
        /// <param name="type">Notification type</param>
        /// <returns>Async task.</returns>
        public async Task SendAsync(Notification.Core.Entities.Notification notification, string type)
        {
            // TODO: Use factory to get sender by type
            // TODO: Call sender.SendAsync(notification)
            // TODO: Create log entry and submit via logger

            await Task.CompletedTask;
        }
    }
}
