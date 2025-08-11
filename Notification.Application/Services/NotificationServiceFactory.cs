using Notification.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Service.Services
{
    /// <summary>
    /// Factory to provide notification sender based on type.
    /// </summary>
    public class NotificationServiceFactory : INotificationSenderFactory
    {

        public NotificationServiceFactory(IEnumerable<INotificationSender> availableSenders)
        {
            // TODO: Validate and map senders by type.
        }

        /// <summary>
        /// Returns sender by type.
        /// </summary>
        /// <param name="type">Notification type</param>
        /// <returns>INotificationSender implementation.</returns>
        public INotificationSender GetSender(string type)
        {
            // TODO: Validate input
            // TODO: Return sender 

            return null; // Placeholder - replace with actual sender
        }
    }
}
