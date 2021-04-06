using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.Exercise
{
    class GMailClientAdapter : IEmailProvider
    {
        private GMailClient GMailClient;

        public GMailClientAdapter(GMailClient gMailClient)
        {
            GMailClient = gMailClient;
        }

        public void Connect(Server server)
        {
            GMailClient.ConnectTo(server.Ip);
        }
    }
}
