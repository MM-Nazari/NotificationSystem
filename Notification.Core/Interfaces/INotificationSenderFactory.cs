using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Core.Interfaces
{
    /// <summary>
    /// Factory to get notification sender by type.
    /// </summary>
    public interface INotificationSenderFactory
    {
        /// <summary>
        /// Returns sender for given type.
        /// </summary>
        /// <param name="type">Notification type</param>
        /// <returns>Sender instance.</returns>
        INotificationSender GetSender(string type);
    }
}
