using Microsoft.Extensions.DependencyInjection;
using Notification.Core.Interfaces;
using Notification.Infrastructure.Log;
using Notification.SendType.Email;
using Notification.SendType.Push;
using Notification.SendType.SMS;
using Notification.Service.Services;

/// <summary>
/// registers all dependencies for DI container.
/// </summary>
public static class Program
{
    public static void Main(string[] args)
    {
        // Create DI service collection
        var services = new ServiceCollection();

        // Register notification senders
        services.AddSingleton<INotificationSender, EmailNotificationSender>();
        services.AddSingleton<INotificationSender, SMSNotificationSender>();
        services.AddSingleton<INotificationSender, PushNotificationSender>();

        // Register factory that resolves sender by type
        services.AddSingleton<INotificationSenderFactory, NotificationServiceFactory>();

        // Register logger implementation
        services.AddSingleton<INotificationLogger, NotificationLogger>();

        // Register main notification service
        services.AddSingleton<NotificationService>();

        // TODO: Build service provider and run application logic
    }
}
