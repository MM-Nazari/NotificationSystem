using Moq;
using Notification.Core.Entities;
using Notification.Core.Interfaces;
using Notification.Service.Services;

namespace Notification.Test
{
    public class NotificationServiceTest
    {
        [Fact]
        public async Task SendAsync_ShouldUseFactoryToGetSender_AndCallSend()
        {
            // Arrange - prepare test data
            var notification = new Notification.Core.Entities.Notification
            {
                Receiver = "nazarimohammadmehdi6@gmail.com",
                Title = "Test",
                Text = "Test"
            };

            var type = "email";

            // Arrange - create mock for INotificationSender
            var senderMock = new Mock<INotificationSender>();
            senderMock.SetupGet(s => s.Type).Returns(type); // return 'email' type
            senderMock.Setup(s => s.SendAsync(notification)).Returns(Task.CompletedTask).Verifiable();

            // Arrange - create mock for INotificationSenderFactory
            var factoryMock = new Mock<INotificationSenderFactory>();
            factoryMock.Setup(f => f.GetSender(type)).Returns(senderMock.Object); // factory returns mocked sender

            // Arrange - create mock for INotificationLogger
            var loggerMock = new Mock<INotificationLogger>();
            loggerMock.Setup(l => l.Log(It.IsAny<NotificationLog>())).Verifiable();

            // Arrange - instantiate service with mocks
            var service = new NotificationService(factoryMock.Object, loggerMock.Object);

            // Act - call the method under test
            await service.SendAsync(notification, type);

            // Assert - verify SendAsync called once on sender
            senderMock.Verify(s => s.SendAsync(notification), Times.Once);

            // Assert - verify Log called once on logger
            loggerMock.Verify(l => l.Log(It.IsAny<NotificationLog>()), Times.Once);
        }
    }
}
