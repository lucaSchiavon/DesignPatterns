using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Adapter.Exercise
{
    class EmailClient : IEmailProvider
    {
        public void Connect(Server server)
        {
            Console.WriteLine("Connect EmailClient");
        }
    }
}
