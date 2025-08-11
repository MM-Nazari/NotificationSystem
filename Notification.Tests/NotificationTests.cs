using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Notification.Tests
{
    public class NotificationTests
    {
        [Fact]
        public async Task SendAsync_ShouldUseFactoryToGetSender_AndCallSend()
        {
            // Arrange
            var notification = new Notification
            {
                Receiver = "user@example.com",
                Title = "Test",
                Text = "Hello"
            };

            var type = "email";

            // Mock sender
            var senderMock = new Mock<INotificationSender>();
            senderMock.SetupGet(s => s.Type).Returns(type);
            senderMock.Setup(s => s.SendAsync(notification)).Returns(Task.CompletedTask).Verifiable();

            // Mock factory to return mocked sender
            var factoryMock = new Mock<INotificationSenderFactory>();
            factoryMock.Setup(f => f.GetSender(type)).Returns(senderMock.Object);

            // Mock logger
            var loggerMock = new Mock<INotificationLogger>();
            loggerMock.Setup(l => l.Log(It.IsAny<NotificationLog>())).Verifiable();

            // Create service with mocks
            var service = new NotificationService(factoryMock.Object, loggerMock.Object);

            // Act
            await service.SendAsync(notification, type);

            // Assert
            senderMock.Verify(s => s.SendAsync(notification), Times.Once);
            loggerMock.Verify(l => l.Log(It.IsAny<NotificationLog>()), Times.Once);
        }
    }
}
