using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.Exercise
{
    class EmailManager
    {
        private readonly Server server;

        public EmailManager(Server server)
        {
            this.server = server;
        }

        public void Connect(IEmailProvider emailProvider)
        {
            emailProvider.Connect(server);
        }
    }
}
