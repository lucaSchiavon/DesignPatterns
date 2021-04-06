using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Facade
{
    class NotificationServer
    {
        //connect
        //autenticate
        //send
        //connection.disconnect

        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("sending a message");
        }
    }
}
