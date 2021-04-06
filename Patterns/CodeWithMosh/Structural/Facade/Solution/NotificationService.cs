using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Facade.Solution
{
    class NotificationService
    {
        public void send(string message, string target)
        {
            Facade.NotificationServer notificationServer = new Facade.NotificationServer();
            var connection = notificationServer.Connect("10.0.1.3");
            var token = notificationServer.Authenticate("appid", "2837");
            notificationServer.Send(token, new Facade.Message(message), target);
            connection.Disconnect();
        }
    }
}
